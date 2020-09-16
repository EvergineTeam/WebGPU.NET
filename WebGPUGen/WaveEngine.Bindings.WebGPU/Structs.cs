using System;
using System.Runtime.InteropServices;

namespace WaveEngine.Bindings.WebGPU
{
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
		public IntPtr buffer;
		public ulong offset;
		public ulong size;
		public IntPtr sampler;
		public IntPtr textureView;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBindGroupLayoutEntry
	{
		public uint binding;
		public WGPUShaderStage visibility;
		public WGPUBindingType type;
		[MarshalAs(UnmanagedType.I1)]
		public bool hasDynamicOffset;
		public ulong minBufferBindingSize;
		[MarshalAs(UnmanagedType.I1)]
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
		public WGPUBufferUsage usage;
		public ulong size;
		[MarshalAs(UnmanagedType.I1)]
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
	public unsafe struct WGPUCreateBufferMappedResult
	{
		public IntPtr buffer;
		public ulong dataLength;
		public void* data;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUDeviceProperties
	{
		[MarshalAs(UnmanagedType.I1)]
		public bool textureCompressionBC;
		[MarshalAs(UnmanagedType.I1)]
		public bool shaderFloat16;
		[MarshalAs(UnmanagedType.I1)]
		public bool pipelineStatisticsQuery;
		[MarshalAs(UnmanagedType.I1)]
		public bool timestampQuery;
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
		public IntPtr* bindGroupLayouts;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUProgrammableStageDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public IntPtr module;
		public char* entryPoint;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUQuerySetDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
		public WGPUQueryType type;
		public uint count;
		public WGPUPipelineStatisticName* pipelineStatistics;
		public uint pipelineStatisticsCount;
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
		public IntPtr attachment;
		public WGPULoadOp depthLoadOp;
		public WGPUStoreOp depthStoreOp;
		public float clearDepth;
		[MarshalAs(UnmanagedType.I1)]
		public bool depthReadOnly;
		public WGPULoadOp stencilLoadOp;
		public WGPUStoreOp stencilStoreOp;
		public uint clearStencil;
		[MarshalAs(UnmanagedType.I1)]
		public bool stencilReadOnly;
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
	public unsafe struct WGPUSamplerDescriptorDummyAnisotropicFiltering
	{
		public WGPUChainedStruct chain;
		public float maxAnisotropy;
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
	public unsafe struct WGPUSurfaceDescriptorFromCanvasHTMLSelector
	{
		public WGPUChainedStruct chain;
		public char* selector;
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
		public WGPUTextureUsage usage;
		public WGPUTextureFormat format;
		public uint width;
		public uint height;
		public WGPUPresentMode presentMode;
		public ulong implementation;
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
		public IntPtr layout;
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
		public IntPtr buffer;
		public ulong offset;
		public uint bytesPerRow;
		public uint rowsPerImage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUColorStateDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUTextureFormat format;
		public WGPUBlendDescriptor alphaBlend;
		public WGPUBlendDescriptor colorBlend;
		public WGPUColorWriteMask writeMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUComputePipelineDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
		public IntPtr layout;
		public WGPUProgrammableStageDescriptor computeStage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUDepthStencilStateDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUTextureFormat format;
		[MarshalAs(UnmanagedType.I1)]
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
		public IntPtr attachment;
		public IntPtr resolveTarget;
		public WGPULoadOp loadOp;
		public WGPUStoreOp storeOp;
		public WGPUColor clearColor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURenderPipelineDescriptorDummyExtension
	{
		public WGPUChainedStruct chain;
		public WGPUProgrammableStageDescriptor dummyStage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUTextureCopyView
	{
		public WGPUChainedStruct* nextInChain;
		public IntPtr texture;
		public uint mipLevel;
		public uint arrayLayer;
		public WGPUOrigin3D origin;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUTextureDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public char* label;
		public WGPUTextureUsage usage;
		public WGPUTextureDimension dimension;
		public WGPUExtent3D size;
		public uint arrayLayerCount;
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
		public IntPtr occlusionQuerySet;
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
		public IntPtr layout;
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
		[MarshalAs(UnmanagedType.I1)]
		public bool alphaToCoverageEnabled;
	}

}

