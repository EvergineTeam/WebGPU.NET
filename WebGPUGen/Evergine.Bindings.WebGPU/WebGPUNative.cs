using System.Runtime.InteropServices;

namespace Evergine.Bindings.WebGPU
{
    public static unsafe partial class WebGPUNative
    {
        [DllImport("wgpu_native")]
        public static extern void emscripten_get_element_css_size(char* target, double* width, double* height);

        [DllImport("wgpu_native")]
        public static extern WGPUDevice emscripten_webgpu_get_device();
    }
}
