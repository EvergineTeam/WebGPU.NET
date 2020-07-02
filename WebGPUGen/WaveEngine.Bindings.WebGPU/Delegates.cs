using System;

namespace WaveEngine.Bindings.WebGPU
{
	public unsafe delegate void WGPUBufferMapReadCallback();

	public unsafe delegate void WGPUBufferMapWriteCallback();

	public unsafe delegate void WGPUDeviceLostCallback();

	public unsafe delegate void WGPUErrorCallback();

	public unsafe delegate void WGPUFenceOnCompletionCallback();

	public unsafe delegate void WGPURequestAdapterCallback();

	public unsafe delegate void WGPURequestDeviceCallback();

	public unsafe delegate void WGPUSurfaceGetPreferredFormatCallback();

	public unsafe delegate void WGPUProc();

}
