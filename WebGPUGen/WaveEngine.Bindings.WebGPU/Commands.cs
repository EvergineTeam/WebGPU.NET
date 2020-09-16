using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WaveEngine.Bindings.WebGPU
{
	public static unsafe partial class WebGPUNative
	{
		private static Func<IntPtr, string, IntPtr> s_getProcAddress;

		private static IntPtr p_device;

		private const CallingConvention CallConv = CallingConvention.Winapi;

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuCreateInstanceDelegate(WGPUInstanceDescriptor* descriptor);
		private static wgpuCreateInstanceDelegate wgpuCreateInstance_ptr;
		public static IntPtr wgpuCreateInstance(WGPUInstanceDescriptor* descriptor)
			=> wgpuCreateInstance_ptr(descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate WGPUProc wgpuGetProcAddressDelegate(IntPtr device, char* procName);
		private static wgpuGetProcAddressDelegate wgpuGetProcAddress_ptr;
		public static WGPUProc wgpuGetProcAddress(IntPtr device, char* procName)
			=> wgpuGetProcAddress_ptr(device, procName);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuBindGroupReferenceDelegate(IntPtr bindGroup);
		private static wgpuBindGroupReferenceDelegate wgpuBindGroupReference_ptr;
		public static void wgpuBindGroupReference(IntPtr bindGroup)
			=> wgpuBindGroupReference_ptr(bindGroup);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuBindGroupReleaseDelegate(IntPtr bindGroup);
		private static wgpuBindGroupReleaseDelegate wgpuBindGroupRelease_ptr;
		public static void wgpuBindGroupRelease(IntPtr bindGroup)
			=> wgpuBindGroupRelease_ptr(bindGroup);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuBindGroupLayoutReferenceDelegate(IntPtr bindGroupLayout);
		private static wgpuBindGroupLayoutReferenceDelegate wgpuBindGroupLayoutReference_ptr;
		public static void wgpuBindGroupLayoutReference(IntPtr bindGroupLayout)
			=> wgpuBindGroupLayoutReference_ptr(bindGroupLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuBindGroupLayoutReleaseDelegate(IntPtr bindGroupLayout);
		private static wgpuBindGroupLayoutReleaseDelegate wgpuBindGroupLayoutRelease_ptr;
		public static void wgpuBindGroupLayoutRelease(IntPtr bindGroupLayout)
			=> wgpuBindGroupLayoutRelease_ptr(bindGroupLayout);

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
		private delegate void wgpuBufferSetSubDataDelegate(IntPtr buffer, ulong start, ulong count, void* data);
		private static wgpuBufferSetSubDataDelegate wgpuBufferSetSubData_ptr;
		public static void wgpuBufferSetSubData(IntPtr buffer, ulong start, ulong count, void* data)
			=> wgpuBufferSetSubData_ptr(buffer, start, count, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuBufferUnmapDelegate(IntPtr buffer);
		private static wgpuBufferUnmapDelegate wgpuBufferUnmap_ptr;
		public static void wgpuBufferUnmap(IntPtr buffer)
			=> wgpuBufferUnmap_ptr(buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuBufferReferenceDelegate(IntPtr buffer);
		private static wgpuBufferReferenceDelegate wgpuBufferReference_ptr;
		public static void wgpuBufferReference(IntPtr buffer)
			=> wgpuBufferReference_ptr(buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuBufferReleaseDelegate(IntPtr buffer);
		private static wgpuBufferReleaseDelegate wgpuBufferRelease_ptr;
		public static void wgpuBufferRelease(IntPtr buffer)
			=> wgpuBufferRelease_ptr(buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandBufferReferenceDelegate(IntPtr commandBuffer);
		private static wgpuCommandBufferReferenceDelegate wgpuCommandBufferReference_ptr;
		public static void wgpuCommandBufferReference(IntPtr commandBuffer)
			=> wgpuCommandBufferReference_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandBufferReleaseDelegate(IntPtr commandBuffer);
		private static wgpuCommandBufferReleaseDelegate wgpuCommandBufferRelease_ptr;
		public static void wgpuCommandBufferRelease(IntPtr commandBuffer)
			=> wgpuCommandBufferRelease_ptr(commandBuffer);

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
		private delegate void wgpuCommandEncoderWriteTimestampDelegate(IntPtr commandEncoder, IntPtr querySet, uint queryIndex);
		private static wgpuCommandEncoderWriteTimestampDelegate wgpuCommandEncoderWriteTimestamp_ptr;
		public static void wgpuCommandEncoderWriteTimestamp(IntPtr commandEncoder, IntPtr querySet, uint queryIndex)
			=> wgpuCommandEncoderWriteTimestamp_ptr(commandEncoder, querySet, queryIndex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandEncoderReferenceDelegate(IntPtr commandEncoder);
		private static wgpuCommandEncoderReferenceDelegate wgpuCommandEncoderReference_ptr;
		public static void wgpuCommandEncoderReference(IntPtr commandEncoder)
			=> wgpuCommandEncoderReference_ptr(commandEncoder);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuCommandEncoderReleaseDelegate(IntPtr commandEncoder);
		private static wgpuCommandEncoderReleaseDelegate wgpuCommandEncoderRelease_ptr;
		public static void wgpuCommandEncoderRelease(IntPtr commandEncoder)
			=> wgpuCommandEncoderRelease_ptr(commandEncoder);

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
		private delegate void wgpuComputePassEncoderWriteTimestampDelegate(IntPtr computePassEncoder, IntPtr querySet, uint queryIndex);
		private static wgpuComputePassEncoderWriteTimestampDelegate wgpuComputePassEncoderWriteTimestamp_ptr;
		public static void wgpuComputePassEncoderWriteTimestamp(IntPtr computePassEncoder, IntPtr querySet, uint queryIndex)
			=> wgpuComputePassEncoderWriteTimestamp_ptr(computePassEncoder, querySet, queryIndex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePassEncoderReferenceDelegate(IntPtr computePassEncoder);
		private static wgpuComputePassEncoderReferenceDelegate wgpuComputePassEncoderReference_ptr;
		public static void wgpuComputePassEncoderReference(IntPtr computePassEncoder)
			=> wgpuComputePassEncoderReference_ptr(computePassEncoder);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePassEncoderReleaseDelegate(IntPtr computePassEncoder);
		private static wgpuComputePassEncoderReleaseDelegate wgpuComputePassEncoderRelease_ptr;
		public static void wgpuComputePassEncoderRelease(IntPtr computePassEncoder)
			=> wgpuComputePassEncoderRelease_ptr(computePassEncoder);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuComputePipelineGetBindGroupLayoutDelegate(IntPtr computePipeline, uint groupIndex);
		private static wgpuComputePipelineGetBindGroupLayoutDelegate wgpuComputePipelineGetBindGroupLayout_ptr;
		public static IntPtr wgpuComputePipelineGetBindGroupLayout(IntPtr computePipeline, uint groupIndex)
			=> wgpuComputePipelineGetBindGroupLayout_ptr(computePipeline, groupIndex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePipelineReferenceDelegate(IntPtr computePipeline);
		private static wgpuComputePipelineReferenceDelegate wgpuComputePipelineReference_ptr;
		public static void wgpuComputePipelineReference(IntPtr computePipeline)
			=> wgpuComputePipelineReference_ptr(computePipeline);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuComputePipelineReleaseDelegate(IntPtr computePipeline);
		private static wgpuComputePipelineReleaseDelegate wgpuComputePipelineRelease_ptr;
		public static void wgpuComputePipelineRelease(IntPtr computePipeline)
			=> wgpuComputePipelineRelease_ptr(computePipeline);

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
		private delegate WGPUCreateBufferMappedResult wgpuDeviceCreateBufferMappedDelegate(IntPtr device, WGPUBufferDescriptor* descriptor);
		private static wgpuDeviceCreateBufferMappedDelegate wgpuDeviceCreateBufferMapped_ptr;
		public static WGPUCreateBufferMappedResult wgpuDeviceCreateBufferMapped(IntPtr device, WGPUBufferDescriptor* descriptor)
			=> wgpuDeviceCreateBufferMapped_ptr(device, descriptor);

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
		private delegate IntPtr wgpuDeviceCreateErrorBufferDelegate(IntPtr device);
		private static wgpuDeviceCreateErrorBufferDelegate wgpuDeviceCreateErrorBuffer_ptr;
		public static IntPtr wgpuDeviceCreateErrorBuffer(IntPtr device)
			=> wgpuDeviceCreateErrorBuffer_ptr(device);

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
		private delegate IntPtr wgpuDeviceCreateRenderPipelineDelegate(IntPtr device, ref WGPURenderPipelineDescriptor descriptor);
		private static wgpuDeviceCreateRenderPipelineDelegate wgpuDeviceCreateRenderPipeline_ptr;
		public static IntPtr wgpuDeviceCreateRenderPipeline(IntPtr device, ref WGPURenderPipelineDescriptor descriptor)
			=> wgpuDeviceCreateRenderPipeline_ptr(device, ref descriptor);

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
		private delegate void wgpuDeviceInjectErrorDelegate(IntPtr device, WGPUErrorType type, char* message);
		private static wgpuDeviceInjectErrorDelegate wgpuDeviceInjectError_ptr;
		public static void wgpuDeviceInjectError(IntPtr device, WGPUErrorType type, char* message)
			=> wgpuDeviceInjectError_ptr(device, type, message);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuDeviceLoseForTestingDelegate(IntPtr device);
		private static wgpuDeviceLoseForTestingDelegate wgpuDeviceLoseForTesting_ptr;
		public static void wgpuDeviceLoseForTesting(IntPtr device)
			=> wgpuDeviceLoseForTesting_ptr(device);

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
		private delegate void wgpuDeviceTickDelegate(IntPtr device);
		private static wgpuDeviceTickDelegate wgpuDeviceTick_ptr;
		public static void wgpuDeviceTick(IntPtr device)
			=> wgpuDeviceTick_ptr(device);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuDeviceReferenceDelegate(IntPtr device);
		private static wgpuDeviceReferenceDelegate wgpuDeviceReference_ptr;
		public static void wgpuDeviceReference(IntPtr device)
			=> wgpuDeviceReference_ptr(device);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuDeviceReleaseDelegate(IntPtr device);
		private static wgpuDeviceReleaseDelegate wgpuDeviceRelease_ptr;
		public static void wgpuDeviceRelease(IntPtr device)
			=> wgpuDeviceRelease_ptr(device);

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
		private delegate void wgpuFenceReferenceDelegate(IntPtr fence);
		private static wgpuFenceReferenceDelegate wgpuFenceReference_ptr;
		public static void wgpuFenceReference(IntPtr fence)
			=> wgpuFenceReference_ptr(fence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuFenceReleaseDelegate(IntPtr fence);
		private static wgpuFenceReleaseDelegate wgpuFenceRelease_ptr;
		public static void wgpuFenceRelease(IntPtr fence)
			=> wgpuFenceRelease_ptr(fence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuInstanceCreateSurfaceDelegate(IntPtr instance, WGPUSurfaceDescriptor* descriptor);
		private static wgpuInstanceCreateSurfaceDelegate wgpuInstanceCreateSurface_ptr;
		public static IntPtr wgpuInstanceCreateSurface(IntPtr instance, WGPUSurfaceDescriptor* descriptor)
			=> wgpuInstanceCreateSurface_ptr(instance, descriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuInstanceReferenceDelegate(IntPtr instance);
		private static wgpuInstanceReferenceDelegate wgpuInstanceReference_ptr;
		public static void wgpuInstanceReference(IntPtr instance)
			=> wgpuInstanceReference_ptr(instance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuInstanceReleaseDelegate(IntPtr instance);
		private static wgpuInstanceReleaseDelegate wgpuInstanceRelease_ptr;
		public static void wgpuInstanceRelease(IntPtr instance)
			=> wgpuInstanceRelease_ptr(instance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuPipelineLayoutReferenceDelegate(IntPtr pipelineLayout);
		private static wgpuPipelineLayoutReferenceDelegate wgpuPipelineLayoutReference_ptr;
		public static void wgpuPipelineLayoutReference(IntPtr pipelineLayout)
			=> wgpuPipelineLayoutReference_ptr(pipelineLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuPipelineLayoutReleaseDelegate(IntPtr pipelineLayout);
		private static wgpuPipelineLayoutReleaseDelegate wgpuPipelineLayoutRelease_ptr;
		public static void wgpuPipelineLayoutRelease(IntPtr pipelineLayout)
			=> wgpuPipelineLayoutRelease_ptr(pipelineLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuQuerySetDestroyDelegate(IntPtr querySet);
		private static wgpuQuerySetDestroyDelegate wgpuQuerySetDestroy_ptr;
		public static void wgpuQuerySetDestroy(IntPtr querySet)
			=> wgpuQuerySetDestroy_ptr(querySet);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuQuerySetReferenceDelegate(IntPtr querySet);
		private static wgpuQuerySetReferenceDelegate wgpuQuerySetReference_ptr;
		public static void wgpuQuerySetReference(IntPtr querySet)
			=> wgpuQuerySetReference_ptr(querySet);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuQuerySetReleaseDelegate(IntPtr querySet);
		private static wgpuQuerySetReleaseDelegate wgpuQuerySetRelease_ptr;
		public static void wgpuQuerySetRelease(IntPtr querySet)
			=> wgpuQuerySetRelease_ptr(querySet);

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
		private delegate void wgpuQueueWriteBufferDelegate(IntPtr queue, IntPtr buffer, ulong bufferOffset, void* data, ulong size);
		private static wgpuQueueWriteBufferDelegate wgpuQueueWriteBuffer_ptr;
		public static void wgpuQueueWriteBuffer(IntPtr queue, IntPtr buffer, ulong bufferOffset, void* data, ulong size)
			=> wgpuQueueWriteBuffer_ptr(queue, buffer, bufferOffset, data, size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuQueueReferenceDelegate(IntPtr queue);
		private static wgpuQueueReferenceDelegate wgpuQueueReference_ptr;
		public static void wgpuQueueReference(IntPtr queue)
			=> wgpuQueueReference_ptr(queue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuQueueReleaseDelegate(IntPtr queue);
		private static wgpuQueueReleaseDelegate wgpuQueueRelease_ptr;
		public static void wgpuQueueRelease(IntPtr queue)
			=> wgpuQueueRelease_ptr(queue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleReferenceDelegate(IntPtr renderBundle);
		private static wgpuRenderBundleReferenceDelegate wgpuRenderBundleReference_ptr;
		public static void wgpuRenderBundleReference(IntPtr renderBundle)
			=> wgpuRenderBundleReference_ptr(renderBundle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleReleaseDelegate(IntPtr renderBundle);
		private static wgpuRenderBundleReleaseDelegate wgpuRenderBundleRelease_ptr;
		public static void wgpuRenderBundleRelease(IntPtr renderBundle)
			=> wgpuRenderBundleRelease_ptr(renderBundle);

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
		private delegate void wgpuRenderBundleEncoderReferenceDelegate(IntPtr renderBundleEncoder);
		private static wgpuRenderBundleEncoderReferenceDelegate wgpuRenderBundleEncoderReference_ptr;
		public static void wgpuRenderBundleEncoderReference(IntPtr renderBundleEncoder)
			=> wgpuRenderBundleEncoderReference_ptr(renderBundleEncoder);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderBundleEncoderReleaseDelegate(IntPtr renderBundleEncoder);
		private static wgpuRenderBundleEncoderReleaseDelegate wgpuRenderBundleEncoderRelease_ptr;
		public static void wgpuRenderBundleEncoderRelease(IntPtr renderBundleEncoder)
			=> wgpuRenderBundleEncoderRelease_ptr(renderBundleEncoder);

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
		private delegate void wgpuRenderPassEncoderWriteTimestampDelegate(IntPtr renderPassEncoder, IntPtr querySet, uint queryIndex);
		private static wgpuRenderPassEncoderWriteTimestampDelegate wgpuRenderPassEncoderWriteTimestamp_ptr;
		public static void wgpuRenderPassEncoderWriteTimestamp(IntPtr renderPassEncoder, IntPtr querySet, uint queryIndex)
			=> wgpuRenderPassEncoderWriteTimestamp_ptr(renderPassEncoder, querySet, queryIndex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderReferenceDelegate(IntPtr renderPassEncoder);
		private static wgpuRenderPassEncoderReferenceDelegate wgpuRenderPassEncoderReference_ptr;
		public static void wgpuRenderPassEncoderReference(IntPtr renderPassEncoder)
			=> wgpuRenderPassEncoderReference_ptr(renderPassEncoder);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPassEncoderReleaseDelegate(IntPtr renderPassEncoder);
		private static wgpuRenderPassEncoderReleaseDelegate wgpuRenderPassEncoderRelease_ptr;
		public static void wgpuRenderPassEncoderRelease(IntPtr renderPassEncoder)
			=> wgpuRenderPassEncoderRelease_ptr(renderPassEncoder);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr wgpuRenderPipelineGetBindGroupLayoutDelegate(IntPtr renderPipeline, uint groupIndex);
		private static wgpuRenderPipelineGetBindGroupLayoutDelegate wgpuRenderPipelineGetBindGroupLayout_ptr;
		public static IntPtr wgpuRenderPipelineGetBindGroupLayout(IntPtr renderPipeline, uint groupIndex)
			=> wgpuRenderPipelineGetBindGroupLayout_ptr(renderPipeline, groupIndex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPipelineReferenceDelegate(IntPtr renderPipeline);
		private static wgpuRenderPipelineReferenceDelegate wgpuRenderPipelineReference_ptr;
		public static void wgpuRenderPipelineReference(IntPtr renderPipeline)
			=> wgpuRenderPipelineReference_ptr(renderPipeline);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuRenderPipelineReleaseDelegate(IntPtr renderPipeline);
		private static wgpuRenderPipelineReleaseDelegate wgpuRenderPipelineRelease_ptr;
		public static void wgpuRenderPipelineRelease(IntPtr renderPipeline)
			=> wgpuRenderPipelineRelease_ptr(renderPipeline);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuSamplerReferenceDelegate(IntPtr sampler);
		private static wgpuSamplerReferenceDelegate wgpuSamplerReference_ptr;
		public static void wgpuSamplerReference(IntPtr sampler)
			=> wgpuSamplerReference_ptr(sampler);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuSamplerReleaseDelegate(IntPtr sampler);
		private static wgpuSamplerReleaseDelegate wgpuSamplerRelease_ptr;
		public static void wgpuSamplerRelease(IntPtr sampler)
			=> wgpuSamplerRelease_ptr(sampler);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuShaderModuleReferenceDelegate(IntPtr shaderModule);
		private static wgpuShaderModuleReferenceDelegate wgpuShaderModuleReference_ptr;
		public static void wgpuShaderModuleReference(IntPtr shaderModule)
			=> wgpuShaderModuleReference_ptr(shaderModule);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuShaderModuleReleaseDelegate(IntPtr shaderModule);
		private static wgpuShaderModuleReleaseDelegate wgpuShaderModuleRelease_ptr;
		public static void wgpuShaderModuleRelease(IntPtr shaderModule)
			=> wgpuShaderModuleRelease_ptr(shaderModule);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuSurfaceReferenceDelegate(IntPtr surface);
		private static wgpuSurfaceReferenceDelegate wgpuSurfaceReference_ptr;
		public static void wgpuSurfaceReference(IntPtr surface)
			=> wgpuSurfaceReference_ptr(surface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuSurfaceReleaseDelegate(IntPtr surface);
		private static wgpuSurfaceReleaseDelegate wgpuSurfaceRelease_ptr;
		public static void wgpuSurfaceRelease(IntPtr surface)
			=> wgpuSurfaceRelease_ptr(surface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuSwapChainConfigureDelegate(IntPtr swapChain, WGPUTextureFormat format, WGPUTextureUsage allowedUsage, uint width, uint height);
		private static wgpuSwapChainConfigureDelegate wgpuSwapChainConfigure_ptr;
		public static void wgpuSwapChainConfigure(IntPtr swapChain, WGPUTextureFormat format, WGPUTextureUsage allowedUsage, uint width, uint height)
			=> wgpuSwapChainConfigure_ptr(swapChain, format, allowedUsage, width, height);

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
		private delegate void wgpuSwapChainReferenceDelegate(IntPtr swapChain);
		private static wgpuSwapChainReferenceDelegate wgpuSwapChainReference_ptr;
		public static void wgpuSwapChainReference(IntPtr swapChain)
			=> wgpuSwapChainReference_ptr(swapChain);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuSwapChainReleaseDelegate(IntPtr swapChain);
		private static wgpuSwapChainReleaseDelegate wgpuSwapChainRelease_ptr;
		public static void wgpuSwapChainRelease(IntPtr swapChain)
			=> wgpuSwapChainRelease_ptr(swapChain);

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

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuTextureReferenceDelegate(IntPtr texture);
		private static wgpuTextureReferenceDelegate wgpuTextureReference_ptr;
		public static void wgpuTextureReference(IntPtr texture)
			=> wgpuTextureReference_ptr(texture);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuTextureReleaseDelegate(IntPtr texture);
		private static wgpuTextureReleaseDelegate wgpuTextureRelease_ptr;
		public static void wgpuTextureRelease(IntPtr texture)
			=> wgpuTextureRelease_ptr(texture);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuTextureViewReferenceDelegate(IntPtr textureView);
		private static wgpuTextureViewReferenceDelegate wgpuTextureViewReference_ptr;
		public static void wgpuTextureViewReference(IntPtr textureView)
			=> wgpuTextureViewReference_ptr(textureView);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void wgpuTextureViewReleaseDelegate(IntPtr textureView);
		private static wgpuTextureViewReleaseDelegate wgpuTextureViewRelease_ptr;
		public static void wgpuTextureViewRelease(IntPtr textureView)
			=> wgpuTextureViewRelease_ptr(textureView);


		public static void LoadFuncionPointers(IntPtr device, Func<IntPtr, string, IntPtr> getProcAddress)
		{
			s_getProcAddress = getProcAddress;

			p_device = device;

			LoadFunction("wgpuCreateInstance",  out wgpuCreateInstance_ptr);
			LoadFunction("wgpuGetProcAddress",  out wgpuGetProcAddress_ptr);
			LoadFunction("wgpuBindGroupReference",  out wgpuBindGroupReference_ptr);
			LoadFunction("wgpuBindGroupRelease",  out wgpuBindGroupRelease_ptr);
			LoadFunction("wgpuBindGroupLayoutReference",  out wgpuBindGroupLayoutReference_ptr);
			LoadFunction("wgpuBindGroupLayoutRelease",  out wgpuBindGroupLayoutRelease_ptr);
			LoadFunction("wgpuBufferDestroy",  out wgpuBufferDestroy_ptr);
			LoadFunction("wgpuBufferGetConstMappedRange",  out wgpuBufferGetConstMappedRange_ptr);
			LoadFunction("wgpuBufferGetMappedRange",  out wgpuBufferGetMappedRange_ptr);
			LoadFunction("wgpuBufferMapReadAsync",  out wgpuBufferMapReadAsync_ptr);
			LoadFunction("wgpuBufferMapWriteAsync",  out wgpuBufferMapWriteAsync_ptr);
			LoadFunction("wgpuBufferSetSubData",  out wgpuBufferSetSubData_ptr);
			LoadFunction("wgpuBufferUnmap",  out wgpuBufferUnmap_ptr);
			LoadFunction("wgpuBufferReference",  out wgpuBufferReference_ptr);
			LoadFunction("wgpuBufferRelease",  out wgpuBufferRelease_ptr);
			LoadFunction("wgpuCommandBufferReference",  out wgpuCommandBufferReference_ptr);
			LoadFunction("wgpuCommandBufferRelease",  out wgpuCommandBufferRelease_ptr);
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
			LoadFunction("wgpuCommandEncoderWriteTimestamp",  out wgpuCommandEncoderWriteTimestamp_ptr);
			LoadFunction("wgpuCommandEncoderReference",  out wgpuCommandEncoderReference_ptr);
			LoadFunction("wgpuCommandEncoderRelease",  out wgpuCommandEncoderRelease_ptr);
			LoadFunction("wgpuComputePassEncoderDispatch",  out wgpuComputePassEncoderDispatch_ptr);
			LoadFunction("wgpuComputePassEncoderDispatchIndirect",  out wgpuComputePassEncoderDispatchIndirect_ptr);
			LoadFunction("wgpuComputePassEncoderEndPass",  out wgpuComputePassEncoderEndPass_ptr);
			LoadFunction("wgpuComputePassEncoderInsertDebugMarker",  out wgpuComputePassEncoderInsertDebugMarker_ptr);
			LoadFunction("wgpuComputePassEncoderPopDebugGroup",  out wgpuComputePassEncoderPopDebugGroup_ptr);
			LoadFunction("wgpuComputePassEncoderPushDebugGroup",  out wgpuComputePassEncoderPushDebugGroup_ptr);
			LoadFunction("wgpuComputePassEncoderSetBindGroup",  out wgpuComputePassEncoderSetBindGroup_ptr);
			LoadFunction("wgpuComputePassEncoderSetPipeline",  out wgpuComputePassEncoderSetPipeline_ptr);
			LoadFunction("wgpuComputePassEncoderWriteTimestamp",  out wgpuComputePassEncoderWriteTimestamp_ptr);
			LoadFunction("wgpuComputePassEncoderReference",  out wgpuComputePassEncoderReference_ptr);
			LoadFunction("wgpuComputePassEncoderRelease",  out wgpuComputePassEncoderRelease_ptr);
			LoadFunction("wgpuComputePipelineGetBindGroupLayout",  out wgpuComputePipelineGetBindGroupLayout_ptr);
			LoadFunction("wgpuComputePipelineReference",  out wgpuComputePipelineReference_ptr);
			LoadFunction("wgpuComputePipelineRelease",  out wgpuComputePipelineRelease_ptr);
			LoadFunction("wgpuDeviceCreateBindGroup",  out wgpuDeviceCreateBindGroup_ptr);
			LoadFunction("wgpuDeviceCreateBindGroupLayout",  out wgpuDeviceCreateBindGroupLayout_ptr);
			LoadFunction("wgpuDeviceCreateBuffer",  out wgpuDeviceCreateBuffer_ptr);
			LoadFunction("wgpuDeviceCreateBufferMapped",  out wgpuDeviceCreateBufferMapped_ptr);
			LoadFunction("wgpuDeviceCreateCommandEncoder",  out wgpuDeviceCreateCommandEncoder_ptr);
			LoadFunction("wgpuDeviceCreateComputePipeline",  out wgpuDeviceCreateComputePipeline_ptr);
			LoadFunction("wgpuDeviceCreateErrorBuffer",  out wgpuDeviceCreateErrorBuffer_ptr);
			LoadFunction("wgpuDeviceCreatePipelineLayout",  out wgpuDeviceCreatePipelineLayout_ptr);
			LoadFunction("wgpuDeviceCreateQuerySet",  out wgpuDeviceCreateQuerySet_ptr);
			LoadFunction("wgpuDeviceCreateRenderBundleEncoder",  out wgpuDeviceCreateRenderBundleEncoder_ptr);
			LoadFunction("wgpuDeviceCreateRenderPipeline",  out wgpuDeviceCreateRenderPipeline_ptr);
			LoadFunction("wgpuDeviceCreateSampler",  out wgpuDeviceCreateSampler_ptr);
			LoadFunction("wgpuDeviceCreateShaderModule",  out wgpuDeviceCreateShaderModule_ptr);
			LoadFunction("wgpuDeviceCreateSwapChain",  out wgpuDeviceCreateSwapChain_ptr);
			LoadFunction("wgpuDeviceCreateTexture",  out wgpuDeviceCreateTexture_ptr);
			LoadFunction("wgpuDeviceGetDefaultQueue",  out wgpuDeviceGetDefaultQueue_ptr);
			LoadFunction("wgpuDeviceInjectError",  out wgpuDeviceInjectError_ptr);
			LoadFunction("wgpuDeviceLoseForTesting",  out wgpuDeviceLoseForTesting_ptr);
			LoadFunction("wgpuDevicePopErrorScope",  out wgpuDevicePopErrorScope_ptr);
			LoadFunction("wgpuDevicePushErrorScope",  out wgpuDevicePushErrorScope_ptr);
			LoadFunction("wgpuDeviceSetDeviceLostCallback",  out wgpuDeviceSetDeviceLostCallback_ptr);
			LoadFunction("wgpuDeviceSetUncapturedErrorCallback",  out wgpuDeviceSetUncapturedErrorCallback_ptr);
			LoadFunction("wgpuDeviceTick",  out wgpuDeviceTick_ptr);
			LoadFunction("wgpuDeviceReference",  out wgpuDeviceReference_ptr);
			LoadFunction("wgpuDeviceRelease",  out wgpuDeviceRelease_ptr);
			LoadFunction("wgpuFenceGetCompletedValue",  out wgpuFenceGetCompletedValue_ptr);
			LoadFunction("wgpuFenceOnCompletion",  out wgpuFenceOnCompletion_ptr);
			LoadFunction("wgpuFenceReference",  out wgpuFenceReference_ptr);
			LoadFunction("wgpuFenceRelease",  out wgpuFenceRelease_ptr);
			LoadFunction("wgpuInstanceCreateSurface",  out wgpuInstanceCreateSurface_ptr);
			LoadFunction("wgpuInstanceReference",  out wgpuInstanceReference_ptr);
			LoadFunction("wgpuInstanceRelease",  out wgpuInstanceRelease_ptr);
			LoadFunction("wgpuPipelineLayoutReference",  out wgpuPipelineLayoutReference_ptr);
			LoadFunction("wgpuPipelineLayoutRelease",  out wgpuPipelineLayoutRelease_ptr);
			LoadFunction("wgpuQuerySetDestroy",  out wgpuQuerySetDestroy_ptr);
			LoadFunction("wgpuQuerySetReference",  out wgpuQuerySetReference_ptr);
			LoadFunction("wgpuQuerySetRelease",  out wgpuQuerySetRelease_ptr);
			LoadFunction("wgpuQueueCreateFence",  out wgpuQueueCreateFence_ptr);
			LoadFunction("wgpuQueueSignal",  out wgpuQueueSignal_ptr);
			LoadFunction("wgpuQueueSubmit",  out wgpuQueueSubmit_ptr);
			LoadFunction("wgpuQueueWriteBuffer",  out wgpuQueueWriteBuffer_ptr);
			LoadFunction("wgpuQueueReference",  out wgpuQueueReference_ptr);
			LoadFunction("wgpuQueueRelease",  out wgpuQueueRelease_ptr);
			LoadFunction("wgpuRenderBundleReference",  out wgpuRenderBundleReference_ptr);
			LoadFunction("wgpuRenderBundleRelease",  out wgpuRenderBundleRelease_ptr);
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
			LoadFunction("wgpuRenderBundleEncoderReference",  out wgpuRenderBundleEncoderReference_ptr);
			LoadFunction("wgpuRenderBundleEncoderRelease",  out wgpuRenderBundleEncoderRelease_ptr);
			LoadFunction("wgpuRenderPassEncoderDraw",  out wgpuRenderPassEncoderDraw_ptr);
			LoadFunction("wgpuRenderPassEncoderDrawIndexed",  out wgpuRenderPassEncoderDrawIndexed_ptr);
			LoadFunction("wgpuRenderPassEncoderDrawIndexedIndirect",  out wgpuRenderPassEncoderDrawIndexedIndirect_ptr);
			LoadFunction("wgpuRenderPassEncoderDrawIndirect",  out wgpuRenderPassEncoderDrawIndirect_ptr);
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
			LoadFunction("wgpuRenderPassEncoderWriteTimestamp",  out wgpuRenderPassEncoderWriteTimestamp_ptr);
			LoadFunction("wgpuRenderPassEncoderReference",  out wgpuRenderPassEncoderReference_ptr);
			LoadFunction("wgpuRenderPassEncoderRelease",  out wgpuRenderPassEncoderRelease_ptr);
			LoadFunction("wgpuRenderPipelineGetBindGroupLayout",  out wgpuRenderPipelineGetBindGroupLayout_ptr);
			LoadFunction("wgpuRenderPipelineReference",  out wgpuRenderPipelineReference_ptr);
			LoadFunction("wgpuRenderPipelineRelease",  out wgpuRenderPipelineRelease_ptr);
			LoadFunction("wgpuSamplerReference",  out wgpuSamplerReference_ptr);
			LoadFunction("wgpuSamplerRelease",  out wgpuSamplerRelease_ptr);
			LoadFunction("wgpuShaderModuleReference",  out wgpuShaderModuleReference_ptr);
			LoadFunction("wgpuShaderModuleRelease",  out wgpuShaderModuleRelease_ptr);
			LoadFunction("wgpuSurfaceReference",  out wgpuSurfaceReference_ptr);
			LoadFunction("wgpuSurfaceRelease",  out wgpuSurfaceRelease_ptr);
			LoadFunction("wgpuSwapChainConfigure",  out wgpuSwapChainConfigure_ptr);
			LoadFunction("wgpuSwapChainGetCurrentTextureView",  out wgpuSwapChainGetCurrentTextureView_ptr);
			LoadFunction("wgpuSwapChainPresent",  out wgpuSwapChainPresent_ptr);
			LoadFunction("wgpuSwapChainReference",  out wgpuSwapChainReference_ptr);
			LoadFunction("wgpuSwapChainRelease",  out wgpuSwapChainRelease_ptr);
			LoadFunction("wgpuTextureCreateView",  out wgpuTextureCreateView_ptr);
			LoadFunction("wgpuTextureDestroy",  out wgpuTextureDestroy_ptr);
			LoadFunction("wgpuTextureReference",  out wgpuTextureReference_ptr);
			LoadFunction("wgpuTextureRelease",  out wgpuTextureRelease_ptr);
			LoadFunction("wgpuTextureViewReference",  out wgpuTextureViewReference_ptr);
			LoadFunction("wgpuTextureViewRelease",  out wgpuTextureViewRelease_ptr);
		}

		private static void LoadFunction<T>(string name, out T field)
		{
			IntPtr funcPtr = s_getProcAddress(p_device, name);
			if (funcPtr != IntPtr.Zero)
			{
				field = Marshal.GetDelegateForFunctionPointer<T>(funcPtr);
			}
			else
			{
				Debug.WriteLine($"WARING: Function { name} not found in WebGPU implementation.");
				field = default(T);
			}
		}
	}
}
