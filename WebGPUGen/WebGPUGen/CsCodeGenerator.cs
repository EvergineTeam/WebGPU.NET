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
            GenerateEnums(compilation, outputPath);
            GenerateStructs(compilation, outputPath);
            GenerateCommmands(compilation, outputPath);
        }

        private void GenerateCommmands(CppCompilation compilation, string outputPath)
        {
            Debug.WriteLine("Generating Commands...");

            using (StreamWriter file = File.CreateText(Path.Combine(outputPath, "Commands.cs")))
            {
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

                var structs = compilation.Classes.Where(c => c.ClassKind == CppClassKind.Struct);
                foreach (var structure in structs)
                {
                    file.WriteLine("\t[StructLayout(LayoutKind.Sequential)]");
                    file.WriteLine($"\tpublic unsafe struct {structure.Name}");
                    file.WriteLine("\t{");
                    foreach (var member in structure.Fields)
                    {
                        var type = Helpers.ConvertToCSharpType(member.Type);

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
