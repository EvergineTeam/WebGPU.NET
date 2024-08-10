using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.WebGPU
{
	public partial struct WGPUAdapter : IEquatable<WGPUAdapter>
	{
	public readonly IntPtr Handle;
	public WGPUAdapter(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPUAdapter Null => new WGPUAdapter(IntPtr.Zero);
	public static implicit operator WGPUAdapter(IntPtr handle) => new WGPUAdapter(handle);
	public static bool operator ==(WGPUAdapter left, WGPUAdapter right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUAdapter left, WGPUAdapter right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUAdapter left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPUAdapter left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPUAdapter h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPUAdapter h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPUBindGroup : IEquatable<WGPUBindGroup>
	{
	public readonly IntPtr Handle;
	public WGPUBindGroup(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPUBindGroup Null => new WGPUBindGroup(IntPtr.Zero);
	public static implicit operator WGPUBindGroup(IntPtr handle) => new WGPUBindGroup(handle);
	public static bool operator ==(WGPUBindGroup left, WGPUBindGroup right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUBindGroup left, WGPUBindGroup right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUBindGroup left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPUBindGroup left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPUBindGroup h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPUBindGroup h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPUBindGroupLayout : IEquatable<WGPUBindGroupLayout>
	{
	public readonly IntPtr Handle;
	public WGPUBindGroupLayout(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPUBindGroupLayout Null => new WGPUBindGroupLayout(IntPtr.Zero);
	public static implicit operator WGPUBindGroupLayout(IntPtr handle) => new WGPUBindGroupLayout(handle);
	public static bool operator ==(WGPUBindGroupLayout left, WGPUBindGroupLayout right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUBindGroupLayout left, WGPUBindGroupLayout right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUBindGroupLayout left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPUBindGroupLayout left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPUBindGroupLayout h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPUBindGroupLayout h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPUBuffer : IEquatable<WGPUBuffer>
	{
	public readonly IntPtr Handle;
	public WGPUBuffer(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPUBuffer Null => new WGPUBuffer(IntPtr.Zero);
	public static implicit operator WGPUBuffer(IntPtr handle) => new WGPUBuffer(handle);
	public static bool operator ==(WGPUBuffer left, WGPUBuffer right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUBuffer left, WGPUBuffer right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUBuffer left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPUBuffer left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPUBuffer h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPUBuffer h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPUCommandBuffer : IEquatable<WGPUCommandBuffer>
	{
	public readonly IntPtr Handle;
	public WGPUCommandBuffer(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPUCommandBuffer Null => new WGPUCommandBuffer(IntPtr.Zero);
	public static implicit operator WGPUCommandBuffer(IntPtr handle) => new WGPUCommandBuffer(handle);
	public static bool operator ==(WGPUCommandBuffer left, WGPUCommandBuffer right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUCommandBuffer left, WGPUCommandBuffer right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUCommandBuffer left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPUCommandBuffer left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPUCommandBuffer h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPUCommandBuffer h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPUCommandEncoder : IEquatable<WGPUCommandEncoder>
	{
	public readonly IntPtr Handle;
	public WGPUCommandEncoder(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPUCommandEncoder Null => new WGPUCommandEncoder(IntPtr.Zero);
	public static implicit operator WGPUCommandEncoder(IntPtr handle) => new WGPUCommandEncoder(handle);
	public static bool operator ==(WGPUCommandEncoder left, WGPUCommandEncoder right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUCommandEncoder left, WGPUCommandEncoder right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUCommandEncoder left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPUCommandEncoder left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPUCommandEncoder h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPUCommandEncoder h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPUComputePassEncoder : IEquatable<WGPUComputePassEncoder>
	{
	public readonly IntPtr Handle;
	public WGPUComputePassEncoder(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPUComputePassEncoder Null => new WGPUComputePassEncoder(IntPtr.Zero);
	public static implicit operator WGPUComputePassEncoder(IntPtr handle) => new WGPUComputePassEncoder(handle);
	public static bool operator ==(WGPUComputePassEncoder left, WGPUComputePassEncoder right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUComputePassEncoder left, WGPUComputePassEncoder right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUComputePassEncoder left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPUComputePassEncoder left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPUComputePassEncoder h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPUComputePassEncoder h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPUComputePipeline : IEquatable<WGPUComputePipeline>
	{
	public readonly IntPtr Handle;
	public WGPUComputePipeline(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPUComputePipeline Null => new WGPUComputePipeline(IntPtr.Zero);
	public static implicit operator WGPUComputePipeline(IntPtr handle) => new WGPUComputePipeline(handle);
	public static bool operator ==(WGPUComputePipeline left, WGPUComputePipeline right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUComputePipeline left, WGPUComputePipeline right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUComputePipeline left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPUComputePipeline left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPUComputePipeline h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPUComputePipeline h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPUDevice : IEquatable<WGPUDevice>
	{
	public readonly IntPtr Handle;
	public WGPUDevice(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPUDevice Null => new WGPUDevice(IntPtr.Zero);
	public static implicit operator WGPUDevice(IntPtr handle) => new WGPUDevice(handle);
	public static bool operator ==(WGPUDevice left, WGPUDevice right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUDevice left, WGPUDevice right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUDevice left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPUDevice left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPUDevice h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPUDevice h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPUInstance : IEquatable<WGPUInstance>
	{
	public readonly IntPtr Handle;
	public WGPUInstance(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPUInstance Null => new WGPUInstance(IntPtr.Zero);
	public static implicit operator WGPUInstance(IntPtr handle) => new WGPUInstance(handle);
	public static bool operator ==(WGPUInstance left, WGPUInstance right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUInstance left, WGPUInstance right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUInstance left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPUInstance left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPUInstance h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPUInstance h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPUPipelineLayout : IEquatable<WGPUPipelineLayout>
	{
	public readonly IntPtr Handle;
	public WGPUPipelineLayout(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPUPipelineLayout Null => new WGPUPipelineLayout(IntPtr.Zero);
	public static implicit operator WGPUPipelineLayout(IntPtr handle) => new WGPUPipelineLayout(handle);
	public static bool operator ==(WGPUPipelineLayout left, WGPUPipelineLayout right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUPipelineLayout left, WGPUPipelineLayout right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUPipelineLayout left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPUPipelineLayout left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPUPipelineLayout h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPUPipelineLayout h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPUQuerySet : IEquatable<WGPUQuerySet>
	{
	public readonly IntPtr Handle;
	public WGPUQuerySet(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPUQuerySet Null => new WGPUQuerySet(IntPtr.Zero);
	public static implicit operator WGPUQuerySet(IntPtr handle) => new WGPUQuerySet(handle);
	public static bool operator ==(WGPUQuerySet left, WGPUQuerySet right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUQuerySet left, WGPUQuerySet right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUQuerySet left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPUQuerySet left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPUQuerySet h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPUQuerySet h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPUQueue : IEquatable<WGPUQueue>
	{
	public readonly IntPtr Handle;
	public WGPUQueue(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPUQueue Null => new WGPUQueue(IntPtr.Zero);
	public static implicit operator WGPUQueue(IntPtr handle) => new WGPUQueue(handle);
	public static bool operator ==(WGPUQueue left, WGPUQueue right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUQueue left, WGPUQueue right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUQueue left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPUQueue left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPUQueue h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPUQueue h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPURenderBundle : IEquatable<WGPURenderBundle>
	{
	public readonly IntPtr Handle;
	public WGPURenderBundle(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPURenderBundle Null => new WGPURenderBundle(IntPtr.Zero);
	public static implicit operator WGPURenderBundle(IntPtr handle) => new WGPURenderBundle(handle);
	public static bool operator ==(WGPURenderBundle left, WGPURenderBundle right) => left.Handle == right.Handle;
	public static bool operator !=(WGPURenderBundle left, WGPURenderBundle right) => left.Handle != right.Handle;
	public static bool operator ==(WGPURenderBundle left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPURenderBundle left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPURenderBundle h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPURenderBundle h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPURenderBundleEncoder : IEquatable<WGPURenderBundleEncoder>
	{
	public readonly IntPtr Handle;
	public WGPURenderBundleEncoder(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPURenderBundleEncoder Null => new WGPURenderBundleEncoder(IntPtr.Zero);
	public static implicit operator WGPURenderBundleEncoder(IntPtr handle) => new WGPURenderBundleEncoder(handle);
	public static bool operator ==(WGPURenderBundleEncoder left, WGPURenderBundleEncoder right) => left.Handle == right.Handle;
	public static bool operator !=(WGPURenderBundleEncoder left, WGPURenderBundleEncoder right) => left.Handle != right.Handle;
	public static bool operator ==(WGPURenderBundleEncoder left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPURenderBundleEncoder left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPURenderBundleEncoder h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPURenderBundleEncoder h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPURenderPassEncoder : IEquatable<WGPURenderPassEncoder>
	{
	public readonly IntPtr Handle;
	public WGPURenderPassEncoder(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPURenderPassEncoder Null => new WGPURenderPassEncoder(IntPtr.Zero);
	public static implicit operator WGPURenderPassEncoder(IntPtr handle) => new WGPURenderPassEncoder(handle);
	public static bool operator ==(WGPURenderPassEncoder left, WGPURenderPassEncoder right) => left.Handle == right.Handle;
	public static bool operator !=(WGPURenderPassEncoder left, WGPURenderPassEncoder right) => left.Handle != right.Handle;
	public static bool operator ==(WGPURenderPassEncoder left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPURenderPassEncoder left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPURenderPassEncoder h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPURenderPassEncoder h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPURenderPipeline : IEquatable<WGPURenderPipeline>
	{
	public readonly IntPtr Handle;
	public WGPURenderPipeline(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPURenderPipeline Null => new WGPURenderPipeline(IntPtr.Zero);
	public static implicit operator WGPURenderPipeline(IntPtr handle) => new WGPURenderPipeline(handle);
	public static bool operator ==(WGPURenderPipeline left, WGPURenderPipeline right) => left.Handle == right.Handle;
	public static bool operator !=(WGPURenderPipeline left, WGPURenderPipeline right) => left.Handle != right.Handle;
	public static bool operator ==(WGPURenderPipeline left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPURenderPipeline left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPURenderPipeline h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPURenderPipeline h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPUSampler : IEquatable<WGPUSampler>
	{
	public readonly IntPtr Handle;
	public WGPUSampler(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPUSampler Null => new WGPUSampler(IntPtr.Zero);
	public static implicit operator WGPUSampler(IntPtr handle) => new WGPUSampler(handle);
	public static bool operator ==(WGPUSampler left, WGPUSampler right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUSampler left, WGPUSampler right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUSampler left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPUSampler left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPUSampler h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPUSampler h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPUShaderModule : IEquatable<WGPUShaderModule>
	{
	public readonly IntPtr Handle;
	public WGPUShaderModule(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPUShaderModule Null => new WGPUShaderModule(IntPtr.Zero);
	public static implicit operator WGPUShaderModule(IntPtr handle) => new WGPUShaderModule(handle);
	public static bool operator ==(WGPUShaderModule left, WGPUShaderModule right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUShaderModule left, WGPUShaderModule right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUShaderModule left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPUShaderModule left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPUShaderModule h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPUShaderModule h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPUSurface : IEquatable<WGPUSurface>
	{
	public readonly IntPtr Handle;
	public WGPUSurface(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPUSurface Null => new WGPUSurface(IntPtr.Zero);
	public static implicit operator WGPUSurface(IntPtr handle) => new WGPUSurface(handle);
	public static bool operator ==(WGPUSurface left, WGPUSurface right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUSurface left, WGPUSurface right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUSurface left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPUSurface left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPUSurface h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPUSurface h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPUTexture : IEquatable<WGPUTexture>
	{
	public readonly IntPtr Handle;
	public WGPUTexture(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPUTexture Null => new WGPUTexture(IntPtr.Zero);
	public static implicit operator WGPUTexture(IntPtr handle) => new WGPUTexture(handle);
	public static bool operator ==(WGPUTexture left, WGPUTexture right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUTexture left, WGPUTexture right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUTexture left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPUTexture left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPUTexture h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPUTexture h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct WGPUTextureView : IEquatable<WGPUTextureView>
	{
	public readonly IntPtr Handle;
	public WGPUTextureView(IntPtr existingHandle) { Handle = existingHandle; }
	public static WGPUTextureView Null => new WGPUTextureView(IntPtr.Zero);
	public static implicit operator WGPUTextureView(IntPtr handle) => new WGPUTextureView(handle);
	public static bool operator ==(WGPUTextureView left, WGPUTextureView right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUTextureView left, WGPUTextureView right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUTextureView left, IntPtr right) => left.Handle == right;
	public static bool operator !=(WGPUTextureView left, IntPtr right) => left.Handle != right;
	public bool Equals(WGPUTextureView h) => Handle == h.Handle;
	public override bool Equals(object o) => o is WGPUTextureView h && Equals(h);
	public override int GetHashCode() => Handle.GetHashCode();
	}

}
