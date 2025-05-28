//using Evergine.Bindings.WebGPU;
using System.Runtime.InteropServices;

namespace HelloTriangleWasm.Pages
{
    public partial class Home
    {
        public void Run()
        {
            Console.WriteLine("Hello, WebGPU!");
            var device = webgpu_binding_emscripten_webgpu_get_device();
            Console.WriteLine(device);
            // It does not work because: System.DllNotFoundException: wgpu_native
            //var queue = WebGPUNative.wgpuDeviceGetQueue(device);
            var queue = wgpuDeviceGetQueue(device);
            Console.WriteLine(queue);
        }

        [DllImport("webgpu-binding")]
        private static extern IntPtr webgpu_binding_emscripten_webgpu_get_device();


        [DllImport("webgpu-binding")]
        public static extern IntPtr wgpuDeviceGetQueue(IntPtr device);
    }
}
