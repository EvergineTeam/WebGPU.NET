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
            var headerFile = Path.Combine(AppContext.BaseDirectory, "Headers", "wgpu.h");
            var options = new CppParserOptions
            {
                ParseMacros = true,
                Defines =
                {
                    "WGPU_SHARED_LIBRARY",
                    "_WIN32",
                    "WGPU_SKIP_PROCS"
                }
            };

            var compilation = CppParser.ParseFile(headerFile, options);

            // Print diagnostic messages
            if (compilation.HasErrors)
            {
                foreach (var message in compilation.Diagnostics.Messages)
                {
                    Console.WriteLine(message);
                }
            }
            else
            {
                string basePath = "..\\..\\..\\..\\Evergine.Bindings.WebGPU\\Generated";

                if (!Directory.Exists(basePath))
                {
                    Directory.CreateDirectory(basePath);
                }

                CsCodeGenerator.Instance.Generate(compilation, basePath);
            }
        }
    }
}
