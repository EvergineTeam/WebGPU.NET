using System;

namespace WaveEngine.Bindings.WebGPU
{
	public unsafe delegate void WGPUBufferMapCallback(
		 WGPUBufferMapAsyncStatus status,
		 void* userdata);

	public unsafe delegate void WGPUDeviceLostCallback(
		 char* message,
		 void* userdata);

	public unsafe delegate void WGPUErrorCallback(
		 WGPUErrorType type,
		 char* message,
		 void* userdata);

	public unsafe delegate void WGPUFenceOnCompletionCallback(
		 WGPUFenceCompletionStatus status,
		 void* userdata);

	public unsafe delegate void WGPURequestAdapterCallback(
		 IntPtr result,
		 void* userdata);

	public unsafe delegate void WGPURequestDeviceCallback(
		 IntPtr result,
		 void* userdata);

	public unsafe delegate void WGPUSurfaceGetPreferredFormatCallback(
		 WGPUTextureFormat format,
		 void* userdata);

	public unsafe delegate void WGPUProc();

}
