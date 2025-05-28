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
        }

        [DllImport("webgpu-binding")]
        private static extern IntPtr webgpu_binding_emscripten_webgpu_get_device();
    }
}
