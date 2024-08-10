using CppAst;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;

namespace WebGPUGen
{
    public class CsCodeGenerator
    {
        private static readonly IList<String> emscriptenUnsupportedCommands = new ReadOnlyCollection<string>
            (new List<String> {
                 "wgpuDevicePopErrorScope",
                 "wgpuDevicePushErrorScope",
                 "wgpuDeviceSetDeviceLostCallback",
                 "wgpuFenceGetCompletedValue",
                 "wgpuRenderBundleEncoderDrawIndexedIndirect",
                 "wgpuRenderBundleEncoderDrawIndirect"
            });

        private CsCodeGenerator()
        {
        }

        public static CsCodeGenerator Instance { get; } = new CsCodeGenerator();

        public void Generate(CppCompilation compilation, string basePath)
        {
            string outputPath = basePath;

            GenerateConstants(compilation, outputPath);
            GenerateDelegates(compilation, outputPath);
            GenerateEnums(compilation, outputPath);
            GenerateStructs(compilation, outputPath);
            GenerateCommmands(compilation, outputPath);
            GeneratedHandles(compilation, outputPath);
        }

        private void GenerateConstants(CppCompilation compilation, string outputPath)
        {
            Debug.WriteLine("Generating Constants...");
            using (StreamWriter file = File.CreateText(Path.Combine(outputPath, "Constants.cs")))
            {
                file.WriteLine("namespace Evergine.Bindings.WebGPU");
                file.WriteLine("{");
                file.WriteLine("\tpublic static partial class WebGPUNative");
                file.WriteLine("\t{");

                foreach (var constant in compilation.Macros)
                {
                    string constantValue = Helpers.NormalizeConstantValue(constant.Value);

                    if(Helpers.SkipConstant(constant)) 
                        continue;

                    if(constant.Name == "WGPU_WHOLE_MAP_SIZE")
                        file.WriteLine($"\t\tpublic static readonly nuint WGPU_WHOLE_MAP_SIZE = nuint.MaxValue;");
                    else
                        file.WriteLine($"\t\tpublic const {Helpers.GetConstantType(constantValue)} {constant.Name} = {constantValue};");
                }

                file.WriteLine("\t}");
                file.WriteLine("}");
            }
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
                file.WriteLine("namespace Evergine.Bindings.WebGPU");
                file.WriteLine("{");

                foreach (var funcPointer in delegates)
                {
                    CppFunctionType pointerType = ((CppPointerType)funcPointer.ElementType).ElementType as CppFunctionType;

                    var returnType = Helpers.ConvertToCSharpType(pointerType.ReturnType);
                    file.Write($"\tpublic unsafe delegate {returnType} {funcPointer.Name}(");

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
                file.WriteLine("using System.Diagnostics;");
                file.WriteLine("using System.Runtime.InteropServices;\n");
                file.WriteLine("namespace Evergine.Bindings.WebGPU");
                file.WriteLine("{");
                file.WriteLine("\tpublic static unsafe partial class WebGPUNative");
                file.WriteLine("\t{");

                foreach (var command in compilation.Functions)
                {
                    string convertedType = Helpers.ConvertToCSharpType(command.ReturnType, false);

                    if (!emscriptenUnsupportedCommands.Contains(command.Name))
                    {
                        file.WriteLine($"\n\t\t[DllImport(\"wgpu_native\", CallingConvention = CallingConvention.Cdecl, EntryPoint = \"{command.Name}\")]");
                        file.WriteLine($"\t\tpublic static extern {convertedType} {command.Name}({Helpers.GetParametersSignature(command)});");
                    }
                }

                file.WriteLine("\t}");
                file.WriteLine("}");
            }
        }

        private void GeneratedHandles(CppCompilation compilation, string outputPath)
        {
            Debug.WriteLine("Generating Handles...");

            using (StreamWriter file = File.CreateText(Path.Combine(outputPath, "Handles.cs")))
            {
                file.WriteLine("using System;");
                file.WriteLine("using System.Diagnostics;");
                file.WriteLine("using System.Runtime.InteropServices;\n");
                file.WriteLine("namespace Evergine.Bindings.WebGPU");
                file.WriteLine("{");

                foreach (CppTypedef typedef in compilation.Typedefs)
                {
                    if (typedef.Name.StartsWith("WGPUProc") ||
                    typedef.Name.EndsWith("Callback"))
                    {
                        continue;
                    }

                    if (typedef.ElementType is not CppPointerType)
                    {
                        continue;
                    }

                    file.WriteLine($"\tpublic partial struct {typedef.Name} : IEquatable<{typedef.Name}>");
                    file.WriteLine("\t{");
                    string handleType = "IntPtr";
                    string nullValue = "IntPtr.Zero";

                    file.WriteLine($"\tpublic readonly {handleType} Handle;");

                    file.WriteLine($"\tpublic {typedef.Name}({handleType} existingHandle) {{ Handle = existingHandle; }}");
                    file.WriteLine($"\tpublic static {typedef.Name} Null => new {typedef.Name}({nullValue});");
                    file.WriteLine($"\tpublic static implicit operator {typedef.Name}({handleType} handle) => new {typedef.Name}(handle);");
                    file.WriteLine($"\tpublic static bool operator ==({typedef.Name} left, {typedef.Name} right) => left.Handle == right.Handle;");
                    file.WriteLine($"\tpublic static bool operator !=({typedef.Name} left, {typedef.Name} right) => left.Handle != right.Handle;");
                    file.WriteLine($"\tpublic static bool operator ==({typedef.Name} left, {handleType} right) => left.Handle == right;");
                    file.WriteLine($"\tpublic static bool operator !=({typedef.Name} left, {handleType} right) => left.Handle != right;");
                    file.WriteLine($"\tpublic bool Equals({typedef.Name} h) => Handle == h.Handle;");
                    file.WriteLine($"\tpublic override bool Equals(object o) => o is {typedef.Name} h && Equals(h);");
                    file.WriteLine($"\tpublic override int GetHashCode() => Handle.GetHashCode();");
                    file.WriteLine("\t}\n");
                }

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
                file.WriteLine("namespace Evergine.Bindings.WebGPU");
                file.WriteLine("{");

                var structs = compilation.Classes.Where(c => c.ClassKind == CppClassKind.Struct && c.IsDefinition == true);

                foreach (var structure in structs)
                {
                    file.WriteLine("\t[StructLayout(LayoutKind.Sequential)]");
                    file.WriteLine($"\tpublic unsafe struct {structure.Name}");
                    file.WriteLine("\t{");
                    foreach (var member in structure.Fields)
                    {
                        string type = Helpers.ConvertToCSharpType(member.Type);

                        if (type == "bool")
                        {
                            // This is to marshal bool as one byte
                            // https://stackoverflow.com/questions/28514373/what-is-the-size-of-a-boolean-in-c-does-it-really-take-4-bytes/28515361
                            // https://stackoverflow.com/questions/11416433/marshalling-non-blittable-structs-from-c-sharp-to-c
                            // https://stackoverflow.com/questions/32110152/c-sharp-marshalling-bool
                            file.WriteLine($"\t\t[MarshalAs(UnmanagedType.I1)]");
                        }
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
                file.WriteLine("namespace Evergine.Bindings.WebGPU");
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
                        string cleanMemberName = member.Name.Split('_')[1];
                        if (char.IsNumber(cleanMemberName, 0))
                            cleanMemberName = $"_{cleanMemberName}";

                        file.WriteLine($"\t\t{cleanMemberName} = {member.Value},");
                    }

                    file.WriteLine("\t}\n");
                }

                file.WriteLine("}");
            }
        }
    }
}
