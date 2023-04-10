using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WaveEngine.Bindings.WebGPU
{
	public static unsafe partial class WebGPUNative
	{
		private const string dllName = "libWebGPU";

		[DllImport(dllName)]
		public static extern IntPtr wgpuCreateInstance(WGPUInstanceDescriptor* descriptor);

		[DllImport(dllName)]
		public static extern WGPUProc wgpuGetProcAddress(IntPtr device, char* procName);

		[DllImport(dllName)]
		public static extern ulong wgpuAdapterEnumerateFeatures(IntPtr adapter, WGPUFeatureName* features);

		[DllImport(dllName)]
		public static extern bool wgpuAdapterGetLimits(IntPtr adapter, WGPUSupportedLimits* limits);

		[DllImport(dllName)]
		public static extern void wgpuAdapterGetProperties(IntPtr adapter, WGPUAdapterProperties* properties);

		[DllImport(dllName)]
		public static extern bool wgpuAdapterHasFeature(IntPtr adapter, WGPUFeatureName feature);

		[DllImport(dllName)]
		public static extern void wgpuAdapterRequestDevice(IntPtr adapter, WGPUDeviceDescriptor* descriptor, WGPURequestDeviceCallback callback, void* userdata);

		[DllImport(dllName)]
		public static extern void wgpuBindGroupSetLabel(IntPtr bindGroup, char* label);

		[DllImport(dllName)]
		public static extern void wgpuBindGroupLayoutSetLabel(IntPtr bindGroupLayout, char* label);

		[DllImport(dllName)]
		public static extern void wgpuBufferDestroy(IntPtr buffer);

		[DllImport(dllName)]
		public static extern void* wgpuBufferGetConstMappedRange(IntPtr buffer, ulong offset, ulong size);

		[DllImport(dllName)]
		public static extern WGPUBufferMapState wgpuBufferGetMapState(IntPtr buffer);

		[DllImport(dllName)]
		public static extern void* wgpuBufferGetMappedRange(IntPtr buffer, ulong offset, ulong size);

		[DllImport(dllName)]
		public static extern ulong wgpuBufferGetSize(IntPtr buffer);

		[DllImport(dllName)]
		public static extern WGPUBufferUsage wgpuBufferGetUsage(IntPtr buffer);

		[DllImport(dllName)]
		public static extern void wgpuBufferMapAsync(IntPtr buffer, WGPUMapMode mode, ulong offset, ulong size, WGPUBufferMapCallback callback, void* userdata);

		[DllImport(dllName)]
		public static extern void wgpuBufferSetLabel(IntPtr buffer, char* label);

		[DllImport(dllName)]
		public static extern void wgpuBufferUnmap(IntPtr buffer);

		[DllImport(dllName)]
		public static extern void wgpuCommandBufferSetLabel(IntPtr commandBuffer, char* label);

		[DllImport(dllName)]
		public static extern IntPtr wgpuCommandEncoderBeginComputePass(IntPtr commandEncoder, WGPUComputePassDescriptor* descriptor);

		[DllImport(dllName)]
		public static extern IntPtr wgpuCommandEncoderBeginRenderPass(IntPtr commandEncoder, WGPURenderPassDescriptor* descriptor);

		[DllImport(dllName)]
		public static extern void wgpuCommandEncoderClearBuffer(IntPtr commandEncoder, IntPtr buffer, ulong offset, ulong size);

		[DllImport(dllName)]
		public static extern void wgpuCommandEncoderCopyBufferToBuffer(IntPtr commandEncoder, IntPtr source, ulong sourceOffset, IntPtr destination, ulong destinationOffset, ulong size);

		[DllImport(dllName)]
		public static extern void wgpuCommandEncoderCopyBufferToTexture(IntPtr commandEncoder, WGPUImageCopyBuffer* source, WGPUImageCopyTexture* destination, WGPUExtent3D* copySize);

		[DllImport(dllName)]
		public static extern void wgpuCommandEncoderCopyTextureToBuffer(IntPtr commandEncoder, WGPUImageCopyTexture* source, WGPUImageCopyBuffer* destination, WGPUExtent3D* copySize);

		[DllImport(dllName)]
		public static extern void wgpuCommandEncoderCopyTextureToTexture(IntPtr commandEncoder, WGPUImageCopyTexture* source, WGPUImageCopyTexture* destination, WGPUExtent3D* copySize);

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
		public static extern void wgpuCommandEncoderSetLabel(IntPtr commandEncoder, char* label);

		[DllImport(dllName)]
		public static extern void wgpuCommandEncoderWriteTimestamp(IntPtr commandEncoder, IntPtr querySet, uint queryIndex);

		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderBeginPipelineStatisticsQuery(IntPtr computePassEncoder, IntPtr querySet, uint queryIndex);

		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderDispatchWorkgroups(IntPtr computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ);

		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderDispatchWorkgroupsIndirect(IntPtr computePassEncoder, IntPtr indirectBuffer, ulong indirectOffset);

		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderEnd(IntPtr computePassEncoder);

		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderEndPipelineStatisticsQuery(IntPtr computePassEncoder);

		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderInsertDebugMarker(IntPtr computePassEncoder, char* markerLabel);

		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderPopDebugGroup(IntPtr computePassEncoder);

		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderPushDebugGroup(IntPtr computePassEncoder, char* groupLabel);

		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderSetBindGroup(IntPtr computePassEncoder, uint groupIndex, IntPtr group, uint dynamicOffsetCount, uint* dynamicOffsets);

		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderSetLabel(IntPtr computePassEncoder, char* label);

		[DllImport(dllName)]
		public static extern void wgpuComputePassEncoderSetPipeline(IntPtr computePassEncoder, IntPtr pipeline);

		[DllImport(dllName)]
		public static extern IntPtr wgpuComputePipelineGetBindGroupLayout(IntPtr computePipeline, uint groupIndex);

		[DllImport(dllName)]
		public static extern void wgpuComputePipelineSetLabel(IntPtr computePipeline, char* label);

		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateBindGroup(IntPtr device, WGPUBindGroupDescriptor* descriptor);

		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateBindGroupLayout(IntPtr device, WGPUBindGroupLayoutDescriptor* descriptor);

		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateBuffer(IntPtr device, ref WGPUBufferDescriptor descriptor);

		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateCommandEncoder(IntPtr device, WGPUCommandEncoderDescriptor* descriptor);

		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateComputePipeline(IntPtr device, WGPUComputePipelineDescriptor* descriptor);

		[DllImport(dllName)]
		public static extern void wgpuDeviceCreateComputePipelineAsync(IntPtr device, WGPUComputePipelineDescriptor* descriptor, WGPUCreateComputePipelineAsyncCallback callback, void* userdata);

		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreatePipelineLayout(IntPtr device, WGPUPipelineLayoutDescriptor* descriptor);

		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateQuerySet(IntPtr device, WGPUQuerySetDescriptor* descriptor);

		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateRenderBundleEncoder(IntPtr device, WGPURenderBundleEncoderDescriptor* descriptor);

		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateRenderPipeline(IntPtr device, ref WGPURenderPipelineDescriptor descriptor);

		[DllImport(dllName)]
		public static extern void wgpuDeviceCreateRenderPipelineAsync(IntPtr device, ref WGPURenderPipelineDescriptor descriptor, WGPUCreateRenderPipelineAsyncCallback callback, void* userdata);

		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateSampler(IntPtr device, WGPUSamplerDescriptor* descriptor);

		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateShaderModule(IntPtr device, WGPUShaderModuleDescriptor* descriptor);

		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateSwapChain(IntPtr device, IntPtr surface, WGPUSwapChainDescriptor* descriptor);

		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceCreateTexture(IntPtr device, WGPUTextureDescriptor* descriptor);

		[DllImport(dllName)]
		public static extern void wgpuDeviceDestroy(IntPtr device);

		[DllImport(dllName)]
		public static extern ulong wgpuDeviceEnumerateFeatures(IntPtr device, WGPUFeatureName* features);

		[DllImport(dllName)]
		public static extern bool wgpuDeviceGetLimits(IntPtr device, WGPUSupportedLimits* limits);

		[DllImport(dllName)]
		public static extern IntPtr wgpuDeviceGetQueue(IntPtr device);

		[DllImport(dllName)]
		public static extern bool wgpuDeviceHasFeature(IntPtr device, WGPUFeatureName feature);

		[DllImport(dllName)]
		public static extern void wgpuDeviceSetLabel(IntPtr device, char* label);

		[DllImport(dllName)]
		public static extern void wgpuDeviceSetUncapturedErrorCallback(IntPtr device, WGPUErrorCallback callback, void* userdata);

		[DllImport(dllName)]
		public static extern IntPtr wgpuInstanceCreateSurface(IntPtr instance, WGPUSurfaceDescriptor* descriptor);

		[DllImport(dllName)]
		public static extern void wgpuInstanceProcessEvents(IntPtr instance);

		[DllImport(dllName)]
		public static extern void wgpuInstanceRequestAdapter(IntPtr instance, WGPURequestAdapterOptions* options, WGPURequestAdapterCallback callback, void* userdata);

		[DllImport(dllName)]
		public static extern void wgpuPipelineLayoutSetLabel(IntPtr pipelineLayout, char* label);

		[DllImport(dllName)]
		public static extern void wgpuQuerySetDestroy(IntPtr querySet);

		[DllImport(dllName)]
		public static extern uint wgpuQuerySetGetCount(IntPtr querySet);

		[DllImport(dllName)]
		public static extern WGPUQueryType wgpuQuerySetGetType(IntPtr querySet);

		[DllImport(dllName)]
		public static extern void wgpuQuerySetSetLabel(IntPtr querySet, char* label);

		[DllImport(dllName)]
		public static extern void wgpuQueueOnSubmittedWorkDone(IntPtr queue, WGPUQueueWorkDoneCallback callback, void* userdata);

		[DllImport(dllName)]
		public static extern void wgpuQueueSetLabel(IntPtr queue, char* label);

		[DllImport(dllName)]
		public static extern void wgpuQueueSubmit(IntPtr queue, uint commandCount, IntPtr* commands);

		[DllImport(dllName)]
		public static extern void wgpuQueueWriteBuffer(IntPtr queue, IntPtr buffer, ulong bufferOffset, void* data, ulong size);

		[DllImport(dllName)]
		public static extern void wgpuQueueWriteTexture(IntPtr queue, WGPUImageCopyTexture* destination, void* data, ulong dataSize, WGPUTextureDataLayout* dataLayout, WGPUExtent3D* writeSize);

		[DllImport(dllName)]
		public static extern void wgpuRenderBundleEncoderDraw(IntPtr renderBundleEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

		[DllImport(dllName)]
		public static extern void wgpuRenderBundleEncoderDrawIndexed(IntPtr renderBundleEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

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
		public static extern void wgpuRenderBundleEncoderSetIndexBuffer(IntPtr renderBundleEncoder, IntPtr buffer, WGPUIndexFormat format, ulong offset, ulong size);

		[DllImport(dllName)]
		public static extern void wgpuRenderBundleEncoderSetLabel(IntPtr renderBundleEncoder, char* label);

		[DllImport(dllName)]
		public static extern void wgpuRenderBundleEncoderSetPipeline(IntPtr renderBundleEncoder, IntPtr pipeline);

		[DllImport(dllName)]
		public static extern void wgpuRenderBundleEncoderSetVertexBuffer(IntPtr renderBundleEncoder, uint slot, IntPtr buffer, ulong offset, ulong size);

		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderBeginOcclusionQuery(IntPtr renderPassEncoder, uint queryIndex);

		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderBeginPipelineStatisticsQuery(IntPtr renderPassEncoder, IntPtr querySet, uint queryIndex);

		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderDraw(IntPtr renderPassEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderDrawIndexed(IntPtr renderPassEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderDrawIndexedIndirect(IntPtr renderPassEncoder, IntPtr indirectBuffer, ulong indirectOffset);

		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderDrawIndirect(IntPtr renderPassEncoder, IntPtr indirectBuffer, ulong indirectOffset);

		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderEnd(IntPtr renderPassEncoder);

		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderEndOcclusionQuery(IntPtr renderPassEncoder);

		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderEndPipelineStatisticsQuery(IntPtr renderPassEncoder);

		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderExecuteBundles(IntPtr renderPassEncoder, uint bundleCount, IntPtr* bundles);

		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderInsertDebugMarker(IntPtr renderPassEncoder, char* markerLabel);

		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderPopDebugGroup(IntPtr renderPassEncoder);

		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderPushDebugGroup(IntPtr renderPassEncoder, char* groupLabel);

		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderSetBindGroup(IntPtr renderPassEncoder, uint groupIndex, IntPtr group, uint dynamicOffsetCount, uint* dynamicOffsets);

		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderSetBlendConstant(IntPtr renderPassEncoder, WGPUColor* color);

		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderSetIndexBuffer(IntPtr renderPassEncoder, IntPtr buffer, WGPUIndexFormat format, ulong offset, ulong size);

		[DllImport(dllName)]
		public static extern void wgpuRenderPassEncoderSetLabel(IntPtr renderPassEncoder, char* label);

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
		public static extern IntPtr wgpuRenderPipelineGetBindGroupLayout(IntPtr renderPipeline, uint groupIndex);

		[DllImport(dllName)]
		public static extern void wgpuRenderPipelineSetLabel(IntPtr renderPipeline, char* label);

		[DllImport(dllName)]
		public static extern void wgpuSamplerSetLabel(IntPtr sampler, char* label);

		[DllImport(dllName)]
		public static extern void wgpuShaderModuleGetCompilationInfo(IntPtr shaderModule, WGPUCompilationInfoCallback callback, void* userdata);

		[DllImport(dllName)]
		public static extern void wgpuShaderModuleSetLabel(IntPtr shaderModule, char* label);

		[DllImport(dllName)]
		public static extern WGPUTextureFormat wgpuSurfaceGetPreferredFormat(IntPtr surface, IntPtr adapter);

		[DllImport(dllName)]
		public static extern IntPtr wgpuSwapChainGetCurrentTextureView(IntPtr swapChain);

		[DllImport(dllName)]
		public static extern void wgpuSwapChainPresent(IntPtr swapChain);

		[DllImport(dllName)]
		public static extern IntPtr wgpuTextureCreateView(IntPtr texture, WGPUTextureViewDescriptor* descriptor);

		[DllImport(dllName)]
		public static extern void wgpuTextureDestroy(IntPtr texture);

		[DllImport(dllName)]
		public static extern uint wgpuTextureGetDepthOrArrayLayers(IntPtr texture);

		[DllImport(dllName)]
		public static extern WGPUTextureDimension wgpuTextureGetDimension(IntPtr texture);

		[DllImport(dllName)]
		public static extern WGPUTextureFormat wgpuTextureGetFormat(IntPtr texture);

		[DllImport(dllName)]
		public static extern uint wgpuTextureGetHeight(IntPtr texture);

		[DllImport(dllName)]
		public static extern uint wgpuTextureGetMipLevelCount(IntPtr texture);

		[DllImport(dllName)]
		public static extern uint wgpuTextureGetSampleCount(IntPtr texture);

		[DllImport(dllName)]
		public static extern WGPUTextureUsage wgpuTextureGetUsage(IntPtr texture);

		[DllImport(dllName)]
		public static extern uint wgpuTextureGetWidth(IntPtr texture);

		[DllImport(dllName)]
		public static extern void wgpuTextureSetLabel(IntPtr texture, char* label);

		[DllImport(dllName)]
		public static extern void wgpuTextureViewSetLabel(IntPtr textureView, char* label);
	}
}
