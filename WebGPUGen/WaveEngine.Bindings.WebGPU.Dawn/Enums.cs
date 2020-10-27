using System;

namespace WaveEngine.Bindings.WebGPU
{
	public enum WGPUAdapterType
	{
		WGPUAdapterType_DiscreteGPU = 0,
		WGPUAdapterType_IntegratedGPU = 1,
		WGPUAdapterType_CPU = 2,
		WGPUAdapterType_Unknown = 3,
		WGPUAdapterType_Force32 = 2147483647,
	}

	public enum WGPUAddressMode
	{
		WGPUAddressMode_Repeat = 0,
		WGPUAddressMode_MirrorRepeat = 1,
		WGPUAddressMode_ClampToEdge = 2,
		WGPUAddressMode_Force32 = 2147483647,
	}

	public enum WGPUBackendType
	{
		WGPUBackendType_Null = 0,
		WGPUBackendType_D3D11 = 1,
		WGPUBackendType_D3D12 = 2,
		WGPUBackendType_Metal = 3,
		WGPUBackendType_Vulkan = 4,
		WGPUBackendType_OpenGL = 5,
		WGPUBackendType_OpenGLES = 6,
		WGPUBackendType_Force32 = 2147483647,
	}

	public enum WGPUBindingType
	{
		WGPUBindingType_UniformBuffer = 0,
		WGPUBindingType_StorageBuffer = 1,
		WGPUBindingType_ReadonlyStorageBuffer = 2,
		WGPUBindingType_Sampler = 3,
		WGPUBindingType_ComparisonSampler = 4,
		WGPUBindingType_SampledTexture = 5,
		WGPUBindingType_MultisampledTexture = 6,
		WGPUBindingType_ReadonlyStorageTexture = 7,
		WGPUBindingType_WriteonlyStorageTexture = 8,
		WGPUBindingType_Force32 = 2147483647,
	}

	public enum WGPUBlendFactor
	{
		WGPUBlendFactor_Zero = 0,
		WGPUBlendFactor_One = 1,
		WGPUBlendFactor_SrcColor = 2,
		WGPUBlendFactor_OneMinusSrcColor = 3,
		WGPUBlendFactor_SrcAlpha = 4,
		WGPUBlendFactor_OneMinusSrcAlpha = 5,
		WGPUBlendFactor_DstColor = 6,
		WGPUBlendFactor_OneMinusDstColor = 7,
		WGPUBlendFactor_DstAlpha = 8,
		WGPUBlendFactor_OneMinusDstAlpha = 9,
		WGPUBlendFactor_SrcAlphaSaturated = 10,
		WGPUBlendFactor_BlendColor = 11,
		WGPUBlendFactor_OneMinusBlendColor = 12,
		WGPUBlendFactor_Force32 = 2147483647,
	}

	public enum WGPUBlendOperation
	{
		WGPUBlendOperation_Add = 0,
		WGPUBlendOperation_Subtract = 1,
		WGPUBlendOperation_ReverseSubtract = 2,
		WGPUBlendOperation_Min = 3,
		WGPUBlendOperation_Max = 4,
		WGPUBlendOperation_Force32 = 2147483647,
	}

	public enum WGPUBufferMapAsyncStatus
	{
		WGPUBufferMapAsyncStatus_Success = 0,
		WGPUBufferMapAsyncStatus_Error = 1,
		WGPUBufferMapAsyncStatus_Unknown = 2,
		WGPUBufferMapAsyncStatus_DeviceLost = 3,
		WGPUBufferMapAsyncStatus_DestroyedBeforeCallback = 4,
		WGPUBufferMapAsyncStatus_UnmappedBeforeCallback = 5,
		WGPUBufferMapAsyncStatus_Force32 = 2147483647,
	}

	public enum WGPUCompareFunction
	{
		WGPUCompareFunction_Undefined = 0,
		WGPUCompareFunction_Never = 1,
		WGPUCompareFunction_Less = 2,
		WGPUCompareFunction_LessEqual = 3,
		WGPUCompareFunction_Greater = 4,
		WGPUCompareFunction_GreaterEqual = 5,
		WGPUCompareFunction_Equal = 6,
		WGPUCompareFunction_NotEqual = 7,
		WGPUCompareFunction_Always = 8,
		WGPUCompareFunction_Force32 = 2147483647,
	}

	public enum WGPUCullMode
	{
		WGPUCullMode_None = 0,
		WGPUCullMode_Front = 1,
		WGPUCullMode_Back = 2,
		WGPUCullMode_Force32 = 2147483647,
	}

	public enum WGPUErrorFilter
	{
		WGPUErrorFilter_None = 0,
		WGPUErrorFilter_Validation = 1,
		WGPUErrorFilter_OutOfMemory = 2,
		WGPUErrorFilter_Force32 = 2147483647,
	}

	public enum WGPUErrorType
	{
		WGPUErrorType_NoError = 0,
		WGPUErrorType_Validation = 1,
		WGPUErrorType_OutOfMemory = 2,
		WGPUErrorType_Unknown = 3,
		WGPUErrorType_DeviceLost = 4,
		WGPUErrorType_Force32 = 2147483647,
	}

	public enum WGPUFenceCompletionStatus
	{
		WGPUFenceCompletionStatus_Success = 0,
		WGPUFenceCompletionStatus_Error = 1,
		WGPUFenceCompletionStatus_Unknown = 2,
		WGPUFenceCompletionStatus_DeviceLost = 3,
		WGPUFenceCompletionStatus_Force32 = 2147483647,
	}

	public enum WGPUFilterMode
	{
		WGPUFilterMode_Nearest = 0,
		WGPUFilterMode_Linear = 1,
		WGPUFilterMode_Force32 = 2147483647,
	}

	public enum WGPUFrontFace
	{
		WGPUFrontFace_CCW = 0,
		WGPUFrontFace_CW = 1,
		WGPUFrontFace_Force32 = 2147483647,
	}

	public enum WGPUIndexFormat
	{
		WGPUIndexFormat_Undefined = 0,
		WGPUIndexFormat_Uint16 = 1,
		WGPUIndexFormat_Uint32 = 2,
		WGPUIndexFormat_Force32 = 2147483647,
	}

	public enum WGPUInputStepMode
	{
		WGPUInputStepMode_Vertex = 0,
		WGPUInputStepMode_Instance = 1,
		WGPUInputStepMode_Force32 = 2147483647,
	}

	public enum WGPULoadOp
	{
		WGPULoadOp_Clear = 0,
		WGPULoadOp_Load = 1,
		WGPULoadOp_Force32 = 2147483647,
	}

	public enum WGPUPipelineStatisticName
	{
		WGPUPipelineStatisticName_VertexShaderInvocations = 0,
		WGPUPipelineStatisticName_ClipperInvocations = 1,
		WGPUPipelineStatisticName_ClipperPrimitivesOut = 2,
		WGPUPipelineStatisticName_FragmentShaderInvocations = 3,
		WGPUPipelineStatisticName_ComputeShaderInvocations = 4,
		WGPUPipelineStatisticName_Force32 = 2147483647,
	}

	public enum WGPUPresentMode
	{
		WGPUPresentMode_Immediate = 0,
		WGPUPresentMode_Mailbox = 1,
		WGPUPresentMode_Fifo = 2,
		WGPUPresentMode_Force32 = 2147483647,
	}

	public enum WGPUPrimitiveTopology
	{
		WGPUPrimitiveTopology_PointList = 0,
		WGPUPrimitiveTopology_LineList = 1,
		WGPUPrimitiveTopology_LineStrip = 2,
		WGPUPrimitiveTopology_TriangleList = 3,
		WGPUPrimitiveTopology_TriangleStrip = 4,
		WGPUPrimitiveTopology_Force32 = 2147483647,
	}

	public enum WGPUQueryType
	{
		WGPUQueryType_Occlusion = 0,
		WGPUQueryType_PipelineStatistics = 1,
		WGPUQueryType_Timestamp = 2,
		WGPUQueryType_Force32 = 2147483647,
	}

	public enum WGPUSType
	{
		WGPUSType_Invalid = 0,
		WGPUSType_SurfaceDescriptorFromMetalLayer = 1,
		WGPUSType_SurfaceDescriptorFromWindowsHWND = 2,
		WGPUSType_SurfaceDescriptorFromXlib = 3,
		WGPUSType_SurfaceDescriptorFromCanvasHTMLSelector = 4,
		WGPUSType_ShaderModuleSPIRVDescriptor = 5,
		WGPUSType_ShaderModuleWGSLDescriptor = 6,
		WGPUSType_SamplerDescriptorDummyAnisotropicFiltering = 7,
		WGPUSType_RenderPipelineDescriptorDummyExtension = 8,
		WGPUSType_Force32 = 2147483647,
	}

	public enum WGPUStencilOperation
	{
		WGPUStencilOperation_Keep = 0,
		WGPUStencilOperation_Zero = 1,
		WGPUStencilOperation_Replace = 2,
		WGPUStencilOperation_Invert = 3,
		WGPUStencilOperation_IncrementClamp = 4,
		WGPUStencilOperation_DecrementClamp = 5,
		WGPUStencilOperation_IncrementWrap = 6,
		WGPUStencilOperation_DecrementWrap = 7,
		WGPUStencilOperation_Force32 = 2147483647,
	}

	public enum WGPUStoreOp
	{
		WGPUStoreOp_Store = 0,
		WGPUStoreOp_Clear = 1,
		WGPUStoreOp_Force32 = 2147483647,
	}

	public enum WGPUTextureAspect
	{
		WGPUTextureAspect_All = 0,
		WGPUTextureAspect_StencilOnly = 1,
		WGPUTextureAspect_DepthOnly = 2,
		WGPUTextureAspect_Force32 = 2147483647,
	}

	public enum WGPUTextureComponentType
	{
		WGPUTextureComponentType_Float = 0,
		WGPUTextureComponentType_Sint = 1,
		WGPUTextureComponentType_Uint = 2,
		WGPUTextureComponentType_Force32 = 2147483647,
	}

	public enum WGPUTextureDimension
	{
		WGPUTextureDimension_1D = 0,
		WGPUTextureDimension_2D = 1,
		WGPUTextureDimension_3D = 2,
		WGPUTextureDimension_Force32 = 2147483647,
	}

	public enum WGPUTextureFormat
	{
		WGPUTextureFormat_Undefined = 0,
		WGPUTextureFormat_R8Unorm = 1,
		WGPUTextureFormat_R8Snorm = 2,
		WGPUTextureFormat_R8Uint = 3,
		WGPUTextureFormat_R8Sint = 4,
		WGPUTextureFormat_R16Uint = 5,
		WGPUTextureFormat_R16Sint = 6,
		WGPUTextureFormat_R16Float = 7,
		WGPUTextureFormat_RG8Unorm = 8,
		WGPUTextureFormat_RG8Snorm = 9,
		WGPUTextureFormat_RG8Uint = 10,
		WGPUTextureFormat_RG8Sint = 11,
		WGPUTextureFormat_R32Float = 12,
		WGPUTextureFormat_R32Uint = 13,
		WGPUTextureFormat_R32Sint = 14,
		WGPUTextureFormat_RG16Uint = 15,
		WGPUTextureFormat_RG16Sint = 16,
		WGPUTextureFormat_RG16Float = 17,
		WGPUTextureFormat_RGBA8Unorm = 18,
		WGPUTextureFormat_RGBA8UnormSrgb = 19,
		WGPUTextureFormat_RGBA8Snorm = 20,
		WGPUTextureFormat_RGBA8Uint = 21,
		WGPUTextureFormat_RGBA8Sint = 22,
		WGPUTextureFormat_BGRA8Unorm = 23,
		WGPUTextureFormat_BGRA8UnormSrgb = 24,
		WGPUTextureFormat_RGB10A2Unorm = 25,
		WGPUTextureFormat_RG11B10Ufloat = 26,
		WGPUTextureFormat_RGB9E5Ufloat = 27,
		WGPUTextureFormat_RG32Float = 28,
		WGPUTextureFormat_RG32Uint = 29,
		WGPUTextureFormat_RG32Sint = 30,
		WGPUTextureFormat_RGBA16Uint = 31,
		WGPUTextureFormat_RGBA16Sint = 32,
		WGPUTextureFormat_RGBA16Float = 33,
		WGPUTextureFormat_RGBA32Float = 34,
		WGPUTextureFormat_RGBA32Uint = 35,
		WGPUTextureFormat_RGBA32Sint = 36,
		WGPUTextureFormat_Depth32Float = 37,
		WGPUTextureFormat_Depth24Plus = 38,
		WGPUTextureFormat_Depth24PlusStencil8 = 39,
		WGPUTextureFormat_BC1RGBAUnorm = 40,
		WGPUTextureFormat_BC1RGBAUnormSrgb = 41,
		WGPUTextureFormat_BC2RGBAUnorm = 42,
		WGPUTextureFormat_BC2RGBAUnormSrgb = 43,
		WGPUTextureFormat_BC3RGBAUnorm = 44,
		WGPUTextureFormat_BC3RGBAUnormSrgb = 45,
		WGPUTextureFormat_BC4RUnorm = 46,
		WGPUTextureFormat_BC4RSnorm = 47,
		WGPUTextureFormat_BC5RGUnorm = 48,
		WGPUTextureFormat_BC5RGSnorm = 49,
		WGPUTextureFormat_BC6HRGBUfloat = 50,
		WGPUTextureFormat_BC6HRGBFloat = 51,
		WGPUTextureFormat_BC7RGBAUnorm = 52,
		WGPUTextureFormat_BC7RGBAUnormSrgb = 53,
		WGPUTextureFormat_Force32 = 2147483647,
	}

	public enum WGPUTextureViewDimension
	{
		WGPUTextureViewDimension_Undefined = 0,
		WGPUTextureViewDimension_1D = 1,
		WGPUTextureViewDimension_2D = 2,
		WGPUTextureViewDimension_2DArray = 3,
		WGPUTextureViewDimension_Cube = 4,
		WGPUTextureViewDimension_CubeArray = 5,
		WGPUTextureViewDimension_3D = 6,
		WGPUTextureViewDimension_Force32 = 2147483647,
	}

	public enum WGPUVertexFormat
	{
		WGPUVertexFormat_UChar2 = 0,
		WGPUVertexFormat_UChar4 = 1,
		WGPUVertexFormat_Char2 = 2,
		WGPUVertexFormat_Char4 = 3,
		WGPUVertexFormat_UChar2Norm = 4,
		WGPUVertexFormat_UChar4Norm = 5,
		WGPUVertexFormat_Char2Norm = 6,
		WGPUVertexFormat_Char4Norm = 7,
		WGPUVertexFormat_UShort2 = 8,
		WGPUVertexFormat_UShort4 = 9,
		WGPUVertexFormat_Short2 = 10,
		WGPUVertexFormat_Short4 = 11,
		WGPUVertexFormat_UShort2Norm = 12,
		WGPUVertexFormat_UShort4Norm = 13,
		WGPUVertexFormat_Short2Norm = 14,
		WGPUVertexFormat_Short4Norm = 15,
		WGPUVertexFormat_Half2 = 16,
		WGPUVertexFormat_Half4 = 17,
		WGPUVertexFormat_Float = 18,
		WGPUVertexFormat_Float2 = 19,
		WGPUVertexFormat_Float3 = 20,
		WGPUVertexFormat_Float4 = 21,
		WGPUVertexFormat_UInt = 22,
		WGPUVertexFormat_UInt2 = 23,
		WGPUVertexFormat_UInt3 = 24,
		WGPUVertexFormat_UInt4 = 25,
		WGPUVertexFormat_Int = 26,
		WGPUVertexFormat_Int2 = 27,
		WGPUVertexFormat_Int3 = 28,
		WGPUVertexFormat_Int4 = 29,
		WGPUVertexFormat_Force32 = 2147483647,
	}

	[Flags]
	public enum WGPUBufferUsage
	{
		WGPUBufferUsage_None = 0,
		WGPUBufferUsage_MapRead = 1,
		WGPUBufferUsage_MapWrite = 2,
		WGPUBufferUsage_CopySrc = 4,
		WGPUBufferUsage_CopyDst = 8,
		WGPUBufferUsage_Index = 16,
		WGPUBufferUsage_Vertex = 32,
		WGPUBufferUsage_Uniform = 64,
		WGPUBufferUsage_Storage = 128,
		WGPUBufferUsage_Indirect = 256,
		WGPUBufferUsage_QueryResolve = 512,
		WGPUBufferUsage_Force32 = 2147483647,
	}

	[Flags]
	public enum WGPUColorWriteMask
	{
		WGPUColorWriteMask_None = 0,
		WGPUColorWriteMask_Red = 1,
		WGPUColorWriteMask_Green = 2,
		WGPUColorWriteMask_Blue = 4,
		WGPUColorWriteMask_Alpha = 8,
		WGPUColorWriteMask_All = 15,
		WGPUColorWriteMask_Force32 = 2147483647,
	}

	[Flags]
	public enum WGPUMapMode
	{
		WGPUMapMode_None = 0,
		WGPUMapMode_Read = 1,
		WGPUMapMode_Write = 2,
		WGPUMapMode_Force32 = 2147483647,
	}

	[Flags]
	public enum WGPUShaderStage
	{
		WGPUShaderStage_None = 0,
		WGPUShaderStage_Vertex = 1,
		WGPUShaderStage_Fragment = 2,
		WGPUShaderStage_Compute = 4,
		WGPUShaderStage_Force32 = 2147483647,
	}

	[Flags]
	public enum WGPUTextureUsage
	{
		WGPUTextureUsage_None = 0,
		WGPUTextureUsage_CopySrc = 1,
		WGPUTextureUsage_CopyDst = 2,
		WGPUTextureUsage_Sampled = 4,
		WGPUTextureUsage_Storage = 8,
		WGPUTextureUsage_OutputAttachment = 16,
		WGPUTextureUsage_Present = 32,
		WGPUTextureUsage_Force32 = 2147483647,
	}

}
