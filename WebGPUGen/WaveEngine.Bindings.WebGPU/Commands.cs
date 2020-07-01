using System;
using System.Runtime.InteropServices;

namespace WaveEngine.Bindings.WebGPU
{
	public static unsafe partial class WebGPUNative
	{
		private static Func<string, IntPtr> s_getProcAddress;

		private const CallingConvention CallConv = CallingConvention.Winapi;

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuCreateInstanceDelegate(WGPUInstanceDescriptor* descriptor);
		private static wgpuCreateInstanceDelegate wgpuCreateInstance_ptr;
		public static IntPtr wgpuCreateInstance(WGPUInstanceDescriptor* descriptor)
			=> wgpuCreateInstance_ptr(descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuGetProcAddressDelegate(IntPtr device, char* procName);
		private static wgpuGetProcAddressDelegate wgpuGetProcAddress_ptr;
		public static IntPtr wgpuGetProcAddress(IntPtr device, char* procName)
			=> wgpuGetProcAddress_ptr(device, procName);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuAdapterGetPropertiesDelegate(IntPtr adapter, WGPUAdapterProperties* properties);
		private static wgpuAdapterGetPropertiesDelegate wgpuAdapterGetProperties_ptr;
		public static void wgpuAdapterGetProperties(IntPtr adapter, WGPUAdapterProperties* properties)
			=> wgpuAdapterGetProperties_ptr(adapter, properties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuAdapterRequestDeviceDelegate(IntPtr adapter, WGPUDeviceDescriptor* descriptor, WGPURequestDeviceCallback callback, void* userdata);
		private static wgpuAdapterRequestDeviceDelegate wgpuAdapterRequestDevice_ptr;
		public static void wgpuAdapterRequestDevice(IntPtr adapter, WGPUDeviceDescriptor* descriptor, WGPURequestDeviceCallback callback, void* userdata)
			=> wgpuAdapterRequestDevice_ptr(adapter, descriptor, callback, userdata);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuBufferDestroyDelegate(IntPtr buffer);
		private static wgpuBufferDestroyDelegate wgpuBufferDestroy_ptr;
		public static void wgpuBufferDestroy(IntPtr buffer)
			=> wgpuBufferDestroy_ptr(buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void* wgpuBufferGetConstMappedRangeDelegate(IntPtr buffer);
		private static wgpuBufferGetConstMappedRangeDelegate wgpuBufferGetConstMappedRange_ptr;
		public static void* wgpuBufferGetConstMappedRange(IntPtr buffer)
			=> wgpuBufferGetConstMappedRange_ptr(buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void* wgpuBufferGetMappedRangeDelegate(IntPtr buffer);
		private static wgpuBufferGetMappedRangeDelegate wgpuBufferGetMappedRange_ptr;
		public static void* wgpuBufferGetMappedRange(IntPtr buffer)
			=> wgpuBufferGetMappedRange_ptr(buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuBufferMapReadAsyncDelegate(IntPtr buffer, WGPUBufferMapReadCallback callback, void* userdata);
		private static wgpuBufferMapReadAsyncDelegate wgpuBufferMapReadAsync_ptr;
		public static void wgpuBufferMapReadAsync(IntPtr buffer, WGPUBufferMapReadCallback callback, void* userdata)
			=> wgpuBufferMapReadAsync_ptr(buffer, callback, userdata);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuBufferMapWriteAsyncDelegate(IntPtr buffer, WGPUBufferMapWriteCallback callback, void* userdata);
		private static wgpuBufferMapWriteAsyncDelegate wgpuBufferMapWriteAsync_ptr;
		public static void wgpuBufferMapWriteAsync(IntPtr buffer, WGPUBufferMapWriteCallback callback, void* userdata)
			=> wgpuBufferMapWriteAsync_ptr(buffer, callback, userdata);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuBufferUnmapDelegate(IntPtr buffer);
		private static wgpuBufferUnmapDelegate wgpuBufferUnmap_ptr;
		public static void wgpuBufferUnmap(IntPtr buffer)
			=> wgpuBufferUnmap_ptr(buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuCommandEncoderBeginComputePassDelegate(IntPtr commandEncoder, WGPUComputePassDescriptor* descriptor);
		private static wgpuCommandEncoderBeginComputePassDelegate wgpuCommandEncoderBeginComputePass_ptr;
		public static IntPtr wgpuCommandEncoderBeginComputePass(IntPtr commandEncoder, WGPUComputePassDescriptor* descriptor)
			=> wgpuCommandEncoderBeginComputePass_ptr(commandEncoder, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuCommandEncoderBeginRenderPassDelegate(IntPtr commandEncoder, WGPURenderPassDescriptor* descriptor);
		private static wgpuCommandEncoderBeginRenderPassDelegate wgpuCommandEncoderBeginRenderPass_ptr;
		public static IntPtr wgpuCommandEncoderBeginRenderPass(IntPtr commandEncoder, WGPURenderPassDescriptor* descriptor)
			=> wgpuCommandEncoderBeginRenderPass_ptr(commandEncoder, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandEncoderCopyBufferToBufferDelegate(IntPtr commandEncoder, IntPtr source, ulong sourceOffset, IntPtr destination, ulong destinationOffset, ulong size);
		private static wgpuCommandEncoderCopyBufferToBufferDelegate wgpuCommandEncoderCopyBufferToBuffer_ptr;
		public static void wgpuCommandEncoderCopyBufferToBuffer(IntPtr commandEncoder, IntPtr source, ulong sourceOffset, IntPtr destination, ulong destinationOffset, ulong size)
			=> wgpuCommandEncoderCopyBufferToBuffer_ptr(commandEncoder, source, sourceOffset, destination, destinationOffset, size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandEncoderCopyBufferToTextureDelegate(IntPtr commandEncoder, WGPUBufferCopyView* source, WGPUTextureCopyView* destination, WGPUExtent3D* copySize);
		private static wgpuCommandEncoderCopyBufferToTextureDelegate wgpuCommandEncoderCopyBufferToTexture_ptr;
		public static void wgpuCommandEncoderCopyBufferToTexture(IntPtr commandEncoder, WGPUBufferCopyView* source, WGPUTextureCopyView* destination, WGPUExtent3D* copySize)
			=> wgpuCommandEncoderCopyBufferToTexture_ptr(commandEncoder, source, destination, copySize);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandEncoderCopyTextureToBufferDelegate(IntPtr commandEncoder, WGPUTextureCopyView* source, WGPUBufferCopyView* destination, WGPUExtent3D* copySize);
		private static wgpuCommandEncoderCopyTextureToBufferDelegate wgpuCommandEncoderCopyTextureToBuffer_ptr;
		public static void wgpuCommandEncoderCopyTextureToBuffer(IntPtr commandEncoder, WGPUTextureCopyView* source, WGPUBufferCopyView* destination, WGPUExtent3D* copySize)
			=> wgpuCommandEncoderCopyTextureToBuffer_ptr(commandEncoder, source, destination, copySize);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandEncoderCopyTextureToTextureDelegate(IntPtr commandEncoder, WGPUTextureCopyView* source, WGPUTextureCopyView* destination, WGPUExtent3D* copySize);
		private static wgpuCommandEncoderCopyTextureToTextureDelegate wgpuCommandEncoderCopyTextureToTexture_ptr;
		public static void wgpuCommandEncoderCopyTextureToTexture(IntPtr commandEncoder, WGPUTextureCopyView* source, WGPUTextureCopyView* destination, WGPUExtent3D* copySize)
			=> wgpuCommandEncoderCopyTextureToTexture_ptr(commandEncoder, source, destination, copySize);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuCommandEncoderFinishDelegate(IntPtr commandEncoder, WGPUCommandBufferDescriptor* descriptor);
		private static wgpuCommandEncoderFinishDelegate wgpuCommandEncoderFinish_ptr;
		public static IntPtr wgpuCommandEncoderFinish(IntPtr commandEncoder, WGPUCommandBufferDescriptor* descriptor)
			=> wgpuCommandEncoderFinish_ptr(commandEncoder, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandEncoderInsertDebugMarkerDelegate(IntPtr commandEncoder, char* groupLabel);
		private static wgpuCommandEncoderInsertDebugMarkerDelegate wgpuCommandEncoderInsertDebugMarker_ptr;
		public static void wgpuCommandEncoderInsertDebugMarker(IntPtr commandEncoder, char* groupLabel)
			=> wgpuCommandEncoderInsertDebugMarker_ptr(commandEncoder, groupLabel);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandEncoderPopDebugGroupDelegate(IntPtr commandEncoder);
		private static wgpuCommandEncoderPopDebugGroupDelegate wgpuCommandEncoderPopDebugGroup_ptr;
		public static void wgpuCommandEncoderPopDebugGroup(IntPtr commandEncoder)
			=> wgpuCommandEncoderPopDebugGroup_ptr(commandEncoder);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandEncoderPushDebugGroupDelegate(IntPtr commandEncoder, char* groupLabel);
		private static wgpuCommandEncoderPushDebugGroupDelegate wgpuCommandEncoderPushDebugGroup_ptr;
		public static void wgpuCommandEncoderPushDebugGroup(IntPtr commandEncoder, char* groupLabel)
			=> wgpuCommandEncoderPushDebugGroup_ptr(commandEncoder, groupLabel);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandEncoderResolveQuerySetDelegate(IntPtr commandEncoder, IntPtr querySet, uint firstQuery, uint queryCount, IntPtr destination, ulong destinationOffset);
		private static wgpuCommandEncoderResolveQuerySetDelegate wgpuCommandEncoderResolveQuerySet_ptr;
		public static void wgpuCommandEncoderResolveQuerySet(IntPtr commandEncoder, IntPtr querySet, uint firstQuery, uint queryCount, IntPtr destination, ulong destinationOffset)
			=> wgpuCommandEncoderResolveQuerySet_ptr(commandEncoder, querySet, firstQuery, queryCount, destination, destinationOffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePassEncoderDispatchDelegate(IntPtr computePassEncoder, uint x, uint y, uint z);
		private static wgpuComputePassEncoderDispatchDelegate wgpuComputePassEncoderDispatch_ptr;
		public static void wgpuComputePassEncoderDispatch(IntPtr computePassEncoder, uint x, uint y, uint z)
			=> wgpuComputePassEncoderDispatch_ptr(computePassEncoder, x, y, z);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePassEncoderDispatchIndirectDelegate(IntPtr computePassEncoder, IntPtr indirectBuffer, ulong indirectOffset);
		private static wgpuComputePassEncoderDispatchIndirectDelegate wgpuComputePassEncoderDispatchIndirect_ptr;
		public static void wgpuComputePassEncoderDispatchIndirect(IntPtr computePassEncoder, IntPtr indirectBuffer, ulong indirectOffset)
			=> wgpuComputePassEncoderDispatchIndirect_ptr(computePassEncoder, indirectBuffer, indirectOffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePassEncoderEndPassDelegate(IntPtr computePassEncoder);
		private static wgpuComputePassEncoderEndPassDelegate wgpuComputePassEncoderEndPass_ptr;
		public static void wgpuComputePassEncoderEndPass(IntPtr computePassEncoder)
			=> wgpuComputePassEncoderEndPass_ptr(computePassEncoder);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePassEncoderInsertDebugMarkerDelegate(IntPtr computePassEncoder, char* groupLabel);
		private static wgpuComputePassEncoderInsertDebugMarkerDelegate wgpuComputePassEncoderInsertDebugMarker_ptr;
		public static void wgpuComputePassEncoderInsertDebugMarker(IntPtr computePassEncoder, char* groupLabel)
			=> wgpuComputePassEncoderInsertDebugMarker_ptr(computePassEncoder, groupLabel);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePassEncoderPopDebugGroupDelegate(IntPtr computePassEncoder);
		private static wgpuComputePassEncoderPopDebugGroupDelegate wgpuComputePassEncoderPopDebugGroup_ptr;
		public static void wgpuComputePassEncoderPopDebugGroup(IntPtr computePassEncoder)
			=> wgpuComputePassEncoderPopDebugGroup_ptr(computePassEncoder);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePassEncoderPushDebugGroupDelegate(IntPtr computePassEncoder, char* groupLabel);
		private static wgpuComputePassEncoderPushDebugGroupDelegate wgpuComputePassEncoderPushDebugGroup_ptr;
		public static void wgpuComputePassEncoderPushDebugGroup(IntPtr computePassEncoder, char* groupLabel)
			=> wgpuComputePassEncoderPushDebugGroup_ptr(computePassEncoder, groupLabel);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePassEncoderSetBindGroupDelegate(IntPtr computePassEncoder, uint groupIndex, IntPtr group, uint dynamicOffsetCount, uint* dynamicOffsets);
		private static wgpuComputePassEncoderSetBindGroupDelegate wgpuComputePassEncoderSetBindGroup_ptr;
		public static void wgpuComputePassEncoderSetBindGroup(IntPtr computePassEncoder, uint groupIndex, IntPtr group, uint dynamicOffsetCount, uint* dynamicOffsets)
			=> wgpuComputePassEncoderSetBindGroup_ptr(computePassEncoder, groupIndex, group, dynamicOffsetCount, dynamicOffsets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePassEncoderSetPipelineDelegate(IntPtr computePassEncoder, IntPtr pipeline);
		private static wgpuComputePassEncoderSetPipelineDelegate wgpuComputePassEncoderSetPipeline_ptr;
		public static void wgpuComputePassEncoderSetPipeline(IntPtr computePassEncoder, IntPtr pipeline)
			=> wgpuComputePassEncoderSetPipeline_ptr(computePassEncoder, pipeline);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuComputePipelineGetBindGroupLayoutDelegate(IntPtr computePipeline, uint groupIndex);
		private static wgpuComputePipelineGetBindGroupLayoutDelegate wgpuComputePipelineGetBindGroupLayout_ptr;
		public static IntPtr wgpuComputePipelineGetBindGroupLayout(IntPtr computePipeline, uint groupIndex)
			=> wgpuComputePipelineGetBindGroupLayout_ptr(computePipeline, groupIndex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuDeviceCreateBindGroupDelegate(IntPtr device, WGPUBindGroupDescriptor* descriptor);
		private static wgpuDeviceCreateBindGroupDelegate wgpuDeviceCreateBindGroup_ptr;
		public static IntPtr wgpuDeviceCreateBindGroup(IntPtr device, WGPUBindGroupDescriptor* descriptor)
			=> wgpuDeviceCreateBindGroup_ptr(device, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuDeviceCreateBindGroupLayoutDelegate(IntPtr device, WGPUBindGroupLayoutDescriptor* descriptor);
		private static wgpuDeviceCreateBindGroupLayoutDelegate wgpuDeviceCreateBindGroupLayout_ptr;
		public static IntPtr wgpuDeviceCreateBindGroupLayout(IntPtr device, WGPUBindGroupLayoutDescriptor* descriptor)
			=> wgpuDeviceCreateBindGroupLayout_ptr(device, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuDeviceCreateBufferDelegate(IntPtr device, WGPUBufferDescriptor* descriptor);
		private static wgpuDeviceCreateBufferDelegate wgpuDeviceCreateBuffer_ptr;
		public static IntPtr wgpuDeviceCreateBuffer(IntPtr device, WGPUBufferDescriptor* descriptor)
			=> wgpuDeviceCreateBuffer_ptr(device, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuDeviceCreateCommandEncoderDelegate(IntPtr device, WGPUCommandEncoderDescriptor* descriptor);
		private static wgpuDeviceCreateCommandEncoderDelegate wgpuDeviceCreateCommandEncoder_ptr;
		public static IntPtr wgpuDeviceCreateCommandEncoder(IntPtr device, WGPUCommandEncoderDescriptor* descriptor)
			=> wgpuDeviceCreateCommandEncoder_ptr(device, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuDeviceCreateComputePipelineDelegate(IntPtr device, WGPUComputePipelineDescriptor* descriptor);
		private static wgpuDeviceCreateComputePipelineDelegate wgpuDeviceCreateComputePipeline_ptr;
		public static IntPtr wgpuDeviceCreateComputePipeline(IntPtr device, WGPUComputePipelineDescriptor* descriptor)
			=> wgpuDeviceCreateComputePipeline_ptr(device, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuDeviceCreatePipelineLayoutDelegate(IntPtr device, WGPUPipelineLayoutDescriptor* descriptor);
		private static wgpuDeviceCreatePipelineLayoutDelegate wgpuDeviceCreatePipelineLayout_ptr;
		public static IntPtr wgpuDeviceCreatePipelineLayout(IntPtr device, WGPUPipelineLayoutDescriptor* descriptor)
			=> wgpuDeviceCreatePipelineLayout_ptr(device, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuDeviceCreateQuerySetDelegate(IntPtr device, WGPUQuerySetDescriptor* descriptor);
		private static wgpuDeviceCreateQuerySetDelegate wgpuDeviceCreateQuerySet_ptr;
		public static IntPtr wgpuDeviceCreateQuerySet(IntPtr device, WGPUQuerySetDescriptor* descriptor)
			=> wgpuDeviceCreateQuerySet_ptr(device, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuDeviceCreateRenderBundleEncoderDelegate(IntPtr device, WGPURenderBundleEncoderDescriptor* descriptor);
		private static wgpuDeviceCreateRenderBundleEncoderDelegate wgpuDeviceCreateRenderBundleEncoder_ptr;
		public static IntPtr wgpuDeviceCreateRenderBundleEncoder(IntPtr device, WGPURenderBundleEncoderDescriptor* descriptor)
			=> wgpuDeviceCreateRenderBundleEncoder_ptr(device, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuDeviceCreateRenderPipelineDelegate(IntPtr device, WGPURenderPipelineDescriptor* descriptor);
		private static wgpuDeviceCreateRenderPipelineDelegate wgpuDeviceCreateRenderPipeline_ptr;
		public static IntPtr wgpuDeviceCreateRenderPipeline(IntPtr device, WGPURenderPipelineDescriptor* descriptor)
			=> wgpuDeviceCreateRenderPipeline_ptr(device, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuDeviceCreateSamplerDelegate(IntPtr device, WGPUSamplerDescriptor* descriptor);
		private static wgpuDeviceCreateSamplerDelegate wgpuDeviceCreateSampler_ptr;
		public static IntPtr wgpuDeviceCreateSampler(IntPtr device, WGPUSamplerDescriptor* descriptor)
			=> wgpuDeviceCreateSampler_ptr(device, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuDeviceCreateShaderModuleDelegate(IntPtr device, WGPUShaderModuleDescriptor* descriptor);
		private static wgpuDeviceCreateShaderModuleDelegate wgpuDeviceCreateShaderModule_ptr;
		public static IntPtr wgpuDeviceCreateShaderModule(IntPtr device, WGPUShaderModuleDescriptor* descriptor)
			=> wgpuDeviceCreateShaderModule_ptr(device, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuDeviceCreateSwapChainDelegate(IntPtr device, IntPtr surface, WGPUSwapChainDescriptor* descriptor);
		private static wgpuDeviceCreateSwapChainDelegate wgpuDeviceCreateSwapChain_ptr;
		public static IntPtr wgpuDeviceCreateSwapChain(IntPtr device, IntPtr surface, WGPUSwapChainDescriptor* descriptor)
			=> wgpuDeviceCreateSwapChain_ptr(device, surface, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuDeviceCreateTextureDelegate(IntPtr device, WGPUTextureDescriptor* descriptor);
		private static wgpuDeviceCreateTextureDelegate wgpuDeviceCreateTexture_ptr;
		public static IntPtr wgpuDeviceCreateTexture(IntPtr device, WGPUTextureDescriptor* descriptor)
			=> wgpuDeviceCreateTexture_ptr(device, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuDeviceGetDefaultQueueDelegate(IntPtr device);
		private static wgpuDeviceGetDefaultQueueDelegate wgpuDeviceGetDefaultQueue_ptr;
		public static IntPtr wgpuDeviceGetDefaultQueue(IntPtr device)
			=> wgpuDeviceGetDefaultQueue_ptr(device);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool wgpuDevicePopErrorScopeDelegate(IntPtr device, WGPUErrorCallback callback, void* userdata);
		private static wgpuDevicePopErrorScopeDelegate wgpuDevicePopErrorScope_ptr;
		public static bool wgpuDevicePopErrorScope(IntPtr device, WGPUErrorCallback callback, void* userdata)
			=> wgpuDevicePopErrorScope_ptr(device, callback, userdata);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuDevicePushErrorScopeDelegate(IntPtr device, WGPUErrorFilter filter);
		private static wgpuDevicePushErrorScopeDelegate wgpuDevicePushErrorScope_ptr;
		public static void wgpuDevicePushErrorScope(IntPtr device, WGPUErrorFilter filter)
			=> wgpuDevicePushErrorScope_ptr(device, filter);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuDeviceSetDeviceLostCallbackDelegate(IntPtr device, WGPUDeviceLostCallback callback, void* userdata);
		private static wgpuDeviceSetDeviceLostCallbackDelegate wgpuDeviceSetDeviceLostCallback_ptr;
		public static void wgpuDeviceSetDeviceLostCallback(IntPtr device, WGPUDeviceLostCallback callback, void* userdata)
			=> wgpuDeviceSetDeviceLostCallback_ptr(device, callback, userdata);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuDeviceSetUncapturedErrorCallbackDelegate(IntPtr device, WGPUErrorCallback callback, void* userdata);
		private static wgpuDeviceSetUncapturedErrorCallbackDelegate wgpuDeviceSetUncapturedErrorCallback_ptr;
		public static void wgpuDeviceSetUncapturedErrorCallback(IntPtr device, WGPUErrorCallback callback, void* userdata)
			=> wgpuDeviceSetUncapturedErrorCallback_ptr(device, callback, userdata);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate ulong wgpuFenceGetCompletedValueDelegate(IntPtr fence);
		private static wgpuFenceGetCompletedValueDelegate wgpuFenceGetCompletedValue_ptr;
		public static ulong wgpuFenceGetCompletedValue(IntPtr fence)
			=> wgpuFenceGetCompletedValue_ptr(fence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuFenceOnCompletionDelegate(IntPtr fence, ulong value, WGPUFenceOnCompletionCallback callback, void* userdata);
		private static wgpuFenceOnCompletionDelegate wgpuFenceOnCompletion_ptr;
		public static void wgpuFenceOnCompletion(IntPtr fence, ulong value, WGPUFenceOnCompletionCallback callback, void* userdata)
			=> wgpuFenceOnCompletion_ptr(fence, value, callback, userdata);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuInstanceCreateSurfaceDelegate(IntPtr instance, WGPUSurfaceDescriptor* descriptor);
		private static wgpuInstanceCreateSurfaceDelegate wgpuInstanceCreateSurface_ptr;
		public static IntPtr wgpuInstanceCreateSurface(IntPtr instance, WGPUSurfaceDescriptor* descriptor)
			=> wgpuInstanceCreateSurface_ptr(instance, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuInstanceProcessEventsDelegate(IntPtr instance);
		private static wgpuInstanceProcessEventsDelegate wgpuInstanceProcessEvents_ptr;
		public static void wgpuInstanceProcessEvents(IntPtr instance)
			=> wgpuInstanceProcessEvents_ptr(instance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuInstanceRequestAdapterDelegate(IntPtr instance, WGPURequestAdapterOptions* options, WGPURequestAdapterCallback callback, void* userdata);
		private static wgpuInstanceRequestAdapterDelegate wgpuInstanceRequestAdapter_ptr;
		public static void wgpuInstanceRequestAdapter(IntPtr instance, WGPURequestAdapterOptions* options, WGPURequestAdapterCallback callback, void* userdata)
			=> wgpuInstanceRequestAdapter_ptr(instance, options, callback, userdata);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuQuerySetDestroyDelegate(IntPtr querySet);
		private static wgpuQuerySetDestroyDelegate wgpuQuerySetDestroy_ptr;
		public static void wgpuQuerySetDestroy(IntPtr querySet)
			=> wgpuQuerySetDestroy_ptr(querySet);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuQueueCreateFenceDelegate(IntPtr queue, WGPUFenceDescriptor* descriptor);
		private static wgpuQueueCreateFenceDelegate wgpuQueueCreateFence_ptr;
		public static IntPtr wgpuQueueCreateFence(IntPtr queue, WGPUFenceDescriptor* descriptor)
			=> wgpuQueueCreateFence_ptr(queue, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuQueueSignalDelegate(IntPtr queue, IntPtr fence, ulong signalValue);
		private static wgpuQueueSignalDelegate wgpuQueueSignal_ptr;
		public static void wgpuQueueSignal(IntPtr queue, IntPtr fence, ulong signalValue)
			=> wgpuQueueSignal_ptr(queue, fence, signalValue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuQueueSubmitDelegate(IntPtr queue, uint commandCount, IntPtr* commands);
		private static wgpuQueueSubmitDelegate wgpuQueueSubmit_ptr;
		public static void wgpuQueueSubmit(IntPtr queue, uint commandCount, IntPtr* commands)
			=> wgpuQueueSubmit_ptr(queue, commandCount, commands);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuQueueWriteBufferDelegate(IntPtr queue, IntPtr buffer, ulong bufferOffset, void* data, VkPointerSize size);
		private static wgpuQueueWriteBufferDelegate wgpuQueueWriteBuffer_ptr;
		public static void wgpuQueueWriteBuffer(IntPtr queue, IntPtr buffer, ulong bufferOffset, void* data, VkPointerSize size)
			=> wgpuQueueWriteBuffer_ptr(queue, buffer, bufferOffset, data, size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuQueueWriteTextureDelegate(IntPtr queue, WGPUTextureCopyView destination, void* data, VkPointerSize dataSize, WGPUTextureDataLayout* dataLayout, WGPUExtent3D* writeSize);
		private static wgpuQueueWriteTextureDelegate wgpuQueueWriteTexture_ptr;
		public static void wgpuQueueWriteTexture(IntPtr queue, WGPUTextureCopyView destination, void* data, VkPointerSize dataSize, WGPUTextureDataLayout* dataLayout, WGPUExtent3D* writeSize)
			=> wgpuQueueWriteTexture_ptr(queue, destination, data, dataSize, dataLayout, writeSize);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderDrawDelegate(IntPtr renderBundleEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
		private static wgpuRenderBundleEncoderDrawDelegate wgpuRenderBundleEncoderDraw_ptr;
		public static void wgpuRenderBundleEncoderDraw(IntPtr renderBundleEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
			=> wgpuRenderBundleEncoderDraw_ptr(renderBundleEncoder, vertexCount, instanceCount, firstVertex, firstInstance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderDrawIndexedDelegate(IntPtr renderBundleEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);
		private static wgpuRenderBundleEncoderDrawIndexedDelegate wgpuRenderBundleEncoderDrawIndexed_ptr;
		public static void wgpuRenderBundleEncoderDrawIndexed(IntPtr renderBundleEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance)
			=> wgpuRenderBundleEncoderDrawIndexed_ptr(renderBundleEncoder, indexCount, instanceCount, firstIndex, baseVertex, firstInstance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderDrawIndexedIndirectDelegate(IntPtr renderBundleEncoder, IntPtr indirectBuffer, ulong indirectOffset);
		private static wgpuRenderBundleEncoderDrawIndexedIndirectDelegate wgpuRenderBundleEncoderDrawIndexedIndirect_ptr;
		public static void wgpuRenderBundleEncoderDrawIndexedIndirect(IntPtr renderBundleEncoder, IntPtr indirectBuffer, ulong indirectOffset)
			=> wgpuRenderBundleEncoderDrawIndexedIndirect_ptr(renderBundleEncoder, indirectBuffer, indirectOffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderDrawIndirectDelegate(IntPtr renderBundleEncoder, IntPtr indirectBuffer, ulong indirectOffset);
		private static wgpuRenderBundleEncoderDrawIndirectDelegate wgpuRenderBundleEncoderDrawIndirect_ptr;
		public static void wgpuRenderBundleEncoderDrawIndirect(IntPtr renderBundleEncoder, IntPtr indirectBuffer, ulong indirectOffset)
			=> wgpuRenderBundleEncoderDrawIndirect_ptr(renderBundleEncoder, indirectBuffer, indirectOffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuRenderBundleEncoderFinishDelegate(IntPtr renderBundleEncoder, WGPURenderBundleDescriptor* descriptor);
		private static wgpuRenderBundleEncoderFinishDelegate wgpuRenderBundleEncoderFinish_ptr;
		public static IntPtr wgpuRenderBundleEncoderFinish(IntPtr renderBundleEncoder, WGPURenderBundleDescriptor* descriptor)
			=> wgpuRenderBundleEncoderFinish_ptr(renderBundleEncoder, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderInsertDebugMarkerDelegate(IntPtr renderBundleEncoder, char* groupLabel);
		private static wgpuRenderBundleEncoderInsertDebugMarkerDelegate wgpuRenderBundleEncoderInsertDebugMarker_ptr;
		public static void wgpuRenderBundleEncoderInsertDebugMarker(IntPtr renderBundleEncoder, char* groupLabel)
			=> wgpuRenderBundleEncoderInsertDebugMarker_ptr(renderBundleEncoder, groupLabel);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderPopDebugGroupDelegate(IntPtr renderBundleEncoder);
		private static wgpuRenderBundleEncoderPopDebugGroupDelegate wgpuRenderBundleEncoderPopDebugGroup_ptr;
		public static void wgpuRenderBundleEncoderPopDebugGroup(IntPtr renderBundleEncoder)
			=> wgpuRenderBundleEncoderPopDebugGroup_ptr(renderBundleEncoder);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderPushDebugGroupDelegate(IntPtr renderBundleEncoder, char* groupLabel);
		private static wgpuRenderBundleEncoderPushDebugGroupDelegate wgpuRenderBundleEncoderPushDebugGroup_ptr;
		public static void wgpuRenderBundleEncoderPushDebugGroup(IntPtr renderBundleEncoder, char* groupLabel)
			=> wgpuRenderBundleEncoderPushDebugGroup_ptr(renderBundleEncoder, groupLabel);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderSetBindGroupDelegate(IntPtr renderBundleEncoder, uint groupIndex, IntPtr group, uint dynamicOffsetCount, uint* dynamicOffsets);
		private static wgpuRenderBundleEncoderSetBindGroupDelegate wgpuRenderBundleEncoderSetBindGroup_ptr;
		public static void wgpuRenderBundleEncoderSetBindGroup(IntPtr renderBundleEncoder, uint groupIndex, IntPtr group, uint dynamicOffsetCount, uint* dynamicOffsets)
			=> wgpuRenderBundleEncoderSetBindGroup_ptr(renderBundleEncoder, groupIndex, group, dynamicOffsetCount, dynamicOffsets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderSetIndexBufferDelegate(IntPtr renderBundleEncoder, IntPtr buffer, ulong offset, ulong size);
		private static wgpuRenderBundleEncoderSetIndexBufferDelegate wgpuRenderBundleEncoderSetIndexBuffer_ptr;
		public static void wgpuRenderBundleEncoderSetIndexBuffer(IntPtr renderBundleEncoder, IntPtr buffer, ulong offset, ulong size)
			=> wgpuRenderBundleEncoderSetIndexBuffer_ptr(renderBundleEncoder, buffer, offset, size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderSetPipelineDelegate(IntPtr renderBundleEncoder, IntPtr pipeline);
		private static wgpuRenderBundleEncoderSetPipelineDelegate wgpuRenderBundleEncoderSetPipeline_ptr;
		public static void wgpuRenderBundleEncoderSetPipeline(IntPtr renderBundleEncoder, IntPtr pipeline)
			=> wgpuRenderBundleEncoderSetPipeline_ptr(renderBundleEncoder, pipeline);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderSetVertexBufferDelegate(IntPtr renderBundleEncoder, uint slot, IntPtr buffer, ulong offset, ulong size);
		private static wgpuRenderBundleEncoderSetVertexBufferDelegate wgpuRenderBundleEncoderSetVertexBuffer_ptr;
		public static void wgpuRenderBundleEncoderSetVertexBuffer(IntPtr renderBundleEncoder, uint slot, IntPtr buffer, ulong offset, ulong size)
			=> wgpuRenderBundleEncoderSetVertexBuffer_ptr(renderBundleEncoder, slot, buffer, offset, size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderBeginOcclusionQueryDelegate(IntPtr renderPassEncoder, uint queryIndex);
		private static wgpuRenderPassEncoderBeginOcclusionQueryDelegate wgpuRenderPassEncoderBeginOcclusionQuery_ptr;
		public static void wgpuRenderPassEncoderBeginOcclusionQuery(IntPtr renderPassEncoder, uint queryIndex)
			=> wgpuRenderPassEncoderBeginOcclusionQuery_ptr(renderPassEncoder, queryIndex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderDrawDelegate(IntPtr renderPassEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
		private static wgpuRenderPassEncoderDrawDelegate wgpuRenderPassEncoderDraw_ptr;
		public static void wgpuRenderPassEncoderDraw(IntPtr renderPassEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
			=> wgpuRenderPassEncoderDraw_ptr(renderPassEncoder, vertexCount, instanceCount, firstVertex, firstInstance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderDrawIndexedDelegate(IntPtr renderPassEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);
		private static wgpuRenderPassEncoderDrawIndexedDelegate wgpuRenderPassEncoderDrawIndexed_ptr;
		public static void wgpuRenderPassEncoderDrawIndexed(IntPtr renderPassEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance)
			=> wgpuRenderPassEncoderDrawIndexed_ptr(renderPassEncoder, indexCount, instanceCount, firstIndex, baseVertex, firstInstance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderDrawIndexedIndirectDelegate(IntPtr renderPassEncoder, IntPtr indirectBuffer, ulong indirectOffset);
		private static wgpuRenderPassEncoderDrawIndexedIndirectDelegate wgpuRenderPassEncoderDrawIndexedIndirect_ptr;
		public static void wgpuRenderPassEncoderDrawIndexedIndirect(IntPtr renderPassEncoder, IntPtr indirectBuffer, ulong indirectOffset)
			=> wgpuRenderPassEncoderDrawIndexedIndirect_ptr(renderPassEncoder, indirectBuffer, indirectOffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderDrawIndirectDelegate(IntPtr renderPassEncoder, IntPtr indirectBuffer, ulong indirectOffset);
		private static wgpuRenderPassEncoderDrawIndirectDelegate wgpuRenderPassEncoderDrawIndirect_ptr;
		public static void wgpuRenderPassEncoderDrawIndirect(IntPtr renderPassEncoder, IntPtr indirectBuffer, ulong indirectOffset)
			=> wgpuRenderPassEncoderDrawIndirect_ptr(renderPassEncoder, indirectBuffer, indirectOffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderEndOcclusionQueryDelegate(IntPtr renderPassEncoder, uint queryIndex);
		private static wgpuRenderPassEncoderEndOcclusionQueryDelegate wgpuRenderPassEncoderEndOcclusionQuery_ptr;
		public static void wgpuRenderPassEncoderEndOcclusionQuery(IntPtr renderPassEncoder, uint queryIndex)
			=> wgpuRenderPassEncoderEndOcclusionQuery_ptr(renderPassEncoder, queryIndex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderEndPassDelegate(IntPtr renderPassEncoder);
		private static wgpuRenderPassEncoderEndPassDelegate wgpuRenderPassEncoderEndPass_ptr;
		public static void wgpuRenderPassEncoderEndPass(IntPtr renderPassEncoder)
			=> wgpuRenderPassEncoderEndPass_ptr(renderPassEncoder);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderExecuteBundlesDelegate(IntPtr renderPassEncoder, uint bundlesCount, IntPtr* bundles);
		private static wgpuRenderPassEncoderExecuteBundlesDelegate wgpuRenderPassEncoderExecuteBundles_ptr;
		public static void wgpuRenderPassEncoderExecuteBundles(IntPtr renderPassEncoder, uint bundlesCount, IntPtr* bundles)
			=> wgpuRenderPassEncoderExecuteBundles_ptr(renderPassEncoder, bundlesCount, bundles);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderInsertDebugMarkerDelegate(IntPtr renderPassEncoder, char* groupLabel);
		private static wgpuRenderPassEncoderInsertDebugMarkerDelegate wgpuRenderPassEncoderInsertDebugMarker_ptr;
		public static void wgpuRenderPassEncoderInsertDebugMarker(IntPtr renderPassEncoder, char* groupLabel)
			=> wgpuRenderPassEncoderInsertDebugMarker_ptr(renderPassEncoder, groupLabel);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderPopDebugGroupDelegate(IntPtr renderPassEncoder);
		private static wgpuRenderPassEncoderPopDebugGroupDelegate wgpuRenderPassEncoderPopDebugGroup_ptr;
		public static void wgpuRenderPassEncoderPopDebugGroup(IntPtr renderPassEncoder)
			=> wgpuRenderPassEncoderPopDebugGroup_ptr(renderPassEncoder);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderPushDebugGroupDelegate(IntPtr renderPassEncoder, char* groupLabel);
		private static wgpuRenderPassEncoderPushDebugGroupDelegate wgpuRenderPassEncoderPushDebugGroup_ptr;
		public static void wgpuRenderPassEncoderPushDebugGroup(IntPtr renderPassEncoder, char* groupLabel)
			=> wgpuRenderPassEncoderPushDebugGroup_ptr(renderPassEncoder, groupLabel);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderSetBindGroupDelegate(IntPtr renderPassEncoder, uint groupIndex, IntPtr group, uint dynamicOffsetCount, uint* dynamicOffsets);
		private static wgpuRenderPassEncoderSetBindGroupDelegate wgpuRenderPassEncoderSetBindGroup_ptr;
		public static void wgpuRenderPassEncoderSetBindGroup(IntPtr renderPassEncoder, uint groupIndex, IntPtr group, uint dynamicOffsetCount, uint* dynamicOffsets)
			=> wgpuRenderPassEncoderSetBindGroup_ptr(renderPassEncoder, groupIndex, group, dynamicOffsetCount, dynamicOffsets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderSetBlendColorDelegate(IntPtr renderPassEncoder, WGPUColor* color);
		private static wgpuRenderPassEncoderSetBlendColorDelegate wgpuRenderPassEncoderSetBlendColor_ptr;
		public static void wgpuRenderPassEncoderSetBlendColor(IntPtr renderPassEncoder, WGPUColor* color)
			=> wgpuRenderPassEncoderSetBlendColor_ptr(renderPassEncoder, color);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderSetIndexBufferDelegate(IntPtr renderPassEncoder, IntPtr buffer, ulong offset, ulong size);
		private static wgpuRenderPassEncoderSetIndexBufferDelegate wgpuRenderPassEncoderSetIndexBuffer_ptr;
		public static void wgpuRenderPassEncoderSetIndexBuffer(IntPtr renderPassEncoder, IntPtr buffer, ulong offset, ulong size)
			=> wgpuRenderPassEncoderSetIndexBuffer_ptr(renderPassEncoder, buffer, offset, size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderSetPipelineDelegate(IntPtr renderPassEncoder, IntPtr pipeline);
		private static wgpuRenderPassEncoderSetPipelineDelegate wgpuRenderPassEncoderSetPipeline_ptr;
		public static void wgpuRenderPassEncoderSetPipeline(IntPtr renderPassEncoder, IntPtr pipeline)
			=> wgpuRenderPassEncoderSetPipeline_ptr(renderPassEncoder, pipeline);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderSetScissorRectDelegate(IntPtr renderPassEncoder, uint x, uint y, uint width, uint height);
		private static wgpuRenderPassEncoderSetScissorRectDelegate wgpuRenderPassEncoderSetScissorRect_ptr;
		public static void wgpuRenderPassEncoderSetScissorRect(IntPtr renderPassEncoder, uint x, uint y, uint width, uint height)
			=> wgpuRenderPassEncoderSetScissorRect_ptr(renderPassEncoder, x, y, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderSetStencilReferenceDelegate(IntPtr renderPassEncoder, uint reference);
		private static wgpuRenderPassEncoderSetStencilReferenceDelegate wgpuRenderPassEncoderSetStencilReference_ptr;
		public static void wgpuRenderPassEncoderSetStencilReference(IntPtr renderPassEncoder, uint reference)
			=> wgpuRenderPassEncoderSetStencilReference_ptr(renderPassEncoder, reference);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderSetVertexBufferDelegate(IntPtr renderPassEncoder, uint slot, IntPtr buffer, ulong offset, ulong size);
		private static wgpuRenderPassEncoderSetVertexBufferDelegate wgpuRenderPassEncoderSetVertexBuffer_ptr;
		public static void wgpuRenderPassEncoderSetVertexBuffer(IntPtr renderPassEncoder, uint slot, IntPtr buffer, ulong offset, ulong size)
			=> wgpuRenderPassEncoderSetVertexBuffer_ptr(renderPassEncoder, slot, buffer, offset, size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderSetViewportDelegate(IntPtr renderPassEncoder, float x, float y, float width, float height, float minDepth, float maxDepth);
		private static wgpuRenderPassEncoderSetViewportDelegate wgpuRenderPassEncoderSetViewport_ptr;
		public static void wgpuRenderPassEncoderSetViewport(IntPtr renderPassEncoder, float x, float y, float width, float height, float minDepth, float maxDepth)
			=> wgpuRenderPassEncoderSetViewport_ptr(renderPassEncoder, x, y, width, height, minDepth, maxDepth);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuRenderPipelineGetBindGroupLayoutDelegate(IntPtr renderPipeline, uint groupIndex);
		private static wgpuRenderPipelineGetBindGroupLayoutDelegate wgpuRenderPipelineGetBindGroupLayout_ptr;
		public static IntPtr wgpuRenderPipelineGetBindGroupLayout(IntPtr renderPipeline, uint groupIndex)
			=> wgpuRenderPipelineGetBindGroupLayout_ptr(renderPipeline, groupIndex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuSurfaceGetPreferredFormatDelegate(IntPtr surface, IntPtr adapter, WGPUSurfaceGetPreferredFormatCallback callback, void* userdata);
		private static wgpuSurfaceGetPreferredFormatDelegate wgpuSurfaceGetPreferredFormat_ptr;
		public static void wgpuSurfaceGetPreferredFormat(IntPtr surface, IntPtr adapter, WGPUSurfaceGetPreferredFormatCallback callback, void* userdata)
			=> wgpuSurfaceGetPreferredFormat_ptr(surface, adapter, callback, userdata);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuSwapChainGetCurrentTextureViewDelegate(IntPtr swapChain);
		private static wgpuSwapChainGetCurrentTextureViewDelegate wgpuSwapChainGetCurrentTextureView_ptr;
		public static IntPtr wgpuSwapChainGetCurrentTextureView(IntPtr swapChain)
			=> wgpuSwapChainGetCurrentTextureView_ptr(swapChain);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuSwapChainPresentDelegate(IntPtr swapChain);
		private static wgpuSwapChainPresentDelegate wgpuSwapChainPresent_ptr;
		public static void wgpuSwapChainPresent(IntPtr swapChain)
			=> wgpuSwapChainPresent_ptr(swapChain);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuTextureCreateViewDelegate(IntPtr texture, WGPUTextureViewDescriptor* descriptor);
		private static wgpuTextureCreateViewDelegate wgpuTextureCreateView_ptr;
		public static IntPtr wgpuTextureCreateView(IntPtr texture, WGPUTextureViewDescriptor* descriptor)
			=> wgpuTextureCreateView_ptr(texture, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuTextureDestroyDelegate(IntPtr texture);
		private static wgpuTextureDestroyDelegate wgpuTextureDestroy_ptr;
		public static void wgpuTextureDestroy(IntPtr texture)
			=> wgpuTextureDestroy_ptr(texture);


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
