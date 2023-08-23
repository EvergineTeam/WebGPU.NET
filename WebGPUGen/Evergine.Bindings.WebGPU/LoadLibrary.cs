using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Evergine.Bindings.WebGPU
{
    public static unsafe partial class WebGPUNative
    {
        static WebGPUNative()
        {
            string libraryName = GetLibraryName();
            string libraryPath = GetLibraryPath(libraryName);

            bool success = NativeLibrary.TryLoad(libraryPath, out var handle);
            if (!success)
            {
                throw new ApplicationException($"Unable to load the wgpu-native library. {libraryPath}");
            }
        }

        private static string GetLibraryName()
        {
            string name = string.Empty;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                name = "wgpu_native.dll";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                name = "libwgpu_native.so";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                name = "libwgpu_native.dylib";
            }
            else
            {
                throw new PlatformNotSupportedException("Platform not supported.");
            }

            return name;
        }

        private static string GetLibraryPath(string libraryName)
        {
            string os = GetOSPlatform();
            string architexture = GetArchitecture();

            string assemblyLocation = Assembly.GetExecutingAssembly() != null ? Assembly.GetExecutingAssembly().Location : typeof(WebGPUNative).Assembly.Location;
            assemblyLocation = Path.GetDirectoryName(assemblyLocation);
            string path = Path.Combine(assemblyLocation, "runtimes", $"{os}-{architexture}", "native", libraryName);
            if(File.Exists(path)) 
            {
                return path;
            }

            return libraryName;
        }

        private static string GetOSPlatform()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return "win";
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                return "linux";
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                return "osx";

            throw new ArgumentException("Unsupported OS platform.");
        }

        private static string GetArchitecture()
        {
            switch (RuntimeInformation.ProcessArchitecture)
            {
                case Architecture.X86: return "x86";
                case Architecture.X64: return "x64";
                case Architecture.Arm: return "arm";
                case Architecture.Arm64: return "arm64";
            }

            throw new ArgumentException("Unsupported architecture.");
        }
    }
}
