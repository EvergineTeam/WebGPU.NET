using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.WebGPU
{
	public static unsafe partial class WebGPUNative
	{

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCreateInstance")]
		public static extern WGPUInstance wgpuCreateInstance(WGPUInstanceDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuGetProcAddress")]
		public static extern delegate* unmanaged<void> wgpuGetProcAddress(WGPUDevice device, char* procName);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuAdapterEnumerateFeatures")]
		public static extern ulong wgpuAdapterEnumerateFeatures(WGPUAdapter adapter, WGPUFeatureName* features);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuAdapterGetLimits")]
		public static extern bool wgpuAdapterGetLimits(WGPUAdapter adapter, WGPUSupportedLimits* limits);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuAdapterGetProperties")]
		public static extern void wgpuAdapterGetProperties(WGPUAdapter adapter, WGPUAdapterProperties* properties);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuAdapterHasFeature")]
		public static extern bool wgpuAdapterHasFeature(WGPUAdapter adapter, WGPUFeatureName feature);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuAdapterRequestDevice")]
		public static extern void wgpuAdapterRequestDevice(WGPUAdapter adapter, WGPUDeviceDescriptor* descriptor, delegate* unmanaged<WGPURequestDeviceStatus, WGPUDevice, char*, void*, void> callback, void* userdata);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuAdapterReference")]
		public static extern void wgpuAdapterReference(WGPUAdapter adapter);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuAdapterRelease")]
		public static extern void wgpuAdapterRelease(WGPUAdapter adapter);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBindGroupSetLabel")]
		public static extern void wgpuBindGroupSetLabel(WGPUBindGroup bindGroup, char* label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBindGroupReference")]
		public static extern void wgpuBindGroupReference(WGPUBindGroup bindGroup);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBindGroupRelease")]
		public static extern void wgpuBindGroupRelease(WGPUBindGroup bindGroup);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBindGroupLayoutSetLabel")]
		public static extern void wgpuBindGroupLayoutSetLabel(WGPUBindGroupLayout bindGroupLayout, char* label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBindGroupLayoutReference")]
		public static extern void wgpuBindGroupLayoutReference(WGPUBindGroupLayout bindGroupLayout);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBindGroupLayoutRelease")]
		public static extern void wgpuBindGroupLayoutRelease(WGPUBindGroupLayout bindGroupLayout);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferDestroy")]
		public static extern void wgpuBufferDestroy(WGPUBuffer buffer);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferGetConstMappedRange")]
		public static extern void* wgpuBufferGetConstMappedRange(WGPUBuffer buffer, ulong offset, ulong size);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferGetMappedRange")]
		public static extern void* wgpuBufferGetMappedRange(WGPUBuffer buffer, ulong offset, ulong size);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferGetSize")]
		public static extern ulong wgpuBufferGetSize(WGPUBuffer buffer);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferGetUsage")]
		public static extern WGPUBufferUsage wgpuBufferGetUsage(WGPUBuffer buffer);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferMapAsync")]
		public static extern void wgpuBufferMapAsync(WGPUBuffer buffer, WGPUMapMode mode, ulong offset, ulong size, delegate* unmanaged<WGPUBufferMapAsyncStatus, void*, void> callback, void* userdata);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferSetLabel")]
		public static extern void wgpuBufferSetLabel(WGPUBuffer buffer, char* label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferUnmap")]
		public static extern void wgpuBufferUnmap(WGPUBuffer buffer);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferReference")]
		public static extern void wgpuBufferReference(WGPUBuffer buffer);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferRelease")]
		public static extern void wgpuBufferRelease(WGPUBuffer buffer);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandBufferSetLabel")]
		public static extern void wgpuCommandBufferSetLabel(WGPUCommandBuffer commandBuffer, char* label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandBufferReference")]
		public static extern void wgpuCommandBufferReference(WGPUCommandBuffer commandBuffer);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandBufferRelease")]
		public static extern void wgpuCommandBufferRelease(WGPUCommandBuffer commandBuffer);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderBeginComputePass")]
		public static extern WGPUComputePassEncoder wgpuCommandEncoderBeginComputePass(WGPUCommandEncoder commandEncoder, WGPUComputePassDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderBeginRenderPass")]
		public static extern WGPURenderPassEncoder wgpuCommandEncoderBeginRenderPass(WGPUCommandEncoder commandEncoder, WGPURenderPassDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderClearBuffer")]
		public static extern void wgpuCommandEncoderClearBuffer(WGPUCommandEncoder commandEncoder, WGPUBuffer buffer, ulong offset, ulong size);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
		public static extern void wgpuCommandEncoderCopyBufferToBuffer(WGPUCommandEncoder commandEncoder, WGPUBuffer source, ulong sourceOffset, WGPUBuffer destination, ulong destinationOffset, ulong size);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
		public static extern void wgpuCommandEncoderCopyBufferToTexture(WGPUCommandEncoder commandEncoder, WGPUImageCopyBuffer* source, WGPUImageCopyTexture* destination, WGPUExtent3D* copySize);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
		public static extern void wgpuCommandEncoderCopyTextureToBuffer(WGPUCommandEncoder commandEncoder, WGPUImageCopyTexture* source, WGPUImageCopyBuffer* destination, WGPUExtent3D* copySize);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
		public static extern void wgpuCommandEncoderCopyTextureToTexture(WGPUCommandEncoder commandEncoder, WGPUImageCopyTexture* source, WGPUImageCopyTexture* destination, WGPUExtent3D* copySize);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderFinish")]
		public static extern WGPUCommandBuffer wgpuCommandEncoderFinish(WGPUCommandEncoder commandEncoder, WGPUCommandBufferDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
		public static extern void wgpuCommandEncoderInsertDebugMarker(WGPUCommandEncoder commandEncoder, char* markerLabel);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderPopDebugGroup")]
		public static extern void wgpuCommandEncoderPopDebugGroup(WGPUCommandEncoder commandEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
		public static extern void wgpuCommandEncoderPushDebugGroup(WGPUCommandEncoder commandEncoder, char* groupLabel);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
		public static extern void wgpuCommandEncoderResolveQuerySet(WGPUCommandEncoder commandEncoder, WGPUQuerySet querySet, uint firstQuery, uint queryCount, WGPUBuffer destination, ulong destinationOffset);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderSetLabel")]
		public static extern void wgpuCommandEncoderSetLabel(WGPUCommandEncoder commandEncoder, char* label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderWriteTimestamp")]
		public static extern void wgpuCommandEncoderWriteTimestamp(WGPUCommandEncoder commandEncoder, WGPUQuerySet querySet, uint queryIndex);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderReference")]
		public static extern void wgpuCommandEncoderReference(WGPUCommandEncoder commandEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderRelease")]
		public static extern void wgpuCommandEncoderRelease(WGPUCommandEncoder commandEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderBeginPipelineStatisticsQuery")]
		public static extern void wgpuComputePassEncoderBeginPipelineStatisticsQuery(WGPUComputePassEncoder computePassEncoder, WGPUQuerySet querySet, uint queryIndex);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderDispatchWorkgroups")]
		public static extern void wgpuComputePassEncoderDispatchWorkgroups(WGPUComputePassEncoder computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderDispatchWorkgroupsIndirect")]
		public static extern void wgpuComputePassEncoderDispatchWorkgroupsIndirect(WGPUComputePassEncoder computePassEncoder, WGPUBuffer indirectBuffer, ulong indirectOffset);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderEnd")]
		public static extern void wgpuComputePassEncoderEnd(WGPUComputePassEncoder computePassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderEndPipelineStatisticsQuery")]
		public static extern void wgpuComputePassEncoderEndPipelineStatisticsQuery(WGPUComputePassEncoder computePassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
		public static extern void wgpuComputePassEncoderInsertDebugMarker(WGPUComputePassEncoder computePassEncoder, char* markerLabel);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderPopDebugGroup")]
		public static extern void wgpuComputePassEncoderPopDebugGroup(WGPUComputePassEncoder computePassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
		public static extern void wgpuComputePassEncoderPushDebugGroup(WGPUComputePassEncoder computePassEncoder, char* groupLabel);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
		public static extern void wgpuComputePassEncoderSetBindGroup(WGPUComputePassEncoder computePassEncoder, uint groupIndex, WGPUBindGroup group, uint dynamicOffsetCount, uint* dynamicOffsets);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderSetLabel")]
		public static extern void wgpuComputePassEncoderSetLabel(WGPUComputePassEncoder computePassEncoder, char* label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderSetPipeline")]
		public static extern void wgpuComputePassEncoderSetPipeline(WGPUComputePassEncoder computePassEncoder, WGPUComputePipeline pipeline);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderWriteTimestamp")]
		public static extern void wgpuComputePassEncoderWriteTimestamp(WGPUComputePassEncoder computePassEncoder, WGPUQuerySet querySet, uint queryIndex);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderReference")]
		public static extern void wgpuComputePassEncoderReference(WGPUComputePassEncoder computePassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderRelease")]
		public static extern void wgpuComputePassEncoderRelease(WGPUComputePassEncoder computePassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePipelineGetBindGroupLayout")]
		public static extern WGPUBindGroupLayout wgpuComputePipelineGetBindGroupLayout(WGPUComputePipeline computePipeline, uint groupIndex);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePipelineSetLabel")]
		public static extern void wgpuComputePipelineSetLabel(WGPUComputePipeline computePipeline, char* label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePipelineReference")]
		public static extern void wgpuComputePipelineReference(WGPUComputePipeline computePipeline);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePipelineRelease")]
		public static extern void wgpuComputePipelineRelease(WGPUComputePipeline computePipeline);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateBindGroup")]
		public static extern WGPUBindGroup wgpuDeviceCreateBindGroup(WGPUDevice device, WGPUBindGroupDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateBindGroupLayout")]
		public static extern WGPUBindGroupLayout wgpuDeviceCreateBindGroupLayout(WGPUDevice device, WGPUBindGroupLayoutDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateBuffer")]
		public static extern WGPUBuffer wgpuDeviceCreateBuffer(WGPUDevice device, WGPUBufferDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateCommandEncoder")]
		public static extern WGPUCommandEncoder wgpuDeviceCreateCommandEncoder(WGPUDevice device, WGPUCommandEncoderDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateComputePipeline")]
		public static extern WGPUComputePipeline wgpuDeviceCreateComputePipeline(WGPUDevice device, WGPUComputePipelineDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
		public static extern void wgpuDeviceCreateComputePipelineAsync(WGPUDevice device, WGPUComputePipelineDescriptor* descriptor, delegate* unmanaged<WGPUCreatePipelineAsyncStatus, WGPUComputePipeline, char*, void*, void> callback, void* userdata);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreatePipelineLayout")]
		public static extern WGPUPipelineLayout wgpuDeviceCreatePipelineLayout(WGPUDevice device, WGPUPipelineLayoutDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateQuerySet")]
		public static extern WGPUQuerySet wgpuDeviceCreateQuerySet(WGPUDevice device, WGPUQuerySetDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateRenderBundleEncoder")]
		public static extern WGPURenderBundleEncoder wgpuDeviceCreateRenderBundleEncoder(WGPUDevice device, WGPURenderBundleEncoderDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateRenderPipeline")]
		public static extern WGPURenderPipeline wgpuDeviceCreateRenderPipeline(WGPUDevice device, WGPURenderPipelineDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
		public static extern void wgpuDeviceCreateRenderPipelineAsync(WGPUDevice device, WGPURenderPipelineDescriptor* descriptor, delegate* unmanaged<WGPUCreatePipelineAsyncStatus, WGPURenderPipeline, char*, void*, void> callback, void* userdata);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateSampler")]
		public static extern WGPUSampler wgpuDeviceCreateSampler(WGPUDevice device, WGPUSamplerDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateShaderModule")]
		public static extern WGPUShaderModule wgpuDeviceCreateShaderModule(WGPUDevice device, WGPUShaderModuleDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateSwapChain")]
		public static extern WGPUSwapChain wgpuDeviceCreateSwapChain(WGPUDevice device, WGPUSurface surface, WGPUSwapChainDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateTexture")]
		public static extern WGPUTexture wgpuDeviceCreateTexture(WGPUDevice device, WGPUTextureDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceDestroy")]
		public static extern void wgpuDeviceDestroy(WGPUDevice device);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceEnumerateFeatures")]
		public static extern ulong wgpuDeviceEnumerateFeatures(WGPUDevice device, WGPUFeatureName* features);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceGetLimits")]
		public static extern bool wgpuDeviceGetLimits(WGPUDevice device, WGPUSupportedLimits* limits);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceGetQueue")]
		public static extern WGPUQueue wgpuDeviceGetQueue(WGPUDevice device);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceHasFeature")]
		public static extern bool wgpuDeviceHasFeature(WGPUDevice device, WGPUFeatureName feature);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceSetLabel")]
		public static extern void wgpuDeviceSetLabel(WGPUDevice device, char* label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceSetUncapturedErrorCallback")]
		public static extern void wgpuDeviceSetUncapturedErrorCallback(WGPUDevice device, delegate* unmanaged<WGPUErrorType, char*, void*, void> callback, void* userdata);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceReference")]
		public static extern void wgpuDeviceReference(WGPUDevice device);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceRelease")]
		public static extern void wgpuDeviceRelease(WGPUDevice device);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuInstanceCreateSurface")]
		public static extern WGPUSurface wgpuInstanceCreateSurface(WGPUInstance instance, WGPUSurfaceDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuInstanceProcessEvents")]
		public static extern void wgpuInstanceProcessEvents(WGPUInstance instance);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuInstanceRequestAdapter")]
		public static extern void wgpuInstanceRequestAdapter(WGPUInstance instance, WGPURequestAdapterOptions* options, delegate* unmanaged<WGPURequestAdapterStatus, WGPUAdapter, char*, void*, void> callback, void* userdata);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuInstanceReference")]
		public static extern void wgpuInstanceReference(WGPUInstance instance);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuInstanceRelease")]
		public static extern void wgpuInstanceRelease(WGPUInstance instance);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuPipelineLayoutSetLabel")]
		public static extern void wgpuPipelineLayoutSetLabel(WGPUPipelineLayout pipelineLayout, char* label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuPipelineLayoutReference")]
		public static extern void wgpuPipelineLayoutReference(WGPUPipelineLayout pipelineLayout);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuPipelineLayoutRelease")]
		public static extern void wgpuPipelineLayoutRelease(WGPUPipelineLayout pipelineLayout);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQuerySetDestroy")]
		public static extern void wgpuQuerySetDestroy(WGPUQuerySet querySet);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQuerySetGetCount")]
		public static extern uint wgpuQuerySetGetCount(WGPUQuerySet querySet);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQuerySetGetType")]
		public static extern WGPUQueryType wgpuQuerySetGetType(WGPUQuerySet querySet);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQuerySetSetLabel")]
		public static extern void wgpuQuerySetSetLabel(WGPUQuerySet querySet, char* label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQuerySetReference")]
		public static extern void wgpuQuerySetReference(WGPUQuerySet querySet);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQuerySetRelease")]
		public static extern void wgpuQuerySetRelease(WGPUQuerySet querySet);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
		public static extern void wgpuQueueOnSubmittedWorkDone(WGPUQueue queue, ulong signalValue, delegate* unmanaged<WGPUQueueWorkDoneStatus, void*, void> callback, void* userdata);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQueueSetLabel")]
		public static extern void wgpuQueueSetLabel(WGPUQueue queue, char* label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQueueSubmit")]
		public static extern void wgpuQueueSubmit(WGPUQueue queue, uint commandCount, WGPUCommandBuffer* commands);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQueueWriteBuffer")]
		public static extern void wgpuQueueWriteBuffer(WGPUQueue queue, WGPUBuffer buffer, ulong bufferOffset, void* data, ulong size);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQueueWriteTexture")]
		public static extern void wgpuQueueWriteTexture(WGPUQueue queue, WGPUImageCopyTexture* destination, void* data, ulong dataSize, WGPUTextureDataLayout* dataLayout, WGPUExtent3D* writeSize);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQueueReference")]
		public static extern void wgpuQueueReference(WGPUQueue queue);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQueueRelease")]
		public static extern void wgpuQueueRelease(WGPUQueue queue);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleReference")]
		public static extern void wgpuRenderBundleReference(WGPURenderBundle renderBundle);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleRelease")]
		public static extern void wgpuRenderBundleRelease(WGPURenderBundle renderBundle);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderDraw")]
		public static extern void wgpuRenderBundleEncoderDraw(WGPURenderBundleEncoder renderBundleEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderDrawIndexed")]
		public static extern void wgpuRenderBundleEncoderDrawIndexed(WGPURenderBundleEncoder renderBundleEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderFinish")]
		public static extern WGPURenderBundle wgpuRenderBundleEncoderFinish(WGPURenderBundleEncoder renderBundleEncoder, WGPURenderBundleDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
		public static extern void wgpuRenderBundleEncoderInsertDebugMarker(WGPURenderBundleEncoder renderBundleEncoder, char* markerLabel);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderPopDebugGroup")]
		public static extern void wgpuRenderBundleEncoderPopDebugGroup(WGPURenderBundleEncoder renderBundleEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
		public static extern void wgpuRenderBundleEncoderPushDebugGroup(WGPURenderBundleEncoder renderBundleEncoder, char* groupLabel);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
		public static extern void wgpuRenderBundleEncoderSetBindGroup(WGPURenderBundleEncoder renderBundleEncoder, uint groupIndex, WGPUBindGroup group, uint dynamicOffsetCount, uint* dynamicOffsets);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderSetIndexBuffer")]
		public static extern void wgpuRenderBundleEncoderSetIndexBuffer(WGPURenderBundleEncoder renderBundleEncoder, WGPUBuffer buffer, WGPUIndexFormat format, ulong offset, ulong size);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
		public static extern void wgpuRenderBundleEncoderSetLabel(WGPURenderBundleEncoder renderBundleEncoder, char* label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderSetPipeline")]
		public static extern void wgpuRenderBundleEncoderSetPipeline(WGPURenderBundleEncoder renderBundleEncoder, WGPURenderPipeline pipeline);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderSetVertexBuffer")]
		public static extern void wgpuRenderBundleEncoderSetVertexBuffer(WGPURenderBundleEncoder renderBundleEncoder, uint slot, WGPUBuffer buffer, ulong offset, ulong size);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderReference")]
		public static extern void wgpuRenderBundleEncoderReference(WGPURenderBundleEncoder renderBundleEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderRelease")]
		public static extern void wgpuRenderBundleEncoderRelease(WGPURenderBundleEncoder renderBundleEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderBeginOcclusionQuery")]
		public static extern void wgpuRenderPassEncoderBeginOcclusionQuery(WGPURenderPassEncoder renderPassEncoder, uint queryIndex);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderBeginPipelineStatisticsQuery")]
		public static extern void wgpuRenderPassEncoderBeginPipelineStatisticsQuery(WGPURenderPassEncoder renderPassEncoder, WGPUQuerySet querySet, uint queryIndex);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderDraw")]
		public static extern void wgpuRenderPassEncoderDraw(WGPURenderPassEncoder renderPassEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderDrawIndexed")]
		public static extern void wgpuRenderPassEncoderDrawIndexed(WGPURenderPassEncoder renderPassEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderDrawIndexedIndirect")]
		public static extern void wgpuRenderPassEncoderDrawIndexedIndirect(WGPURenderPassEncoder renderPassEncoder, WGPUBuffer indirectBuffer, ulong indirectOffset);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderDrawIndirect")]
		public static extern void wgpuRenderPassEncoderDrawIndirect(WGPURenderPassEncoder renderPassEncoder, WGPUBuffer indirectBuffer, ulong indirectOffset);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderEnd")]
		public static extern void wgpuRenderPassEncoderEnd(WGPURenderPassEncoder renderPassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderEndOcclusionQuery")]
		public static extern void wgpuRenderPassEncoderEndOcclusionQuery(WGPURenderPassEncoder renderPassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderEndPipelineStatisticsQuery")]
		public static extern void wgpuRenderPassEncoderEndPipelineStatisticsQuery(WGPURenderPassEncoder renderPassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderExecuteBundles")]
		public static extern void wgpuRenderPassEncoderExecuteBundles(WGPURenderPassEncoder renderPassEncoder, uint bundlesCount, WGPURenderBundle* bundles);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
		public static extern void wgpuRenderPassEncoderInsertDebugMarker(WGPURenderPassEncoder renderPassEncoder, char* markerLabel);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderPopDebugGroup")]
		public static extern void wgpuRenderPassEncoderPopDebugGroup(WGPURenderPassEncoder renderPassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
		public static extern void wgpuRenderPassEncoderPushDebugGroup(WGPURenderPassEncoder renderPassEncoder, char* groupLabel);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
		public static extern void wgpuRenderPassEncoderSetBindGroup(WGPURenderPassEncoder renderPassEncoder, uint groupIndex, WGPUBindGroup group, uint dynamicOffsetCount, uint* dynamicOffsets);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderSetBlendConstant")]
		public static extern void wgpuRenderPassEncoderSetBlendConstant(WGPURenderPassEncoder renderPassEncoder, WGPUColor* color);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderSetIndexBuffer")]
		public static extern void wgpuRenderPassEncoderSetIndexBuffer(WGPURenderPassEncoder renderPassEncoder, WGPUBuffer buffer, WGPUIndexFormat format, ulong offset, ulong size);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderSetLabel")]
		public static extern void wgpuRenderPassEncoderSetLabel(WGPURenderPassEncoder renderPassEncoder, char* label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderSetPipeline")]
		public static extern void wgpuRenderPassEncoderSetPipeline(WGPURenderPassEncoder renderPassEncoder, WGPURenderPipeline pipeline);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderSetScissorRect")]
		public static extern void wgpuRenderPassEncoderSetScissorRect(WGPURenderPassEncoder renderPassEncoder, uint x, uint y, uint width, uint height);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderSetStencilReference")]
		public static extern void wgpuRenderPassEncoderSetStencilReference(WGPURenderPassEncoder renderPassEncoder, uint reference);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderSetVertexBuffer")]
		public static extern void wgpuRenderPassEncoderSetVertexBuffer(WGPURenderPassEncoder renderPassEncoder, uint slot, WGPUBuffer buffer, ulong offset, ulong size);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderSetViewport")]
		public static extern void wgpuRenderPassEncoderSetViewport(WGPURenderPassEncoder renderPassEncoder, float x, float y, float width, float height, float minDepth, float maxDepth);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderWriteTimestamp")]
		public static extern void wgpuRenderPassEncoderWriteTimestamp(WGPURenderPassEncoder renderPassEncoder, WGPUQuerySet querySet, uint queryIndex);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderReference")]
		public static extern void wgpuRenderPassEncoderReference(WGPURenderPassEncoder renderPassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderRelease")]
		public static extern void wgpuRenderPassEncoderRelease(WGPURenderPassEncoder renderPassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPipelineGetBindGroupLayout")]
		public static extern WGPUBindGroupLayout wgpuRenderPipelineGetBindGroupLayout(WGPURenderPipeline renderPipeline, uint groupIndex);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPipelineSetLabel")]
		public static extern void wgpuRenderPipelineSetLabel(WGPURenderPipeline renderPipeline, char* label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPipelineReference")]
		public static extern void wgpuRenderPipelineReference(WGPURenderPipeline renderPipeline);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPipelineRelease")]
		public static extern void wgpuRenderPipelineRelease(WGPURenderPipeline renderPipeline);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSamplerSetLabel")]
		public static extern void wgpuSamplerSetLabel(WGPUSampler sampler, char* label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSamplerReference")]
		public static extern void wgpuSamplerReference(WGPUSampler sampler);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSamplerRelease")]
		public static extern void wgpuSamplerRelease(WGPUSampler sampler);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
		public static extern void wgpuShaderModuleGetCompilationInfo(WGPUShaderModule shaderModule, delegate* unmanaged<WGPUCompilationInfoRequestStatus, WGPUCompilationInfo*, void*, void> callback, void* userdata);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuShaderModuleSetLabel")]
		public static extern void wgpuShaderModuleSetLabel(WGPUShaderModule shaderModule, char* label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuShaderModuleReference")]
		public static extern void wgpuShaderModuleReference(WGPUShaderModule shaderModule);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuShaderModuleRelease")]
		public static extern void wgpuShaderModuleRelease(WGPUShaderModule shaderModule);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSurfaceGetPreferredFormat")]
		public static extern WGPUTextureFormat wgpuSurfaceGetPreferredFormat(WGPUSurface surface, WGPUAdapter adapter);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSurfaceReference")]
		public static extern void wgpuSurfaceReference(WGPUSurface surface);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSurfaceRelease")]
		public static extern void wgpuSurfaceRelease(WGPUSurface surface);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSwapChainGetCurrentTextureView")]
		public static extern WGPUTextureView wgpuSwapChainGetCurrentTextureView(WGPUSwapChain swapChain);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSwapChainPresent")]
		public static extern void wgpuSwapChainPresent(WGPUSwapChain swapChain);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSwapChainReference")]
		public static extern void wgpuSwapChainReference(WGPUSwapChain swapChain);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSwapChainRelease")]
		public static extern void wgpuSwapChainRelease(WGPUSwapChain swapChain);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureCreateView")]
		public static extern WGPUTextureView wgpuTextureCreateView(WGPUTexture texture, WGPUTextureViewDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureDestroy")]
		public static extern void wgpuTextureDestroy(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureGetDepthOrArrayLayers")]
		public static extern uint wgpuTextureGetDepthOrArrayLayers(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureGetDimension")]
		public static extern WGPUTextureDimension wgpuTextureGetDimension(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureGetFormat")]
		public static extern WGPUTextureFormat wgpuTextureGetFormat(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureGetHeight")]
		public static extern uint wgpuTextureGetHeight(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureGetMipLevelCount")]
		public static extern uint wgpuTextureGetMipLevelCount(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureGetSampleCount")]
		public static extern uint wgpuTextureGetSampleCount(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureGetUsage")]
		public static extern WGPUTextureUsage wgpuTextureGetUsage(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureGetWidth")]
		public static extern uint wgpuTextureGetWidth(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureSetLabel")]
		public static extern void wgpuTextureSetLabel(WGPUTexture texture, char* label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureReference")]
		public static extern void wgpuTextureReference(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureRelease")]
		public static extern void wgpuTextureRelease(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureViewSetLabel")]
		public static extern void wgpuTextureViewSetLabel(WGPUTextureView textureView, char* label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureViewReference")]
		public static extern void wgpuTextureViewReference(WGPUTextureView textureView);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureViewRelease")]
		public static extern void wgpuTextureViewRelease(WGPUTextureView textureView);
	}
}
