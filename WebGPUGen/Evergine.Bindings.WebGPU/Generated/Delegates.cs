using System;

namespace Evergine.Bindings.WebGPU
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
		 WGPUComputePipeline pipeline,
		 char* message,
		 void* userdata);

	public unsafe delegate void WGPUCreateRenderPipelineAsyncCallback(
		 WGPUCreatePipelineAsyncStatus status,
		 WGPURenderPipeline pipeline,
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
		 WGPUAdapter adapter,
		 char* message,
		 void* userdata);

	public unsafe delegate void WGPURequestDeviceCallback(
		 WGPURequestDeviceStatus status,
		 WGPUDevice device,
		 char* message,
		 void* userdata);

}
