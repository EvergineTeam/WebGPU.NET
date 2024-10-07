using System;

namespace Evergine.Bindings.WebGPU
{
	public unsafe delegate void WGPUProc();

	public unsafe delegate void WGPUDeviceLostCallback(
		 WGPUDeviceLostReason reason,
		 char* message,
		 void* userdata);

	public unsafe delegate void WGPUErrorCallback(
		 WGPUErrorType type,
		 char* message,
		 void* userdata);

	public unsafe delegate void WGPUAdapterRequestDeviceCallback(
		 WGPURequestDeviceStatus status,
		 WGPUDevice device,
		 char* message,
		 void* userdata);

	public unsafe delegate void WGPUBufferMapAsyncCallback(
		 WGPUBufferMapAsyncStatus status,
		 void* userdata);

	public unsafe delegate void WGPUDeviceCreateComputePipelineAsyncCallback(
		 WGPUCreatePipelineAsyncStatus status,
		 WGPUComputePipeline pipeline,
		 char* message,
		 void* userdata);

	public unsafe delegate void WGPUDeviceCreateRenderPipelineAsyncCallback(
		 WGPUCreatePipelineAsyncStatus status,
		 WGPURenderPipeline pipeline,
		 char* message,
		 void* userdata);

	public unsafe delegate void WGPUInstanceRequestAdapterCallback(
		 WGPURequestAdapterStatus status,
		 WGPUAdapter adapter,
		 char* message,
		 void* userdata);

	public unsafe delegate void WGPUQueueOnSubmittedWorkDoneCallback(
		 WGPUQueueWorkDoneStatus status,
		 void* userdata);

	public unsafe delegate void WGPUShaderModuleGetCompilationInfoCallback(
		 WGPUCompilationInfoRequestStatus status,
		 WGPUCompilationInfo* compilationInfo,
		 void* userdata);

	public unsafe delegate void WGPULogCallback(
		 WGPULogLevel level,
		 char* message,
		 void* userdata);

}
