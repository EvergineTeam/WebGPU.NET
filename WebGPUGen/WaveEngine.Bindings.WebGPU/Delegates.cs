using System;

namespace WaveEngine.Bindings.WebGPU
{
	public unsafe delegate void WGPUBufferMapCallback(
		 WGPUBufferMapAsyncStatus status,
		 void* userdata);

	public unsafe delegate void WGPUCompilationInfoCallback(
		 WGPUCompilationInfoRequestStatus status,
		 WGPUCompilationInfo* compilationInfo,
		 void* userdata);

	public unsafe delegate void WGPUCreateComputePipelineAsyncCallback(
		 WGPUCreatePipelineAsyncStatus status,
		 IntPtr pipeline,
		 char* message,
		 void* userdata);

	public unsafe delegate void WGPUCreateRenderPipelineAsyncCallback(
		 WGPUCreatePipelineAsyncStatus status,
		 IntPtr pipeline,
		 char* message,
		 void* userdata);

	public unsafe delegate void WGPUDeviceLostCallback(
		 WGPUDeviceLostReason reason,
		 char* message,
		 void* userdata);

	public unsafe delegate void WGPUErrorCallback(
		 WGPUErrorType type,
		 char* message,
		 void* userdata);

	public unsafe delegate void WGPUProc();

	public unsafe delegate void WGPUQueueWorkDoneCallback(
		 WGPUQueueWorkDoneStatus status,
		 void* userdata);

	public unsafe delegate void WGPURequestAdapterCallback(
		 WGPURequestAdapterStatus status,
		 IntPtr adapter,
		 char* message,
		 void* userdata);

	public unsafe delegate void WGPURequestDeviceCallback(
		 WGPURequestDeviceStatus status,
		 IntPtr device,
		 char* message,
		 void* userdata);

}
