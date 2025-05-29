using System.Runtime.InteropServices;

namespace HelloTriangleWasm
{
    public unsafe class WebGPUEmscripten
    {
        [DllImport("wgpu_native")]
        public static extern void webgpu_native_emscripten_get_element_css_size(char* target, double* width, double* height);

        [DllImport("wgpu_native")]
        public static extern IntPtr webgpu_native_emscripten_webgpu_get_device();
    }
}
