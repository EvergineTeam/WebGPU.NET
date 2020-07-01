using System;
using System.Runtime.InteropServices;

namespace WaveEngine.Bindings.WebGPU
{
	public static unsafe partial class WebGPUNative
	{
		private static Func<string, IntPtr> s_getProcAddress;

		private const CallingConvention CallConv = CallingConvention.Winapi;

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUInstance wgpuCreateInstanceDelegate();
		private static wgpuCreateInstanceDelegate wgpuCreateInstance_ptr;
		public static WGPUInstance wgpuCreateInstance()
			=> wgpuCreateInstance_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUProc wgpuGetProcAddressDelegate();
		private static wgpuGetProcAddressDelegate wgpuGetProcAddress_ptr;
		public static WGPUProc wgpuGetProcAddress()
			=> wgpuGetProcAddress_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuAdapterGetPropertiesDelegate();
		private static wgpuAdapterGetPropertiesDelegate wgpuAdapterGetProperties_ptr;
		public static void wgpuAdapterGetProperties()
			=> wgpuAdapterGetProperties_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuAdapterRequestDeviceDelegate();
		private static wgpuAdapterRequestDeviceDelegate wgpuAdapterRequestDevice_ptr;
		public static void wgpuAdapterRequestDevice()
			=> wgpuAdapterRequestDevice_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuBufferDestroyDelegate();
		private static wgpuBufferDestroyDelegate wgpuBufferDestroy_ptr;
		public static void wgpuBufferDestroy()
			=> wgpuBufferDestroy_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void* wgpuBufferGetConstMappedRangeDelegate();
		private static wgpuBufferGetConstMappedRangeDelegate wgpuBufferGetConstMappedRange_ptr;
		public static void* wgpuBufferGetConstMappedRange()
			=> wgpuBufferGetConstMappedRange_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void* wgpuBufferGetMappedRangeDelegate();
		private static wgpuBufferGetMappedRangeDelegate wgpuBufferGetMappedRange_ptr;
		public static void* wgpuBufferGetMappedRange()
			=> wgpuBufferGetMappedRange_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuBufferMapReadAsyncDelegate();
		private static wgpuBufferMapReadAsyncDelegate wgpuBufferMapReadAsync_ptr;
		public static void wgpuBufferMapReadAsync()
			=> wgpuBufferMapReadAsync_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuBufferMapWriteAsyncDelegate();
		private static wgpuBufferMapWriteAsyncDelegate wgpuBufferMapWriteAsync_ptr;
		public static void wgpuBufferMapWriteAsync()
			=> wgpuBufferMapWriteAsync_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuBufferUnmapDelegate();
		private static wgpuBufferUnmapDelegate wgpuBufferUnmap_ptr;
		public static void wgpuBufferUnmap()
			=> wgpuBufferUnmap_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUComputePassEncoder wgpuCommandEncoderBeginComputePassDelegate();
		private static wgpuCommandEncoderBeginComputePassDelegate wgpuCommandEncoderBeginComputePass_ptr;
		public static WGPUComputePassEncoder wgpuCommandEncoderBeginComputePass()
			=> wgpuCommandEncoderBeginComputePass_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPURenderPassEncoder wgpuCommandEncoderBeginRenderPassDelegate();
		private static wgpuCommandEncoderBeginRenderPassDelegate wgpuCommandEncoderBeginRenderPass_ptr;
		public static WGPURenderPassEncoder wgpuCommandEncoderBeginRenderPass()
			=> wgpuCommandEncoderBeginRenderPass_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandEncoderCopyBufferToBufferDelegate();
		private static wgpuCommandEncoderCopyBufferToBufferDelegate wgpuCommandEncoderCopyBufferToBuffer_ptr;
		public static void wgpuCommandEncoderCopyBufferToBuffer()
			=> wgpuCommandEncoderCopyBufferToBuffer_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandEncoderCopyBufferToTextureDelegate();
		private static wgpuCommandEncoderCopyBufferToTextureDelegate wgpuCommandEncoderCopyBufferToTexture_ptr;
		public static void wgpuCommandEncoderCopyBufferToTexture()
			=> wgpuCommandEncoderCopyBufferToTexture_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandEncoderCopyTextureToBufferDelegate();
		private static wgpuCommandEncoderCopyTextureToBufferDelegate wgpuCommandEncoderCopyTextureToBuffer_ptr;
		public static void wgpuCommandEncoderCopyTextureToBuffer()
			=> wgpuCommandEncoderCopyTextureToBuffer_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandEncoderCopyTextureToTextureDelegate();
		private static wgpuCommandEncoderCopyTextureToTextureDelegate wgpuCommandEncoderCopyTextureToTexture_ptr;
		public static void wgpuCommandEncoderCopyTextureToTexture()
			=> wgpuCommandEncoderCopyTextureToTexture_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUCommandBuffer wgpuCommandEncoderFinishDelegate();
		private static wgpuCommandEncoderFinishDelegate wgpuCommandEncoderFinish_ptr;
		public static WGPUCommandBuffer wgpuCommandEncoderFinish()
			=> wgpuCommandEncoderFinish_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandEncoderInsertDebugMarkerDelegate();
		private static wgpuCommandEncoderInsertDebugMarkerDelegate wgpuCommandEncoderInsertDebugMarker_ptr;
		public static void wgpuCommandEncoderInsertDebugMarker()
			=> wgpuCommandEncoderInsertDebugMarker_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandEncoderPopDebugGroupDelegate();
		private static wgpuCommandEncoderPopDebugGroupDelegate wgpuCommandEncoderPopDebugGroup_ptr;
		public static void wgpuCommandEncoderPopDebugGroup()
			=> wgpuCommandEncoderPopDebugGroup_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandEncoderPushDebugGroupDelegate();
		private static wgpuCommandEncoderPushDebugGroupDelegate wgpuCommandEncoderPushDebugGroup_ptr;
		public static void wgpuCommandEncoderPushDebugGroup()
			=> wgpuCommandEncoderPushDebugGroup_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandEncoderResolveQuerySetDelegate();
		private static wgpuCommandEncoderResolveQuerySetDelegate wgpuCommandEncoderResolveQuerySet_ptr;
		public static void wgpuCommandEncoderResolveQuerySet()
			=> wgpuCommandEncoderResolveQuerySet_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePassEncoderDispatchDelegate();
		private static wgpuComputePassEncoderDispatchDelegate wgpuComputePassEncoderDispatch_ptr;
		public static void wgpuComputePassEncoderDispatch()
			=> wgpuComputePassEncoderDispatch_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePassEncoderDispatchIndirectDelegate();
		private static wgpuComputePassEncoderDispatchIndirectDelegate wgpuComputePassEncoderDispatchIndirect_ptr;
		public static void wgpuComputePassEncoderDispatchIndirect()
			=> wgpuComputePassEncoderDispatchIndirect_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePassEncoderEndPassDelegate();
		private static wgpuComputePassEncoderEndPassDelegate wgpuComputePassEncoderEndPass_ptr;
		public static void wgpuComputePassEncoderEndPass()
			=> wgpuComputePassEncoderEndPass_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePassEncoderInsertDebugMarkerDelegate();
		private static wgpuComputePassEncoderInsertDebugMarkerDelegate wgpuComputePassEncoderInsertDebugMarker_ptr;
		public static void wgpuComputePassEncoderInsertDebugMarker()
			=> wgpuComputePassEncoderInsertDebugMarker_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePassEncoderPopDebugGroupDelegate();
		private static wgpuComputePassEncoderPopDebugGroupDelegate wgpuComputePassEncoderPopDebugGroup_ptr;
		public static void wgpuComputePassEncoderPopDebugGroup()
			=> wgpuComputePassEncoderPopDebugGroup_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePassEncoderPushDebugGroupDelegate();
		private static wgpuComputePassEncoderPushDebugGroupDelegate wgpuComputePassEncoderPushDebugGroup_ptr;
		public static void wgpuComputePassEncoderPushDebugGroup()
			=> wgpuComputePassEncoderPushDebugGroup_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePassEncoderSetBindGroupDelegate();
		private static wgpuComputePassEncoderSetBindGroupDelegate wgpuComputePassEncoderSetBindGroup_ptr;
		public static void wgpuComputePassEncoderSetBindGroup()
			=> wgpuComputePassEncoderSetBindGroup_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePassEncoderSetPipelineDelegate();
		private static wgpuComputePassEncoderSetPipelineDelegate wgpuComputePassEncoderSetPipeline_ptr;
		public static void wgpuComputePassEncoderSetPipeline()
			=> wgpuComputePassEncoderSetPipeline_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUBindGroupLayout wgpuComputePipelineGetBindGroupLayoutDelegate();
		private static wgpuComputePipelineGetBindGroupLayoutDelegate wgpuComputePipelineGetBindGroupLayout_ptr;
		public static WGPUBindGroupLayout wgpuComputePipelineGetBindGroupLayout()
			=> wgpuComputePipelineGetBindGroupLayout_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUBindGroup wgpuDeviceCreateBindGroupDelegate();
		private static wgpuDeviceCreateBindGroupDelegate wgpuDeviceCreateBindGroup_ptr;
		public static WGPUBindGroup wgpuDeviceCreateBindGroup()
			=> wgpuDeviceCreateBindGroup_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUBindGroupLayout wgpuDeviceCreateBindGroupLayoutDelegate();
		private static wgpuDeviceCreateBindGroupLayoutDelegate wgpuDeviceCreateBindGroupLayout_ptr;
		public static WGPUBindGroupLayout wgpuDeviceCreateBindGroupLayout()
			=> wgpuDeviceCreateBindGroupLayout_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUBuffer wgpuDeviceCreateBufferDelegate();
		private static wgpuDeviceCreateBufferDelegate wgpuDeviceCreateBuffer_ptr;
		public static WGPUBuffer wgpuDeviceCreateBuffer()
			=> wgpuDeviceCreateBuffer_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUCommandEncoder wgpuDeviceCreateCommandEncoderDelegate();
		private static wgpuDeviceCreateCommandEncoderDelegate wgpuDeviceCreateCommandEncoder_ptr;
		public static WGPUCommandEncoder wgpuDeviceCreateCommandEncoder()
			=> wgpuDeviceCreateCommandEncoder_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUComputePipeline wgpuDeviceCreateComputePipelineDelegate();
		private static wgpuDeviceCreateComputePipelineDelegate wgpuDeviceCreateComputePipeline_ptr;
		public static WGPUComputePipeline wgpuDeviceCreateComputePipeline()
			=> wgpuDeviceCreateComputePipeline_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUPipelineLayout wgpuDeviceCreatePipelineLayoutDelegate();
		private static wgpuDeviceCreatePipelineLayoutDelegate wgpuDeviceCreatePipelineLayout_ptr;
		public static WGPUPipelineLayout wgpuDeviceCreatePipelineLayout()
			=> wgpuDeviceCreatePipelineLayout_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUQuerySet wgpuDeviceCreateQuerySetDelegate();
		private static wgpuDeviceCreateQuerySetDelegate wgpuDeviceCreateQuerySet_ptr;
		public static WGPUQuerySet wgpuDeviceCreateQuerySet()
			=> wgpuDeviceCreateQuerySet_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPURenderBundleEncoder wgpuDeviceCreateRenderBundleEncoderDelegate();
		private static wgpuDeviceCreateRenderBundleEncoderDelegate wgpuDeviceCreateRenderBundleEncoder_ptr;
		public static WGPURenderBundleEncoder wgpuDeviceCreateRenderBundleEncoder()
			=> wgpuDeviceCreateRenderBundleEncoder_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPURenderPipeline wgpuDeviceCreateRenderPipelineDelegate();
		private static wgpuDeviceCreateRenderPipelineDelegate wgpuDeviceCreateRenderPipeline_ptr;
		public static WGPURenderPipeline wgpuDeviceCreateRenderPipeline()
			=> wgpuDeviceCreateRenderPipeline_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUSampler wgpuDeviceCreateSamplerDelegate();
		private static wgpuDeviceCreateSamplerDelegate wgpuDeviceCreateSampler_ptr;
		public static WGPUSampler wgpuDeviceCreateSampler()
			=> wgpuDeviceCreateSampler_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUShaderModule wgpuDeviceCreateShaderModuleDelegate();
		private static wgpuDeviceCreateShaderModuleDelegate wgpuDeviceCreateShaderModule_ptr;
		public static WGPUShaderModule wgpuDeviceCreateShaderModule()
			=> wgpuDeviceCreateShaderModule_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUSwapChain wgpuDeviceCreateSwapChainDelegate();
		private static wgpuDeviceCreateSwapChainDelegate wgpuDeviceCreateSwapChain_ptr;
		public static WGPUSwapChain wgpuDeviceCreateSwapChain()
			=> wgpuDeviceCreateSwapChain_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUTexture wgpuDeviceCreateTextureDelegate();
		private static wgpuDeviceCreateTextureDelegate wgpuDeviceCreateTexture_ptr;
		public static WGPUTexture wgpuDeviceCreateTexture()
			=> wgpuDeviceCreateTexture_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUQueue wgpuDeviceGetDefaultQueueDelegate();
		private static wgpuDeviceGetDefaultQueueDelegate wgpuDeviceGetDefaultQueue_ptr;
		public static WGPUQueue wgpuDeviceGetDefaultQueue()
			=> wgpuDeviceGetDefaultQueue_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool wgpuDevicePopErrorScopeDelegate();
		private static wgpuDevicePopErrorScopeDelegate wgpuDevicePopErrorScope_ptr;
		public static bool wgpuDevicePopErrorScope()
			=> wgpuDevicePopErrorScope_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuDevicePushErrorScopeDelegate();
		private static wgpuDevicePushErrorScopeDelegate wgpuDevicePushErrorScope_ptr;
		public static void wgpuDevicePushErrorScope()
			=> wgpuDevicePushErrorScope_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuDeviceSetDeviceLostCallbackDelegate();
		private static wgpuDeviceSetDeviceLostCallbackDelegate wgpuDeviceSetDeviceLostCallback_ptr;
		public static void wgpuDeviceSetDeviceLostCallback()
			=> wgpuDeviceSetDeviceLostCallback_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuDeviceSetUncapturedErrorCallbackDelegate();
		private static wgpuDeviceSetUncapturedErrorCallbackDelegate wgpuDeviceSetUncapturedErrorCallback_ptr;
		public static void wgpuDeviceSetUncapturedErrorCallback()
			=> wgpuDeviceSetUncapturedErrorCallback_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate ulong wgpuFenceGetCompletedValueDelegate();
		private static wgpuFenceGetCompletedValueDelegate wgpuFenceGetCompletedValue_ptr;
		public static ulong wgpuFenceGetCompletedValue()
			=> wgpuFenceGetCompletedValue_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuFenceOnCompletionDelegate();
		private static wgpuFenceOnCompletionDelegate wgpuFenceOnCompletion_ptr;
		public static void wgpuFenceOnCompletion()
			=> wgpuFenceOnCompletion_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUSurface wgpuInstanceCreateSurfaceDelegate();
		private static wgpuInstanceCreateSurfaceDelegate wgpuInstanceCreateSurface_ptr;
		public static WGPUSurface wgpuInstanceCreateSurface()
			=> wgpuInstanceCreateSurface_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuInstanceProcessEventsDelegate();
		private static wgpuInstanceProcessEventsDelegate wgpuInstanceProcessEvents_ptr;
		public static void wgpuInstanceProcessEvents()
			=> wgpuInstanceProcessEvents_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuInstanceRequestAdapterDelegate();
		private static wgpuInstanceRequestAdapterDelegate wgpuInstanceRequestAdapter_ptr;
		public static void wgpuInstanceRequestAdapter()
			=> wgpuInstanceRequestAdapter_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuQuerySetDestroyDelegate();
		private static wgpuQuerySetDestroyDelegate wgpuQuerySetDestroy_ptr;
		public static void wgpuQuerySetDestroy()
			=> wgpuQuerySetDestroy_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUFence wgpuQueueCreateFenceDelegate();
		private static wgpuQueueCreateFenceDelegate wgpuQueueCreateFence_ptr;
		public static WGPUFence wgpuQueueCreateFence()
			=> wgpuQueueCreateFence_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuQueueSignalDelegate();
		private static wgpuQueueSignalDelegate wgpuQueueSignal_ptr;
		public static void wgpuQueueSignal()
			=> wgpuQueueSignal_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuQueueSubmitDelegate();
		private static wgpuQueueSubmitDelegate wgpuQueueSubmit_ptr;
		public static void wgpuQueueSubmit()
			=> wgpuQueueSubmit_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuQueueWriteBufferDelegate();
		private static wgpuQueueWriteBufferDelegate wgpuQueueWriteBuffer_ptr;
		public static void wgpuQueueWriteBuffer()
			=> wgpuQueueWriteBuffer_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuQueueWriteTextureDelegate();
		private static wgpuQueueWriteTextureDelegate wgpuQueueWriteTexture_ptr;
		public static void wgpuQueueWriteTexture()
			=> wgpuQueueWriteTexture_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderDrawDelegate();
		private static wgpuRenderBundleEncoderDrawDelegate wgpuRenderBundleEncoderDraw_ptr;
		public static void wgpuRenderBundleEncoderDraw()
			=> wgpuRenderBundleEncoderDraw_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderDrawIndexedDelegate();
		private static wgpuRenderBundleEncoderDrawIndexedDelegate wgpuRenderBundleEncoderDrawIndexed_ptr;
		public static void wgpuRenderBundleEncoderDrawIndexed()
			=> wgpuRenderBundleEncoderDrawIndexed_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderDrawIndexedIndirectDelegate();
		private static wgpuRenderBundleEncoderDrawIndexedIndirectDelegate wgpuRenderBundleEncoderDrawIndexedIndirect_ptr;
		public static void wgpuRenderBundleEncoderDrawIndexedIndirect()
			=> wgpuRenderBundleEncoderDrawIndexedIndirect_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderDrawIndirectDelegate();
		private static wgpuRenderBundleEncoderDrawIndirectDelegate wgpuRenderBundleEncoderDrawIndirect_ptr;
		public static void wgpuRenderBundleEncoderDrawIndirect()
			=> wgpuRenderBundleEncoderDrawIndirect_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPURenderBundle wgpuRenderBundleEncoderFinishDelegate();
		private static wgpuRenderBundleEncoderFinishDelegate wgpuRenderBundleEncoderFinish_ptr;
		public static WGPURenderBundle wgpuRenderBundleEncoderFinish()
			=> wgpuRenderBundleEncoderFinish_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderInsertDebugMarkerDelegate();
		private static wgpuRenderBundleEncoderInsertDebugMarkerDelegate wgpuRenderBundleEncoderInsertDebugMarker_ptr;
		public static void wgpuRenderBundleEncoderInsertDebugMarker()
			=> wgpuRenderBundleEncoderInsertDebugMarker_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderPopDebugGroupDelegate();
		private static wgpuRenderBundleEncoderPopDebugGroupDelegate wgpuRenderBundleEncoderPopDebugGroup_ptr;
		public static void wgpuRenderBundleEncoderPopDebugGroup()
			=> wgpuRenderBundleEncoderPopDebugGroup_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderPushDebugGroupDelegate();
		private static wgpuRenderBundleEncoderPushDebugGroupDelegate wgpuRenderBundleEncoderPushDebugGroup_ptr;
		public static void wgpuRenderBundleEncoderPushDebugGroup()
			=> wgpuRenderBundleEncoderPushDebugGroup_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderSetBindGroupDelegate();
		private static wgpuRenderBundleEncoderSetBindGroupDelegate wgpuRenderBundleEncoderSetBindGroup_ptr;
		public static void wgpuRenderBundleEncoderSetBindGroup()
			=> wgpuRenderBundleEncoderSetBindGroup_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderSetIndexBufferDelegate();
		private static wgpuRenderBundleEncoderSetIndexBufferDelegate wgpuRenderBundleEncoderSetIndexBuffer_ptr;
		public static void wgpuRenderBundleEncoderSetIndexBuffer()
			=> wgpuRenderBundleEncoderSetIndexBuffer_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderSetPipelineDelegate();
		private static wgpuRenderBundleEncoderSetPipelineDelegate wgpuRenderBundleEncoderSetPipeline_ptr;
		public static void wgpuRenderBundleEncoderSetPipeline()
			=> wgpuRenderBundleEncoderSetPipeline_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderSetVertexBufferDelegate();
		private static wgpuRenderBundleEncoderSetVertexBufferDelegate wgpuRenderBundleEncoderSetVertexBuffer_ptr;
		public static void wgpuRenderBundleEncoderSetVertexBuffer()
			=> wgpuRenderBundleEncoderSetVertexBuffer_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderBeginOcclusionQueryDelegate();
		private static wgpuRenderPassEncoderBeginOcclusionQueryDelegate wgpuRenderPassEncoderBeginOcclusionQuery_ptr;
		public static void wgpuRenderPassEncoderBeginOcclusionQuery()
			=> wgpuRenderPassEncoderBeginOcclusionQuery_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderDrawDelegate();
		private static wgpuRenderPassEncoderDrawDelegate wgpuRenderPassEncoderDraw_ptr;
		public static void wgpuRenderPassEncoderDraw()
			=> wgpuRenderPassEncoderDraw_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderDrawIndexedDelegate();
		private static wgpuRenderPassEncoderDrawIndexedDelegate wgpuRenderPassEncoderDrawIndexed_ptr;
		public static void wgpuRenderPassEncoderDrawIndexed()
			=> wgpuRenderPassEncoderDrawIndexed_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderDrawIndexedIndirectDelegate();
		private static wgpuRenderPassEncoderDrawIndexedIndirectDelegate wgpuRenderPassEncoderDrawIndexedIndirect_ptr;
		public static void wgpuRenderPassEncoderDrawIndexedIndirect()
			=> wgpuRenderPassEncoderDrawIndexedIndirect_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderDrawIndirectDelegate();
		private static wgpuRenderPassEncoderDrawIndirectDelegate wgpuRenderPassEncoderDrawIndirect_ptr;
		public static void wgpuRenderPassEncoderDrawIndirect()
			=> wgpuRenderPassEncoderDrawIndirect_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderEndOcclusionQueryDelegate();
		private static wgpuRenderPassEncoderEndOcclusionQueryDelegate wgpuRenderPassEncoderEndOcclusionQuery_ptr;
		public static void wgpuRenderPassEncoderEndOcclusionQuery()
			=> wgpuRenderPassEncoderEndOcclusionQuery_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderEndPassDelegate();
		private static wgpuRenderPassEncoderEndPassDelegate wgpuRenderPassEncoderEndPass_ptr;
		public static void wgpuRenderPassEncoderEndPass()
			=> wgpuRenderPassEncoderEndPass_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderExecuteBundlesDelegate();
		private static wgpuRenderPassEncoderExecuteBundlesDelegate wgpuRenderPassEncoderExecuteBundles_ptr;
		public static void wgpuRenderPassEncoderExecuteBundles()
			=> wgpuRenderPassEncoderExecuteBundles_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderInsertDebugMarkerDelegate();
		private static wgpuRenderPassEncoderInsertDebugMarkerDelegate wgpuRenderPassEncoderInsertDebugMarker_ptr;
		public static void wgpuRenderPassEncoderInsertDebugMarker()
			=> wgpuRenderPassEncoderInsertDebugMarker_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderPopDebugGroupDelegate();
		private static wgpuRenderPassEncoderPopDebugGroupDelegate wgpuRenderPassEncoderPopDebugGroup_ptr;
		public static void wgpuRenderPassEncoderPopDebugGroup()
			=> wgpuRenderPassEncoderPopDebugGroup_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderPushDebugGroupDelegate();
		private static wgpuRenderPassEncoderPushDebugGroupDelegate wgpuRenderPassEncoderPushDebugGroup_ptr;
		public static void wgpuRenderPassEncoderPushDebugGroup()
			=> wgpuRenderPassEncoderPushDebugGroup_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderSetBindGroupDelegate();
		private static wgpuRenderPassEncoderSetBindGroupDelegate wgpuRenderPassEncoderSetBindGroup_ptr;
		public static void wgpuRenderPassEncoderSetBindGroup()
			=> wgpuRenderPassEncoderSetBindGroup_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderSetBlendColorDelegate();
		private static wgpuRenderPassEncoderSetBlendColorDelegate wgpuRenderPassEncoderSetBlendColor_ptr;
		public static void wgpuRenderPassEncoderSetBlendColor()
			=> wgpuRenderPassEncoderSetBlendColor_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderSetIndexBufferDelegate();
		private static wgpuRenderPassEncoderSetIndexBufferDelegate wgpuRenderPassEncoderSetIndexBuffer_ptr;
		public static void wgpuRenderPassEncoderSetIndexBuffer()
			=> wgpuRenderPassEncoderSetIndexBuffer_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderSetPipelineDelegate();
		private static wgpuRenderPassEncoderSetPipelineDelegate wgpuRenderPassEncoderSetPipeline_ptr;
		public static void wgpuRenderPassEncoderSetPipeline()
			=> wgpuRenderPassEncoderSetPipeline_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderSetScissorRectDelegate();
		private static wgpuRenderPassEncoderSetScissorRectDelegate wgpuRenderPassEncoderSetScissorRect_ptr;
		public static void wgpuRenderPassEncoderSetScissorRect()
			=> wgpuRenderPassEncoderSetScissorRect_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderSetStencilReferenceDelegate();
		private static wgpuRenderPassEncoderSetStencilReferenceDelegate wgpuRenderPassEncoderSetStencilReference_ptr;
		public static void wgpuRenderPassEncoderSetStencilReference()
			=> wgpuRenderPassEncoderSetStencilReference_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderSetVertexBufferDelegate();
		private static wgpuRenderPassEncoderSetVertexBufferDelegate wgpuRenderPassEncoderSetVertexBuffer_ptr;
		public static void wgpuRenderPassEncoderSetVertexBuffer()
			=> wgpuRenderPassEncoderSetVertexBuffer_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderSetViewportDelegate();
		private static wgpuRenderPassEncoderSetViewportDelegate wgpuRenderPassEncoderSetViewport_ptr;
		public static void wgpuRenderPassEncoderSetViewport()
			=> wgpuRenderPassEncoderSetViewport_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUBindGroupLayout wgpuRenderPipelineGetBindGroupLayoutDelegate();
		private static wgpuRenderPipelineGetBindGroupLayoutDelegate wgpuRenderPipelineGetBindGroupLayout_ptr;
		public static WGPUBindGroupLayout wgpuRenderPipelineGetBindGroupLayout()
			=> wgpuRenderPipelineGetBindGroupLayout_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuSurfaceGetPreferredFormatDelegate();
		private static wgpuSurfaceGetPreferredFormatDelegate wgpuSurfaceGetPreferredFormat_ptr;
		public static void wgpuSurfaceGetPreferredFormat()
			=> wgpuSurfaceGetPreferredFormat_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUTextureView wgpuSwapChainGetCurrentTextureViewDelegate();
		private static wgpuSwapChainGetCurrentTextureViewDelegate wgpuSwapChainGetCurrentTextureView_ptr;
		public static WGPUTextureView wgpuSwapChainGetCurrentTextureView()
			=> wgpuSwapChainGetCurrentTextureView_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuSwapChainPresentDelegate();
		private static wgpuSwapChainPresentDelegate wgpuSwapChainPresent_ptr;
		public static void wgpuSwapChainPresent()
			=> wgpuSwapChainPresent_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUTextureView wgpuTextureCreateViewDelegate();
		private static wgpuTextureCreateViewDelegate wgpuTextureCreateView_ptr;
		public static WGPUTextureView wgpuTextureCreateView()
			=> wgpuTextureCreateView_ptr();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuTextureDestroyDelegate();
		private static wgpuTextureDestroyDelegate wgpuTextureDestroy_ptr;
		public static void wgpuTextureDestroy()
			=> wgpuTextureDestroy_ptr();


		public static void LoadFuncionPointers(Func<string, IntPtr> getProcAddress)
		{
			s_getProcAddress = getProcAddress;

			LoadFunction("wgpuCreateInstance",  out wgpuCreateInstance_ptr);
			LoadFunction("wgpuGetProcAddress",  out wgpuGetProcAddress_ptr);
			LoadFunction("wgpuAdapterGetProperties",  out wgpuAdapterGetProperties_ptr);
			LoadFunction("wgpuAdapterRequestDevice",  out wgpuAdapterRequestDevice_ptr);
			LoadFunction("wgpuBufferDestroy",  out wgpuBufferDestroy_ptr);
			LoadFunction("wgpuBufferGetConstMappedRange",  out wgpuBufferGetConstMappedRange_ptr);
			LoadFunction("wgpuBufferGetMappedRange",  out wgpuBufferGetMappedRange_ptr);
			LoadFunction("wgpuBufferMapReadAsync",  out wgpuBufferMapReadAsync_ptr);
			LoadFunction("wgpuBufferMapWriteAsync",  out wgpuBufferMapWriteAsync_ptr);
			LoadFunction("wgpuBufferUnmap",  out wgpuBufferUnmap_ptr);
			LoadFunction("wgpuCommandEncoderBeginComputePass",  out wgpuCommandEncoderBeginComputePass_ptr);
			LoadFunction("wgpuCommandEncoderBeginRenderPass",  out wgpuCommandEncoderBeginRenderPass_ptr);
			LoadFunction("wgpuCommandEncoderCopyBufferToBuffer",  out wgpuCommandEncoderCopyBufferToBuffer_ptr);
			LoadFunction("wgpuCommandEncoderCopyBufferToTexture",  out wgpuCommandEncoderCopyBufferToTexture_ptr);
			LoadFunction("wgpuCommandEncoderCopyTextureToBuffer",  out wgpuCommandEncoderCopyTextureToBuffer_ptr);
			LoadFunction("wgpuCommandEncoderCopyTextureToTexture",  out wgpuCommandEncoderCopyTextureToTexture_ptr);
			LoadFunction("wgpuCommandEncoderFinish",  out wgpuCommandEncoderFinish_ptr);
			LoadFunction("wgpuCommandEncoderInsertDebugMarker",  out wgpuCommandEncoderInsertDebugMarker_ptr);
			LoadFunction("wgpuCommandEncoderPopDebugGroup",  out wgpuCommandEncoderPopDebugGroup_ptr);
			LoadFunction("wgpuCommandEncoderPushDebugGroup",  out wgpuCommandEncoderPushDebugGroup_ptr);
			LoadFunction("wgpuCommandEncoderResolveQuerySet",  out wgpuCommandEncoderResolveQuerySet_ptr);
			LoadFunction("wgpuComputePassEncoderDispatch",  out wgpuComputePassEncoderDispatch_ptr);
			LoadFunction("wgpuComputePassEncoderDispatchIndirect",  out wgpuComputePassEncoderDispatchIndirect_ptr);
			LoadFunction("wgpuComputePassEncoderEndPass",  out wgpuComputePassEncoderEndPass_ptr);
			LoadFunction("wgpuComputePassEncoderInsertDebugMarker",  out wgpuComputePassEncoderInsertDebugMarker_ptr);
			LoadFunction("wgpuComputePassEncoderPopDebugGroup",  out wgpuComputePassEncoderPopDebugGroup_ptr);
			LoadFunction("wgpuComputePassEncoderPushDebugGroup",  out wgpuComputePassEncoderPushDebugGroup_ptr);
			LoadFunction("wgpuComputePassEncoderSetBindGroup",  out wgpuComputePassEncoderSetBindGroup_ptr);
			LoadFunction("wgpuComputePassEncoderSetPipeline",  out wgpuComputePassEncoderSetPipeline_ptr);
			LoadFunction("wgpuComputePipelineGetBindGroupLayout",  out wgpuComputePipelineGetBindGroupLayout_ptr);
			LoadFunction("wgpuDeviceCreateBindGroup",  out wgpuDeviceCreateBindGroup_ptr);
			LoadFunction("wgpuDeviceCreateBindGroupLayout",  out wgpuDeviceCreateBindGroupLayout_ptr);
			LoadFunction("wgpuDeviceCreateBuffer",  out wgpuDeviceCreateBuffer_ptr);
			LoadFunction("wgpuDeviceCreateCommandEncoder",  out wgpuDeviceCreateCommandEncoder_ptr);
			LoadFunction("wgpuDeviceCreateComputePipeline",  out wgpuDeviceCreateComputePipeline_ptr);
			LoadFunction("wgpuDeviceCreatePipelineLayout",  out wgpuDeviceCreatePipelineLayout_ptr);
			LoadFunction("wgpuDeviceCreateQuerySet",  out wgpuDeviceCreateQuerySet_ptr);
			LoadFunction("wgpuDeviceCreateRenderBundleEncoder",  out wgpuDeviceCreateRenderBundleEncoder_ptr);
			LoadFunction("wgpuDeviceCreateRenderPipeline",  out wgpuDeviceCreateRenderPipeline_ptr);
			LoadFunction("wgpuDeviceCreateSampler",  out wgpuDeviceCreateSampler_ptr);
			LoadFunction("wgpuDeviceCreateShaderModule",  out wgpuDeviceCreateShaderModule_ptr);
			LoadFunction("wgpuDeviceCreateSwapChain",  out wgpuDeviceCreateSwapChain_ptr);
			LoadFunction("wgpuDeviceCreateTexture",  out wgpuDeviceCreateTexture_ptr);
			LoadFunction("wgpuDeviceGetDefaultQueue",  out wgpuDeviceGetDefaultQueue_ptr);
			LoadFunction("wgpuDevicePopErrorScope",  out wgpuDevicePopErrorScope_ptr);
			LoadFunction("wgpuDevicePushErrorScope",  out wgpuDevicePushErrorScope_ptr);
			LoadFunction("wgpuDeviceSetDeviceLostCallback",  out wgpuDeviceSetDeviceLostCallback_ptr);
			LoadFunction("wgpuDeviceSetUncapturedErrorCallback",  out wgpuDeviceSetUncapturedErrorCallback_ptr);
			LoadFunction("wgpuFenceGetCompletedValue",  out wgpuFenceGetCompletedValue_ptr);
			LoadFunction("wgpuFenceOnCompletion",  out wgpuFenceOnCompletion_ptr);
			LoadFunction("wgpuInstanceCreateSurface",  out wgpuInstanceCreateSurface_ptr);
			LoadFunction("wgpuInstanceProcessEvents",  out wgpuInstanceProcessEvents_ptr);
			LoadFunction("wgpuInstanceRequestAdapter",  out wgpuInstanceRequestAdapter_ptr);
			LoadFunction("wgpuQuerySetDestroy",  out wgpuQuerySetDestroy_ptr);
			LoadFunction("wgpuQueueCreateFence",  out wgpuQueueCreateFence_ptr);
			LoadFunction("wgpuQueueSignal",  out wgpuQueueSignal_ptr);
			LoadFunction("wgpuQueueSubmit",  out wgpuQueueSubmit_ptr);
			LoadFunction("wgpuQueueWriteBuffer",  out wgpuQueueWriteBuffer_ptr);
			LoadFunction("wgpuQueueWriteTexture",  out wgpuQueueWriteTexture_ptr);
			LoadFunction("wgpuRenderBundleEncoderDraw",  out wgpuRenderBundleEncoderDraw_ptr);
			LoadFunction("wgpuRenderBundleEncoderDrawIndexed",  out wgpuRenderBundleEncoderDrawIndexed_ptr);
			LoadFunction("wgpuRenderBundleEncoderDrawIndexedIndirect",  out wgpuRenderBundleEncoderDrawIndexedIndirect_ptr);
			LoadFunction("wgpuRenderBundleEncoderDrawIndirect",  out wgpuRenderBundleEncoderDrawIndirect_ptr);
			LoadFunction("wgpuRenderBundleEncoderFinish",  out wgpuRenderBundleEncoderFinish_ptr);
			LoadFunction("wgpuRenderBundleEncoderInsertDebugMarker",  out wgpuRenderBundleEncoderInsertDebugMarker_ptr);
			LoadFunction("wgpuRenderBundleEncoderPopDebugGroup",  out wgpuRenderBundleEncoderPopDebugGroup_ptr);
			LoadFunction("wgpuRenderBundleEncoderPushDebugGroup",  out wgpuRenderBundleEncoderPushDebugGroup_ptr);
			LoadFunction("wgpuRenderBundleEncoderSetBindGroup",  out wgpuRenderBundleEncoderSetBindGroup_ptr);
			LoadFunction("wgpuRenderBundleEncoderSetIndexBuffer",  out wgpuRenderBundleEncoderSetIndexBuffer_ptr);
			LoadFunction("wgpuRenderBundleEncoderSetPipeline",  out wgpuRenderBundleEncoderSetPipeline_ptr);
			LoadFunction("wgpuRenderBundleEncoderSetVertexBuffer",  out wgpuRenderBundleEncoderSetVertexBuffer_ptr);
			LoadFunction("wgpuRenderPassEncoderBeginOcclusionQuery",  out wgpuRenderPassEncoderBeginOcclusionQuery_ptr);
			LoadFunction("wgpuRenderPassEncoderDraw",  out wgpuRenderPassEncoderDraw_ptr);
			LoadFunction("wgpuRenderPassEncoderDrawIndexed",  out wgpuRenderPassEncoderDrawIndexed_ptr);
			LoadFunction("wgpuRenderPassEncoderDrawIndexedIndirect",  out wgpuRenderPassEncoderDrawIndexedIndirect_ptr);
			LoadFunction("wgpuRenderPassEncoderDrawIndirect",  out wgpuRenderPassEncoderDrawIndirect_ptr);
			LoadFunction("wgpuRenderPassEncoderEndOcclusionQuery",  out wgpuRenderPassEncoderEndOcclusionQuery_ptr);
			LoadFunction("wgpuRenderPassEncoderEndPass",  out wgpuRenderPassEncoderEndPass_ptr);
			LoadFunction("wgpuRenderPassEncoderExecuteBundles",  out wgpuRenderPassEncoderExecuteBundles_ptr);
			LoadFunction("wgpuRenderPassEncoderInsertDebugMarker",  out wgpuRenderPassEncoderInsertDebugMarker_ptr);
			LoadFunction("wgpuRenderPassEncoderPopDebugGroup",  out wgpuRenderPassEncoderPopDebugGroup_ptr);
			LoadFunction("wgpuRenderPassEncoderPushDebugGroup",  out wgpuRenderPassEncoderPushDebugGroup_ptr);
			LoadFunction("wgpuRenderPassEncoderSetBindGroup",  out wgpuRenderPassEncoderSetBindGroup_ptr);
			LoadFunction("wgpuRenderPassEncoderSetBlendColor",  out wgpuRenderPassEncoderSetBlendColor_ptr);
			LoadFunction("wgpuRenderPassEncoderSetIndexBuffer",  out wgpuRenderPassEncoderSetIndexBuffer_ptr);
			LoadFunction("wgpuRenderPassEncoderSetPipeline",  out wgpuRenderPassEncoderSetPipeline_ptr);
			LoadFunction("wgpuRenderPassEncoderSetScissorRect",  out wgpuRenderPassEncoderSetScissorRect_ptr);
			LoadFunction("wgpuRenderPassEncoderSetStencilReference",  out wgpuRenderPassEncoderSetStencilReference_ptr);
			LoadFunction("wgpuRenderPassEncoderSetVertexBuffer",  out wgpuRenderPassEncoderSetVertexBuffer_ptr);
			LoadFunction("wgpuRenderPassEncoderSetViewport",  out wgpuRenderPassEncoderSetViewport_ptr);
			LoadFunction("wgpuRenderPipelineGetBindGroupLayout",  out wgpuRenderPipelineGetBindGroupLayout_ptr);
			LoadFunction("wgpuSurfaceGetPreferredFormat",  out wgpuSurfaceGetPreferredFormat_ptr);
			LoadFunction("wgpuSwapChainGetCurrentTextureView",  out wgpuSwapChainGetCurrentTextureView_ptr);
			LoadFunction("wgpuSwapChainPresent",  out wgpuSwapChainPresent_ptr);
			LoadFunction("wgpuTextureCreateView",  out wgpuTextureCreateView_ptr);
			LoadFunction("wgpuTextureDestroy",  out wgpuTextureDestroy_ptr);
		}

		private static void LoadFunction<T>(string name, out T field)
		{
			IntPtr funcPtr = s_getProcAddress(name);
			if (funcPtr != IntPtr.Zero)
			{
				field = Marshal.GetDelegateForFunctionPointer<T>(funcPtr);
			}
			else
			{
				field = default(T);
			}
		}
	}
}
