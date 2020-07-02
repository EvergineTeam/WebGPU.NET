using CppAst;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace WebGPUGen
{
    public class CsCodeGenerator
    {
        private CsCodeGenerator()
        {
        }

        public static CsCodeGenerator Instance { get; } = new CsCodeGenerator();

        public void Generate(CppCompilation compilation, string outputPath)
        {
            Helpers.TypedefList = compilation.Typedefs
                    .Where(t => t.TypeKind == CppTypeKind.Typedef
                           && t.ElementType is CppPointerType
                           && ((CppPointerType)t.ElementType).ElementType.TypeKind != CppTypeKind.Function)
                    .Select(t => t.Name).ToList();

            GenerateDelegates(compilation, outputPath);
            GenerateEnums(compilation, outputPath);
            GenerateStructs(compilation, outputPath);
            GenerateCommmands(compilation, outputPath);
        }

        private void GenerateDelegates(CppCompilation compilation, string outputPath)
        {
            Debug.WriteLine("Generating Delegates...");

            var delegates = compilation.Typedefs
                .Where(t => t.TypeKind == CppTypeKind.Typedef
                       && t.ElementType is CppPointerType
                       && ((CppPointerType)t.ElementType).ElementType.TypeKind == CppTypeKind.Function)
                .ToList();

            using (StreamWriter file = File.CreateText(Path.Combine(outputPath, "Delegates.cs")))
            {
                file.WriteLine("using System;\n");
                file.WriteLine("namespace WaveEngine.Bindings.WebGPU");
                file.WriteLine("{");

                foreach (var funcPointer in delegates)
                {
                    CppFunctionType pointerType = ((CppPointerType)funcPointer.ElementType).ElementType as CppFunctionType;

                    file.Write($"\tpublic unsafe delegate {pointerType.ReturnType} {funcPointer.Name}(");

                    if (pointerType.Parameters.Count > 0)
                    {
                        file.Write("\n");

                        for (int i = 0; i < pointerType.Parameters.Count; i++)
                        {
                            if (i > 0)
                                file.Write(",\n");

                            var parameter = pointerType.Parameters[i];
                            var convertedType = Helpers.ConvertToCSharpType(parameter.Type);
                            file.Write($"\t\t {convertedType} {parameter.Name}");
                        }
                    }

                    file.Write(");\n\n");
                }

                file.WriteLine("}");
            }
        }

        private void GenerateCommmands(CppCompilation compilation, string outputPath)
        {
            Debug.WriteLine("Generating Commands...");

            using (StreamWriter file = File.CreateText(Path.Combine(outputPath, "Commands.cs")))
            {
                file.WriteLine("using System;");
                file.WriteLine("using System.Runtime.InteropServices;\n");
                file.WriteLine("namespace WaveEngine.Bindings.WebGPU");
                file.WriteLine("{");
                file.WriteLine("\tpublic static unsafe partial class WebGPUNative");
                file.WriteLine("\t{");
                file.WriteLine("\t\tprivate static Func<string, IntPtr> s_getProcAddress;\n");
                file.WriteLine("\t\tprivate const CallingConvention CallConv = CallingConvention.Winapi;\n");

                foreach (var command in compilation.Functions)
                {
                    string convertedType = Helpers.ConvertToCSharpType(command.ReturnType, false);

                    file.WriteLine("\t\t[UnmanagedFunctionPointer(CallConv)]");

                    // Delegate
                    file.WriteLine($"\t\tprivate delegate {convertedType} {command.Name}Delegate({Helpers.GetParametersSignature(command)});");

                    // internal function
                    file.WriteLine($"\t\tprivate static {command.Name}Delegate {command.Name}_ptr;");

                    // public function
                    file.WriteLine($"\t\tpublic static {convertedType} {command.Name}({Helpers.GetParametersSignature(command)})");
                    file.WriteLine($"\t\t\t=> {command.Name}_ptr({Helpers.GetParametersSignature(command, false)});\n");
                }

                file.WriteLine($"\n\t\tpublic static void LoadFuncionPointers(Func<string, IntPtr> getProcAddress)");
                file.WriteLine("\t\t{");
                file.WriteLine("\t\t\ts_getProcAddress = getProcAddress;\n");

                foreach (var command in compilation.Functions)
                {
                    file.WriteLine($"\t\t\tLoadFunction(\"{command.Name}\",  out {command.Name}_ptr);");
                }

                file.WriteLine("\t\t}\n");

                file.WriteLine("\t\tprivate static void LoadFunction<T>(string name, out T field)");
                file.WriteLine("\t\t{");
                file.WriteLine("\t\t\tIntPtr funcPtr = s_getProcAddress(name);");
                file.WriteLine("\t\t\tif (funcPtr != IntPtr.Zero)");
                file.WriteLine("\t\t\t{");
                file.WriteLine("\t\t\t\tfield = Marshal.GetDelegateForFunctionPointer<T>(funcPtr);");
                file.WriteLine("\t\t\t}");
                file.WriteLine("\t\t\telse");
                file.WriteLine("\t\t\t{");
                file.WriteLine("\t\t\t\tfield = default(T);");
                file.WriteLine("\t\t\t}");
                file.WriteLine("\t\t}");

                file.WriteLine("\t}");
                file.WriteLine("}");
            }
        }

        private void GenerateStructs(CppCompilation compilation, string outputPath)
        {
            Debug.WriteLine("Generating Structs...");

            using (StreamWriter file = File.CreateText(Path.Combine(outputPath, "Structs.cs")))
            {
                file.WriteLine("using System;");
                file.WriteLine("using System.Runtime.InteropServices;\n");
                file.WriteLine("namespace WaveEngine.Bindings.WebGPU");
                file.WriteLine("{");

                var structs = compilation.Classes.Where(c => c.ClassKind == CppClassKind.Struct && c.IsDefinition == true);

                foreach (var structure in structs)
                {
                    file.WriteLine("\t[StructLayout(LayoutKind.Sequential)]");
                    file.WriteLine($"\tpublic unsafe struct {structure.Name}");
                    file.WriteLine("\t{");
                    foreach (var member in structure.Fields)
                    {
                        string type = type = Helpers.ConvertToCSharpType(member.Type);

                        file.WriteLine($"\t\tpublic {type} {member.Name};");
                    }

                    file.WriteLine("\t}\n");
                }
                file.WriteLine("}\n");
            }
        }

        public void GenerateEnums(CppCompilation compilation, string outputPath)
        {
            Debug.WriteLine("Generating Enums...");

            using (StreamWriter file = File.CreateText(Path.Combine(outputPath, "Enums.cs")))
            {
                file.WriteLine("using System;\n");
                file.WriteLine("namespace WaveEngine.Bindings.WebGPU");
                file.WriteLine("{");

                foreach (var cppEnum in compilation.Enums)
                {
                    if (compilation.Typedefs.Any(t => t.Name == cppEnum.Name + "Flags"))
                    {
                        file.WriteLine("\t[Flags]");
                    }

                    file.WriteLine($"\tpublic enum {cppEnum.Name}");
                    file.WriteLine("\t{");

                    foreach (var member in cppEnum.Items)
                    {
                        file.WriteLine($"\t\t{member.Name} = {member.Value},");
                    }

                    file.WriteLine("\t}\n");
                }

                file.WriteLine("}");
            }
        }
    }
}
