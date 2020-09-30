using CppAst;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;

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

        public void Generate(CppCompilation compilation, string basePath, string flavour)
        {
            string outputPath = basePath + "." + flavour;
            Helpers.TypedefList = compilation.Typedefs
                    .Where(t => t.TypeKind == CppTypeKind.Typedef
                           && t.ElementType is CppPointerType
                           && ((CppPointerType)t.ElementType).ElementType.TypeKind != CppTypeKind.Function)
                    .Select(t => t.Name).ToList();

            GenerateDelegates(compilation, outputPath, flavour);
            GenerateEnums(compilation, outputPath, flavour);
            GenerateStructs(compilation, outputPath, flavour);
            GenerateCommmands(compilation, outputPath, flavour);
        }

        private void GenerateDelegates(CppCompilation compilation, string outputPath, string flavour)
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

        private void GenerateCommmands(CppCompilation compilation, string outputPath, string flavour)
        {
            Debug.WriteLine("Generating Commands...");

            bool isBrowser = false;
            string dllName;
            if (flavour == "Browser")
            {
                isBrowser = true;
                dllName="libWebGPU";
            }
            else if (flavour == "Dawn")
            {
                dllName = "dawn_proc.dll";
            }
            else
            {
                throw new Exception($"Flavour ${flavour} not supported");
            }

            using (StreamWriter file = File.CreateText(Path.Combine(outputPath, "Commands.cs")))
            {
                file.WriteLine("using System;");
                file.WriteLine("using System.Diagnostics;");
                file.WriteLine("using System.Runtime.InteropServices;\n");
                file.WriteLine("namespace WaveEngine.Bindings.WebGPU");
                file.WriteLine("{");
                file.WriteLine("\tpublic static unsafe partial class WebGPUNative");
                file.WriteLine("\t{");
                file.WriteLine($"\t\tprivate const string dllName = \"{dllName}\";");

                foreach (var command in compilation.Functions)
                {
                    string convertedType = Helpers.ConvertToCSharpType(command.ReturnType, false);

                    if (!isBrowser || !emscriptenUnsupportedCommands.Contains(command.Name))
                    {
                        file.WriteLine("\n\t\t[DllImport(dllName)]");
                        file.WriteLine($"\t\tpublic static extern {convertedType} {command.Name}({Helpers.GetParametersSignature(command)});");
                    }
                }

                file.WriteLine("\t}");
                file.WriteLine("}");
            }
        }

        private void GenerateStructs(CppCompilation compilation, string outputPath, string flavour)
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

        public void GenerateEnums(CppCompilation compilation, string outputPath, string flavour)
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
