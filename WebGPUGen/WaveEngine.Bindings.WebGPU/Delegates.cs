using System;

namespace WaveEngine.Bindings.WebGPU
{
	public unsafe delegate void WGPUBufferMapReadCallback(
		 WGPUBufferMapAsyncStatus status,
		 void* data,
		 ulong dataLength,
		 void* userdata);

	public unsafe delegate void WGPUBufferMapWriteCallback(
		 WGPUBufferMapAsyncStatus status,
		 void* data,
		 ulong dataLength,
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

	public unsafe delegate void WGPUProc();

}
