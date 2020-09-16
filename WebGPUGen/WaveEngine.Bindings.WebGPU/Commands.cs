using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WaveEngine.Bindings.WebGPU
{
	public static unsafe partial class WebGPUNative
	{
		private static IntPtr p_device;

#if (__EMSCRIPTEN__)
		private const string dllName = "dawn_proc.dll";
#else
		private const string dllName = "dawn_proc.dll";
#endif

		[DllImport(dllName)]
		public static extern IntPtr wgpuCreateInstance(WGPUInstanceDescriptor* descriptor);
		[DllImport(dllName)]
		public static extern WGPUProc wgpuGetProcAddress(IntPtr device, char* procName);
		[DllImport(dllName)]
		public static extern void wgpuBindGroupReference(IntPtr bindGroup);
		[DllImport(dllName)]
		public static extern void wgpuBindGroupRelease(IntPtr bindGroup);
		[DllImport(dllName)]
		public static extern void wgpuBindGroupLayoutReference(IntPtr bindGroupLayout);
		[DllImport(dllName)]
		public static extern void wgpuBindGroupLayoutRelease(IntPtr bindGroupLayout);
		[DllImport(dllName)]
		public static extern void wgpuBufferDestroy(IntPtr buffer);
		[DllImport(dllName)]
		public static extern void* wgpuBufferGetConstMappedRange(IntPtr buffer, ulong offset, ulong size);
		[DllImport(dllName)]
		public static extern void* wgpuBufferGetMappedRange(IntPtr buffer, ulong offset, ulong size);
		[DllImport(dllName)]
		public static extern void wgpuBufferMapAsync(IntPtr buffer, WGPUMapMode mode, ulong offset, ulong size, WGPUBufferMapCallback callback, void* userdata);
		[DllImport(dllName)]
		public static extern void wgpuBufferMapReadAsync(IntPtr buffer, WGPUBufferMapReadCallback callback, void* userdata);
		[DllImport(dllName)]
		public static extern void wgpuBufferMapWriteAsync(IntPtr buffer, WGPUBufferMapWriteCallback callback, void* userdata);
		[DllImport(dllName)]
		public static extern void wgpuBufferSetSubData(IntPtr buffer, ulong start, ulong count, void* data);
		[DllImport(dllName)]
		public static extern void wgpuBufferUnmap(IntPtr buffer);
		[DllImport(dllName)]
		public static extern void wgpuBufferReference(IntPtr buffer);
		[DllImport(dllName)]
		public static extern void wgpuBufferRelease(IntPtr buffer);
		[DllImport(dllName)]
		public static extern void wgpuCommandBufferReference(IntPtr commandBuffer);
		[DllImport(dllName)]
		public static extern void wgpuCommandBufferRelease(IntPtr commandBuffer);
		[DllImport(dllName)]
		public static extern IntPtr wgpuCommandEncoderBeginComputePass(IntPtr commandEncoder, WGPUComputePassDescriptor* descriptor);
		[DllImport(dllName)]
		public static extern IntPtr wgpuCommandEncoderBeginRenderPass(IntPtr commandEncoder, WGPURenderPassDescriptor* descriptor);
		[DllImport(dllName)]
		public static extern void wgpuCommandEncoderCopyBufferToBuffer(IntPtr commandEncoder, IntPtr source, ulong sourceOffset, IntPtr destination, ulong destinationOffset, ulong size);
		[DllImport(dllName)]
		public static extern void wgpuCommandEncoderCopyBufferToTexture(IntPtr commandEncoder, WGPUBufferCopyView* source, WGPUTextureCopyView* destination, WGPUExtent3D* copySize);
		[DllImport(dllName)]
		public static extern void wgpuCommandEncoderCopyTextureToBuffer(IntPtr commandEncoder, WGPUTextureCopyView* source, WGPUBufferCopyView* destination, WGPUExtent3D* copySize);
		[DllImport(dllName)]
		public static extern void wgpuCommandEncoderCopyTextureToTexture(IntPtr commandEncoder, WGPUTextureCopyView* source, WGPUTextureCopyView* destination, WGPUExtent3D* copySize);
		[DllImport(dllName)]
		public static extern IntPtr wgpuCommandEncoderFinish(IntPtr commandEncoder, WGPUCommandBufferDescriptor* descriptor);
		[DllImport(dllName)]
		public static extern void wgpuCommandEncoderInsertDebugMarker(IntPtr commandEncoder, char* markerLabel);
		[DllImport(dllName)]
		public static extern void wgpuCommandEncoderPopDebugGroup(IntPtr commandEncoder);
		[DllImport(dllName)]
		public static extern void wgpuCommandEncoderPushDebugGroup(IntPtr commandEncoder, char* groupLabel);
		[DllImport(dllName)]
		public static extern void wgpuCommandEncoderResolveQuerySet(IntPtr commandEncoder, IntPtr querySet, uint firstQuery, uint queryCount, IntPtr destination, ulong destinationOffset);
		[DllImport(dllName)]
		public static extern void wgpuCommandEncoderWriteTimestamp(IntPtr commandEncoder, IntPtr querySet, uint queryIndex);
		[DllImport(dllName)]
		public static extern void wgpuCommandEncoderReference(IntPtr commandEncoder);
		[DllImport(dllName)]
		public static extern void wgpuCommandEncoderRelease(IntPtr commandEncoder);
		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderDispatch(IntPtr computePassEncoder, uint x, uint y, uint z);
		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderDispatchIndirect(IntPtr computePassEncoder, IntPtr indirectBuffer, ulong indirectOffset);
		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderEndPass(IntPtr computePassEncoder);
		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderInsertDebugMarker(IntPtr computePassEncoder, char* markerLabel);
		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderPopDebugGroup(IntPtr computePassEncoder);
		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderPushDebugGroup(IntPtr computePassEncoder, char* groupLabel);
		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderSetBindGroup(IntPtr computePassEncoder, uint groupIndex, IntPtr group, uint dynamicOffsetCount, uint* dynamicOffsets);
		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderSetPipeline(IntPtr computePassEncoder, IntPtr pipeline);
		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderWriteTimestamp(IntPtr computePassEncoder, IntPtr querySet, uint queryIndex);
		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderReference(IntPtr computePassEncoder);
		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderRelease(IntPtr computePassEncoder);
		[DllImport(dllName)]
		public static extern IntPtr wgpuComputePipelineGetBindGroupLayout(IntPtr computePipeline, uint groupIndex);
		[DllImport(dllName)]
		public static extern void wgpuComputePipelineReference(IntPtr computePipeline);
		[DllImport(dllName)]
		public static extern void wgpuComputePipelineRelease(IntPtr computePipeline);
		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateBindGroup(IntPtr device, WGPUBindGroupDescriptor* descriptor);
		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateBindGroupLayout(IntPtr device, WGPUBindGroupLayoutDescriptor* descriptor);
		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateBuffer(IntPtr device, ref WGPUBufferDescriptor descriptor);
		[DllImport(dllName)]
		public static extern WGPUCreateBufferMappedResult wgpuDeviceCreateBufferMapped(IntPtr device, ref WGPUBufferDescriptor descriptor);
		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateCommandEncoder(IntPtr device, WGPUCommandEncoderDescriptor* descriptor);
		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateComputePipeline(IntPtr device, WGPUComputePipelineDescriptor* descriptor);
		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateErrorBuffer(IntPtr device);
		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreatePipelineLayout(IntPtr device, WGPUPipelineLayoutDescriptor* descriptor);
		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateQuerySet(IntPtr device, WGPUQuerySetDescriptor* descriptor);
		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateRenderBundleEncoder(IntPtr device, WGPURenderBundleEncoderDescriptor* descriptor);
		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateRenderPipeline(IntPtr device, ref WGPURenderPipelineDescriptor descriptor);
		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateSampler(IntPtr device, WGPUSamplerDescriptor* descriptor);
		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateShaderModule(IntPtr device, WGPUShaderModuleDescriptor* descriptor);
		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateSwapChain(IntPtr device, IntPtr surface, WGPUSwapChainDescriptor* descriptor);
		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateTexture(IntPtr device, WGPUTextureDescriptor* descriptor);
		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceGetDefaultQueue(IntPtr device);
		[DllImport(dllName)]
		public static extern void wgpuDeviceInjectError(IntPtr device, WGPUErrorType type, char* message);
		[DllImport(dllName)]
		public static extern void wgpuDeviceLoseForTesting(IntPtr device);
		[DllImport(dllName)]
		public static extern bool wgpuDevicePopErrorScope(IntPtr device, WGPUErrorCallback callback, void* userdata);
		[DllImport(dllName)]
		public static extern void wgpuDevicePushErrorScope(IntPtr device, WGPUErrorFilter filter);
		[DllImport(dllName)]
		public static extern void wgpuDeviceSetDeviceLostCallback(IntPtr device, WGPUDeviceLostCallback callback, void* userdata);
		[DllImport(dllName)]
		public static extern void wgpuDeviceSetUncapturedErrorCallback(IntPtr device, WGPUErrorCallback callback, void* userdata);
		[DllImport(dllName)]
		public static extern void wgpuDeviceTick(IntPtr device);
		[DllImport(dllName)]
		public static extern void wgpuDeviceReference(IntPtr device);
		[DllImport(dllName)]
		public static extern void wgpuDeviceRelease(IntPtr device);
		[DllImport(dllName)]
		public static extern ulong wgpuFenceGetCompletedValue(IntPtr fence);
		[DllImport(dllName)]
		public static extern void wgpuFenceOnCompletion(IntPtr fence, ulong value, WGPUFenceOnCompletionCallback callback, void* userdata);
		[DllImport(dllName)]
		public static extern void wgpuFenceReference(IntPtr fence);
		[DllImport(dllName)]
		public static extern void wgpuFenceRelease(IntPtr fence);
		[DllImport(dllName)]
		public static extern IntPtr wgpuInstanceCreateSurface(IntPtr instance, WGPUSurfaceDescriptor* descriptor);
		[DllImport(dllName)]
		public static extern void wgpuInstanceReference(IntPtr instance);
		[DllImport(dllName)]
		public static extern void wgpuInstanceRelease(IntPtr instance);
		[DllImport(dllName)]
		public static extern void wgpuPipelineLayoutReference(IntPtr pipelineLayout);
		[DllImport(dllName)]
		public static extern void wgpuPipelineLayoutRelease(IntPtr pipelineLayout);
		[DllImport(dllName)]
		public static extern void wgpuQuerySetDestroy(IntPtr querySet);
		[DllImport(dllName)]
		public static extern void wgpuQuerySetReference(IntPtr querySet);
		[DllImport(dllName)]
		public static extern void wgpuQuerySetRelease(IntPtr querySet);
		[DllImport(dllName)]
		public static extern IntPtr wgpuQueueCreateFence(IntPtr queue, WGPUFenceDescriptor* descriptor);
		[DllImport(dllName)]
		public static extern void wgpuQueueSignal(IntPtr queue, IntPtr fence, ulong signalValue);
		[DllImport(dllName)]
		public static extern void wgpuQueueSubmit(IntPtr queue, uint commandCount, IntPtr* commands);
		[DllImport(dllName)]
		public static extern void wgpuQueueWriteBuffer(IntPtr queue, IntPtr buffer, ulong bufferOffset, void* data, ulong size);
		[DllImport(dllName)]
		public static extern void wgpuQueueWriteTexture(IntPtr queue, WGPUTextureCopyView* destination, void* data, ulong dataSize, WGPUTextureDataLayout* dataLayout, WGPUExtent3D* writeSize);
		[DllImport(dllName)]
		public static extern void wgpuQueueReference(IntPtr queue);
		[DllImport(dllName)]
		public static extern void wgpuQueueRelease(IntPtr queue);
		[DllImport(dllName)]
		public static extern void wgpuRenderBundleReference(IntPtr renderBundle);
		[DllImport(dllName)]
		public static extern void wgpuRenderBundleRelease(IntPtr renderBundle);
		[DllImport(dllName)]
		public static extern void wgpuRenderBundleEncoderDraw(IntPtr renderBundleEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
		[DllImport(dllName)]
		public static extern void wgpuRenderBundleEncoderDrawIndexed(IntPtr renderBundleEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);
		[DllImport(dllName)]
		public static extern void wgpuRenderBundleEncoderDrawIndexedIndirect(IntPtr renderBundleEncoder, IntPtr indirectBuffer, ulong indirectOffset);
		[DllImport(dllName)]
		public static extern void wgpuRenderBundleEncoderDrawIndirect(IntPtr renderBundleEncoder, IntPtr indirectBuffer, ulong indirectOffset);
		[DllImport(dllName)]
		public static extern IntPtr wgpuRenderBundleEncoderFinish(IntPtr renderBundleEncoder, WGPURenderBundleDescriptor* descriptor);
		[DllImport(dllName)]
		public static extern void wgpuRenderBundleEncoderInsertDebugMarker(IntPtr renderBundleEncoder, char* markerLabel);
		[DllImport(dllName)]
		public static extern void wgpuRenderBundleEncoderPopDebugGroup(IntPtr renderBundleEncoder);
		[DllImport(dllName)]
		public static extern void wgpuRenderBundleEncoderPushDebugGroup(IntPtr renderBundleEncoder, char* groupLabel);
		[DllImport(dllName)]
		public static extern void wgpuRenderBundleEncoderSetBindGroup(IntPtr renderBundleEncoder, uint groupIndex, IntPtr group, uint dynamicOffsetCount, uint* dynamicOffsets);
		[DllImport(dllName)]
		public static extern void wgpuRenderBundleEncoderSetIndexBuffer(IntPtr renderBundleEncoder, IntPtr buffer, ulong offset, ulong size);
		[DllImport(dllName)]
		public static extern void wgpuRenderBundleEncoderSetPipeline(IntPtr renderBundleEncoder, IntPtr pipeline);
		[DllImport(dllName)]
		public static extern void wgpuRenderBundleEncoderSetVertexBuffer(IntPtr renderBundleEncoder, uint slot, IntPtr buffer, ulong offset, ulong size);
		[DllImport(dllName)]
		public static extern void wgpuRenderBundleEncoderReference(IntPtr renderBundleEncoder);
		[DllImport(dllName)]
		public static extern void wgpuRenderBundleEncoderRelease(IntPtr renderBundleEncoder);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderDraw(IntPtr renderPassEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderDrawIndexed(IntPtr renderPassEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderDrawIndexedIndirect(IntPtr renderPassEncoder, IntPtr indirectBuffer, ulong indirectOffset);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderDrawIndirect(IntPtr renderPassEncoder, IntPtr indirectBuffer, ulong indirectOffset);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderEndPass(IntPtr renderPassEncoder);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderExecuteBundles(IntPtr renderPassEncoder, uint bundlesCount, IntPtr* bundles);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderInsertDebugMarker(IntPtr renderPassEncoder, char* markerLabel);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderPopDebugGroup(IntPtr renderPassEncoder);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderPushDebugGroup(IntPtr renderPassEncoder, char* groupLabel);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderSetBindGroup(IntPtr renderPassEncoder, uint groupIndex, IntPtr group, uint dynamicOffsetCount, uint* dynamicOffsets);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderSetBlendColor(IntPtr renderPassEncoder, WGPUColor* color);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderSetIndexBuffer(IntPtr renderPassEncoder, IntPtr buffer, ulong offset, ulong size);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderSetPipeline(IntPtr renderPassEncoder, IntPtr pipeline);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderSetScissorRect(IntPtr renderPassEncoder, uint x, uint y, uint width, uint height);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderSetStencilReference(IntPtr renderPassEncoder, uint reference);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderSetVertexBuffer(IntPtr renderPassEncoder, uint slot, IntPtr buffer, ulong offset, ulong size);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderSetViewport(IntPtr renderPassEncoder, float x, float y, float width, float height, float minDepth, float maxDepth);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderWriteTimestamp(IntPtr renderPassEncoder, IntPtr querySet, uint queryIndex);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderReference(IntPtr renderPassEncoder);
		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderRelease(IntPtr renderPassEncoder);
		[DllImport(dllName)]
		public static extern IntPtr wgpuRenderPipelineGetBindGroupLayout(IntPtr renderPipeline, uint groupIndex);
		[DllImport(dllName)]
		public static extern void wgpuRenderPipelineReference(IntPtr renderPipeline);
		[DllImport(dllName)]
		public static extern void wgpuRenderPipelineRelease(IntPtr renderPipeline);
		[DllImport(dllName)]
		public static extern void wgpuSamplerReference(IntPtr sampler);
		[DllImport(dllName)]
		public static extern void wgpuSamplerRelease(IntPtr sampler);
		[DllImport(dllName)]
		public static extern void wgpuShaderModuleReference(IntPtr shaderModule);
		[DllImport(dllName)]
		public static extern void wgpuShaderModuleRelease(IntPtr shaderModule);
		[DllImport(dllName)]
		public static extern void wgpuSurfaceReference(IntPtr surface);
		[DllImport(dllName)]
		public static extern void wgpuSurfaceRelease(IntPtr surface);
		[DllImport(dllName)]
		public static extern void wgpuSwapChainConfigure(IntPtr swapChain, WGPUTextureFormat format, WGPUTextureUsage allowedUsage, uint width, uint height);
		[DllImport(dllName)]
		public static extern IntPtr wgpuSwapChainGetCurrentTextureView(IntPtr swapChain);
		[DllImport(dllName)]
		public static extern void wgpuSwapChainPresent(IntPtr swapChain);
		[DllImport(dllName)]
		public static extern void wgpuSwapChainReference(IntPtr swapChain);
		[DllImport(dllName)]
		public static extern void wgpuSwapChainRelease(IntPtr swapChain);
		[DllImport(dllName)]
		public static extern IntPtr wgpuTextureCreateView(IntPtr texture, WGPUTextureViewDescriptor* descriptor);
		[DllImport(dllName)]
		public static extern void wgpuTextureDestroy(IntPtr texture);
		[DllImport(dllName)]
		public static extern void wgpuTextureReference(IntPtr texture);
		[DllImport(dllName)]
		public static extern void wgpuTextureRelease(IntPtr texture);
		[DllImport(dllName)]
		public static extern void wgpuTextureViewReference(IntPtr textureView);
		[DllImport(dllName)]
		public static extern void wgpuTextureViewRelease(IntPtr textureView);
	}
}
