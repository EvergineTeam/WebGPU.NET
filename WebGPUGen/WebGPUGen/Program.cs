using CppAst;
using System;
using System.Diagnostics;
using System.IO;

namespace WebGPUGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var headerFile = Path.Combine(AppContext.BaseDirectory, "Headers", "webgpu.h");
            var options = new CppParserOptions
            {
                ParseMacros = true,
                Defines =
                {
                    "WGPU_SHARED_LIBRARY",
                    "_WIN32"
                }
            };

            var compilation = CppParser.ParseFile(headerFile, options);

            // Print diagnostic messages
            if (compilation.HasErrors)
            {
                foreach (var message in compilation.Diagnostics.Messages)
                {
                    Debug.WriteLine(message);
                }
            }
            else
            {
                string outputPath = "..\\..\\..\\..\\WaveEngine.Bindings.WebGPU";
                CsCodeGenerator.Instance.Generate(compilation, outputPath);
            }
        }
    }
}
