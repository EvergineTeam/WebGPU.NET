using System.Runtime.InteropServices;

namespace Evergine.Bindings.WebGPU
{
    public static unsafe partial class WebGPUNative
    {
        [DllImport("wgpu_native")]
        public static extern void emscripten_get_element_css_size(char* target, double* width, double* height);

        [DllImport("wgpu_native")]
        public static extern WGPUDevice emscripten_webgpu_get_device();

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl)]
        public static extern void wgpuBufferMapAsyncWithoutCallback(WGPUBuffer buffer, WGPUMapMode mode, uint offset, uint size, void* userdata);
    }
}
