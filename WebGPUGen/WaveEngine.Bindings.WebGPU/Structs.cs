using System;
using System.Runtime.InteropServices;

namespace WaveEngine.Bindings.WebGPU
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUAdapterImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBindGroupImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBindGroupLayoutImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBufferImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUCommandBufferImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUCommandEncoderImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUComputePassEncoderImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUComputePipelineImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUDeviceImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUFenceImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUInstanceImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUPipelineLayoutImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUQuerySetImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUQueueImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURenderBundleImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURenderBundleEncoderImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURenderPassEncoderImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURenderPipelineImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSamplerImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUShaderModuleImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSurfaceImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSwapChainImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUTextureImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUTextureViewImpl
	{
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUChainedStruct
	{
		public WGPUChainedStruct* next;
		public WGPUSType sType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUAdapterProperties
	{
		public WGPUChainedStruct* nextInChain;
		public uint deviceID;
		public uint vendorID;
		public char* name;
		public WGPUAdapterType adapterType;
		public WGPUBackendType backendType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBindGroupEntry
	{
		public uint binding;
		public WGPUBuffer buffer;
		public ulong offset;
		public ulong size;
		public WGPUSampler sampler;
		public WGPUTextureView textureView;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBindGroupLayoutEntry
	{
		public uint binding;
		public WGPUShaderStageFlags visibility;
		public WGPUBindingType type;
		public bool hasDynamicOffset;
		public bool multisampled;
		public WGPUTextureViewDimension viewDimension;
		public WGPUTextureComponentType textureComponentType;
		public WGPUTextureFormat storageTextureFormat;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBlendDescriptor
	{
		public WGPUBlendOperation operation;
		public WGPUBlendFactor srcFactor;
		public WGPUBlendFactor dstFactor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBufferDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
		public WGPUBufferUsageFlags usage;
		public ulong size;
		public bool mappedAtCreation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUColor
	{
		public float r;
		public float g;
		public float b;
		public float a;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUCommandBufferDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUCommandEncoderDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUComputePassDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUDeviceDescriptor
	{
		public WGPUChainedStruct* nextInChain;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUExtent3D
	{
		public uint width;
		public uint height;
		public uint depth;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUFenceDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
		public ulong initialValue;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUInstanceDescriptor
	{
		public WGPUChainedStruct* nextInChain;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUOrigin3D
	{
		public uint x;
		public uint y;
		public uint z;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUPipelineLayoutDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
		public uint bindGroupLayoutCount;
		public WGPUBindGroupLayout* bindGroupLayouts;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUProgrammableStageDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUShaderModule module;
		public char* entryPoint;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUQuerySetDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
		public WGPUQueryType type;
		public uint count;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURasterizationStateDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUFrontFace frontFace;
		public WGPUCullMode cullMode;
		public int depthBias;
		public float depthBiasSlopeScale;
		public float depthBiasClamp;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURenderBundleDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURenderBundleEncoderDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
		public uint colorFormatsCount;
		public WGPUTextureFormat* colorFormats;
		public WGPUTextureFormat depthStencilFormat;
		public uint sampleCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURenderPassDepthStencilAttachmentDescriptor
	{
		public WGPUTextureView attachment;
		public WGPULoadOp depthLoadOp;
		public WGPUStoreOp depthStoreOp;
		public float clearDepth;
		public bool depthReadOnly;
		public WGPULoadOp stencilLoadOp;
		public WGPUStoreOp stencilStoreOp;
		public uint clearStencil;
		public bool stencilReadOnly;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURequestAdapterOptions
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUSurface compatibleSurface;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSamplerDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
		public WGPUAddressMode addressModeU;
		public WGPUAddressMode addressModeV;
		public WGPUAddressMode addressModeW;
		public WGPUFilterMode magFilter;
		public WGPUFilterMode minFilter;
		public WGPUFilterMode mipmapFilter;
		public float lodMinClamp;
		public float lodMaxClamp;
		public WGPUCompareFunction compare;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUShaderModuleDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUShaderModuleSPIRVDescriptor
	{
		public WGPUChainedStruct chain;
		public uint codeSize;
		public uint* code;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUShaderModuleWGSLDescriptor
	{
		public WGPUChainedStruct chain;
		public char* source;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUStencilStateFaceDescriptor
	{
		public WGPUCompareFunction compare;
		public WGPUStencilOperation failOp;
		public WGPUStencilOperation depthFailOp;
		public WGPUStencilOperation passOp;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSurfaceDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSurfaceDescriptorFromHTMLCanvasId
	{
		public WGPUChainedStruct chain;
		public char* id;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSurfaceDescriptorFromMetalLayer
	{
		public WGPUChainedStruct chain;
		public void* layer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSurfaceDescriptorFromWindowsHWND
	{
		public WGPUChainedStruct chain;
		public void* hinstance;
		public void* hwnd;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSurfaceDescriptorFromXlib
	{
		public WGPUChainedStruct chain;
		public void* display;
		public uint window;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSwapChainDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
		public WGPUTextureUsageFlags usage;
		public WGPUTextureFormat format;
		public uint width;
		public uint height;
		public WGPUPresentMode presentMode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUTextureDataLayout
	{
		public WGPUChainedStruct* nextInChain;
		public ulong offset;
		public uint bytesPerRow;
		public uint rowsPerImage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUTextureViewDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
		public WGPUTextureFormat format;
		public WGPUTextureViewDimension dimension;
		public uint baseMipLevel;
		public uint mipLevelCount;
		public uint baseArrayLayer;
		public uint arrayLayerCount;
		public WGPUTextureAspect aspect;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUVertexAttributeDescriptor
	{
		public WGPUVertexFormat format;
		public ulong offset;
		public uint shaderLocation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBindGroupDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
		public WGPUBindGroupLayout layout;
		public uint entryCount;
		public WGPUBindGroupEntry* entries;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBindGroupLayoutDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
		public uint entryCount;
		public WGPUBindGroupLayoutEntry* entries;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBufferCopyView
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUTextureDataLayout layout;
		public WGPUBuffer buffer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUColorStateDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUTextureFormat format;
		public WGPUBlendDescriptor alphaBlend;
		public WGPUBlendDescriptor colorBlend;
		public WGPUColorWriteMaskFlags writeMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUComputePipelineDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
		public WGPUPipelineLayout layout;
		public WGPUProgrammableStageDescriptor computeStage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUDepthStencilStateDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUTextureFormat format;
		public bool depthWriteEnabled;
		public WGPUCompareFunction depthCompare;
		public WGPUStencilStateFaceDescriptor stencilFront;
		public WGPUStencilStateFaceDescriptor stencilBack;
		public uint stencilReadMask;
		public uint stencilWriteMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURenderPassColorAttachmentDescriptor
	{
		public WGPUTextureView attachment;
		public WGPUTextureView resolveTarget;
		public WGPULoadOp loadOp;
		public WGPUStoreOp storeOp;
		public WGPUColor clearColor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUTextureCopyView
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUTexture texture;
		public uint mipLevel;
		public WGPUOrigin3D origin;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUTextureDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
		public WGPUTextureUsageFlags usage;
		public WGPUTextureDimension dimension;
		public WGPUExtent3D size;
		public WGPUTextureFormat format;
		public uint mipLevelCount;
		public uint sampleCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUVertexBufferLayoutDescriptor
	{
		public ulong arrayStride;
		public WGPUInputStepMode stepMode;
		public uint attributeCount;
		public WGPUVertexAttributeDescriptor* attributes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURenderPassDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
		public uint colorAttachmentCount;
		public WGPURenderPassColorAttachmentDescriptor* colorAttachments;
		public WGPURenderPassDepthStencilAttachmentDescriptor* depthStencilAttachment;
		public WGPUQuerySet occlusionQuerySet;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUVertexStateDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUIndexFormat indexFormat;
		public uint vertexBufferCount;
		public WGPUVertexBufferLayoutDescriptor* vertexBuffers;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURenderPipelineDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
		public WGPUPipelineLayout layout;
		public WGPUProgrammableStageDescriptor vertexStage;
		public WGPUProgrammableStageDescriptor* fragmentStage;
		public WGPUVertexStateDescriptor* vertexState;
		public WGPUPrimitiveTopology primitiveTopology;
		public WGPURasterizationStateDescriptor* rasterizationState;
		public uint sampleCount;
		public WGPUDepthStencilStateDescriptor* depthStencilState;
		public uint colorStateCount;
		public WGPUColorStateDescriptor* colorStates;
		public uint sampleMask;
		public bool alphaToCoverageEnabled;
	}

}

