using System;

namespace Evergine.Bindings.WebGPU
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
		WGPUBackendType_Undefined = 0,
		WGPUBackendType_Null = 1,
		WGPUBackendType_WebGPU = 2,
		WGPUBackendType_D3D11 = 3,
		WGPUBackendType_D3D12 = 4,
		WGPUBackendType_Metal = 5,
		WGPUBackendType_Vulkan = 6,
		WGPUBackendType_OpenGL = 7,
		WGPUBackendType_OpenGLES = 8,
		WGPUBackendType_Force32 = 2147483647,
	}

	public enum WGPUBlendFactor
	{
		WGPUBlendFactor_Zero = 0,
		WGPUBlendFactor_One = 1,
		WGPUBlendFactor_Src = 2,
		WGPUBlendFactor_OneMinusSrc = 3,
		WGPUBlendFactor_SrcAlpha = 4,
		WGPUBlendFactor_OneMinusSrcAlpha = 5,
		WGPUBlendFactor_Dst = 6,
		WGPUBlendFactor_OneMinusDst = 7,
		WGPUBlendFactor_DstAlpha = 8,
		WGPUBlendFactor_OneMinusDstAlpha = 9,
		WGPUBlendFactor_SrcAlphaSaturated = 10,
		WGPUBlendFactor_Constant = 11,
		WGPUBlendFactor_OneMinusConstant = 12,
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

	public enum WGPUBufferBindingType
	{
		WGPUBufferBindingType_Undefined = 0,
		WGPUBufferBindingType_Uniform = 1,
		WGPUBufferBindingType_Storage = 2,
		WGPUBufferBindingType_ReadOnlyStorage = 3,
		WGPUBufferBindingType_Force32 = 2147483647,
	}

	public enum WGPUBufferMapAsyncStatus
	{
		WGPUBufferMapAsyncStatus_Success = 0,
		WGPUBufferMapAsyncStatus_ValidationError = 1,
		WGPUBufferMapAsyncStatus_Unknown = 2,
		WGPUBufferMapAsyncStatus_DeviceLost = 3,
		WGPUBufferMapAsyncStatus_DestroyedBeforeCallback = 4,
		WGPUBufferMapAsyncStatus_UnmappedBeforeCallback = 5,
		WGPUBufferMapAsyncStatus_MappingAlreadyPending = 6,
		WGPUBufferMapAsyncStatus_OffsetOutOfRange = 7,
		WGPUBufferMapAsyncStatus_SizeOutOfRange = 8,
		WGPUBufferMapAsyncStatus_Force32 = 2147483647,
	}

	public enum WGPUBufferMapState
	{
		WGPUBufferMapState_Unmapped = 0,
		WGPUBufferMapState_Pending = 1,
		WGPUBufferMapState_Mapped = 2,
		WGPUBufferMapState_Force32 = 2147483647,
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

	public enum WGPUCompilationInfoRequestStatus
	{
		WGPUCompilationInfoRequestStatus_Success = 0,
		WGPUCompilationInfoRequestStatus_Error = 1,
		WGPUCompilationInfoRequestStatus_DeviceLost = 2,
		WGPUCompilationInfoRequestStatus_Unknown = 3,
		WGPUCompilationInfoRequestStatus_Force32 = 2147483647,
	}

	public enum WGPUCompilationMessageType
	{
		WGPUCompilationMessageType_Error = 0,
		WGPUCompilationMessageType_Warning = 1,
		WGPUCompilationMessageType_Info = 2,
		WGPUCompilationMessageType_Force32 = 2147483647,
	}

	public enum WGPUComputePassTimestampLocation
	{
		WGPUComputePassTimestampLocation_Beginning = 0,
		WGPUComputePassTimestampLocation_End = 1,
		WGPUComputePassTimestampLocation_Force32 = 2147483647,
	}

	public enum WGPUCreatePipelineAsyncStatus
	{
		WGPUCreatePipelineAsyncStatus_Success = 0,
		WGPUCreatePipelineAsyncStatus_ValidationError = 1,
		WGPUCreatePipelineAsyncStatus_InternalError = 2,
		WGPUCreatePipelineAsyncStatus_DeviceLost = 3,
		WGPUCreatePipelineAsyncStatus_DeviceDestroyed = 4,
		WGPUCreatePipelineAsyncStatus_Unknown = 5,
		WGPUCreatePipelineAsyncStatus_Force32 = 2147483647,
	}

	public enum WGPUCullMode
	{
		WGPUCullMode_None = 0,
		WGPUCullMode_Front = 1,
		WGPUCullMode_Back = 2,
		WGPUCullMode_Force32 = 2147483647,
	}

	public enum WGPUDeviceLostReason
	{
		WGPUDeviceLostReason_Undefined = 0,
		WGPUDeviceLostReason_Destroyed = 1,
		WGPUDeviceLostReason_Force32 = 2147483647,
	}

	public enum WGPUErrorFilter
	{
		WGPUErrorFilter_Validation = 0,
		WGPUErrorFilter_OutOfMemory = 1,
		WGPUErrorFilter_Internal = 2,
		WGPUErrorFilter_Force32 = 2147483647,
	}

	public enum WGPUErrorType
	{
		WGPUErrorType_NoError = 0,
		WGPUErrorType_Validation = 1,
		WGPUErrorType_OutOfMemory = 2,
		WGPUErrorType_Internal = 3,
		WGPUErrorType_Unknown = 4,
		WGPUErrorType_DeviceLost = 5,
		WGPUErrorType_Force32 = 2147483647,
	}

	public enum WGPUFeatureName
	{
		WGPUFeatureName_Undefined = 0,
		WGPUFeatureName_DepthClipControl = 1,
		WGPUFeatureName_Depth32FloatStencil8 = 2,
		WGPUFeatureName_TimestampQuery = 3,
		WGPUFeatureName_PipelineStatisticsQuery = 4,
		WGPUFeatureName_TextureCompressionBC = 5,
		WGPUFeatureName_TextureCompressionETC2 = 6,
		WGPUFeatureName_TextureCompressionASTC = 7,
		WGPUFeatureName_IndirectFirstInstance = 8,
		WGPUFeatureName_ShaderF16 = 9,
		WGPUFeatureName_RG11B10UfloatRenderable = 10,
		WGPUFeatureName_BGRA8UnormStorage = 11,
		WGPUFeatureName_Float32Filterable = 12,
		WGPUFeatureName_Force32 = 2147483647,
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

	public enum WGPULoadOp
	{
		WGPULoadOp_Undefined = 0,
		WGPULoadOp_Clear = 1,
		WGPULoadOp_Load = 2,
		WGPULoadOp_Force32 = 2147483647,
	}

	public enum WGPUMipmapFilterMode
	{
		WGPUMipmapFilterMode_Nearest = 0,
		WGPUMipmapFilterMode_Linear = 1,
		WGPUMipmapFilterMode_Force32 = 2147483647,
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

	public enum WGPUPowerPreference
	{
		WGPUPowerPreference_Undefined = 0,
		WGPUPowerPreference_LowPower = 1,
		WGPUPowerPreference_HighPerformance = 2,
		WGPUPowerPreference_Force32 = 2147483647,
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

	public enum WGPUQueueWorkDoneStatus
	{
		WGPUQueueWorkDoneStatus_Success = 0,
		WGPUQueueWorkDoneStatus_Error = 1,
		WGPUQueueWorkDoneStatus_Unknown = 2,
		WGPUQueueWorkDoneStatus_DeviceLost = 3,
		WGPUQueueWorkDoneStatus_Force32 = 2147483647,
	}

	public enum WGPURenderPassTimestampLocation
	{
		WGPURenderPassTimestampLocation_Beginning = 0,
		WGPURenderPassTimestampLocation_End = 1,
		WGPURenderPassTimestampLocation_Force32 = 2147483647,
	}

	public enum WGPURequestAdapterStatus
	{
		WGPURequestAdapterStatus_Success = 0,
		WGPURequestAdapterStatus_Unavailable = 1,
		WGPURequestAdapterStatus_Error = 2,
		WGPURequestAdapterStatus_Unknown = 3,
		WGPURequestAdapterStatus_Force32 = 2147483647,
	}

	public enum WGPURequestDeviceStatus
	{
		WGPURequestDeviceStatus_Success = 0,
		WGPURequestDeviceStatus_Error = 1,
		WGPURequestDeviceStatus_Unknown = 2,
		WGPURequestDeviceStatus_Force32 = 2147483647,
	}

	public enum WGPUSType
	{
		WGPUSType_Invalid = 0,
		WGPUSType_SurfaceDescriptorFromMetalLayer = 1,
		WGPUSType_SurfaceDescriptorFromWindowsHWND = 2,
		WGPUSType_SurfaceDescriptorFromXlibWindow = 3,
		WGPUSType_SurfaceDescriptorFromCanvasHTMLSelector = 4,
		WGPUSType_ShaderModuleSPIRVDescriptor = 5,
		WGPUSType_ShaderModuleWGSLDescriptor = 6,
		WGPUSType_PrimitiveDepthClipControl = 7,
		WGPUSType_SurfaceDescriptorFromWaylandSurface = 8,
		WGPUSType_SurfaceDescriptorFromAndroidNativeWindow = 9,
		WGPUSType_SurfaceDescriptorFromXcbWindow = 10,
		WGPUSType_RenderPassDescriptorMaxDrawCount = 15,
		WGPUSType_Force32 = 2147483647,
	}

	public enum WGPUSamplerBindingType
	{
		WGPUSamplerBindingType_Undefined = 0,
		WGPUSamplerBindingType_Filtering = 1,
		WGPUSamplerBindingType_NonFiltering = 2,
		WGPUSamplerBindingType_Comparison = 3,
		WGPUSamplerBindingType_Force32 = 2147483647,
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

	public enum WGPUStorageTextureAccess
	{
		WGPUStorageTextureAccess_Undefined = 0,
		WGPUStorageTextureAccess_WriteOnly = 1,
		WGPUStorageTextureAccess_Force32 = 2147483647,
	}

	public enum WGPUStoreOp
	{
		WGPUStoreOp_Undefined = 0,
		WGPUStoreOp_Store = 1,
		WGPUStoreOp_Discard = 2,
		WGPUStoreOp_Force32 = 2147483647,
	}

	public enum WGPUTextureAspect
	{
		WGPUTextureAspect_All = 0,
		WGPUTextureAspect_StencilOnly = 1,
		WGPUTextureAspect_DepthOnly = 2,
		WGPUTextureAspect_Force32 = 2147483647,
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
		WGPUTextureFormat_Stencil8 = 37,
		WGPUTextureFormat_Depth16Unorm = 38,
		WGPUTextureFormat_Depth24Plus = 39,
		WGPUTextureFormat_Depth24PlusStencil8 = 40,
		WGPUTextureFormat_Depth32Float = 41,
		WGPUTextureFormat_Depth32FloatStencil8 = 42,
		WGPUTextureFormat_BC1RGBAUnorm = 43,
		WGPUTextureFormat_BC1RGBAUnormSrgb = 44,
		WGPUTextureFormat_BC2RGBAUnorm = 45,
		WGPUTextureFormat_BC2RGBAUnormSrgb = 46,
		WGPUTextureFormat_BC3RGBAUnorm = 47,
		WGPUTextureFormat_BC3RGBAUnormSrgb = 48,
		WGPUTextureFormat_BC4RUnorm = 49,
		WGPUTextureFormat_BC4RSnorm = 50,
		WGPUTextureFormat_BC5RGUnorm = 51,
		WGPUTextureFormat_BC5RGSnorm = 52,
		WGPUTextureFormat_BC6HRGBUfloat = 53,
		WGPUTextureFormat_BC6HRGBFloat = 54,
		WGPUTextureFormat_BC7RGBAUnorm = 55,
		WGPUTextureFormat_BC7RGBAUnormSrgb = 56,
		WGPUTextureFormat_ETC2RGB8Unorm = 57,
		WGPUTextureFormat_ETC2RGB8UnormSrgb = 58,
		WGPUTextureFormat_ETC2RGB8A1Unorm = 59,
		WGPUTextureFormat_ETC2RGB8A1UnormSrgb = 60,
		WGPUTextureFormat_ETC2RGBA8Unorm = 61,
		WGPUTextureFormat_ETC2RGBA8UnormSrgb = 62,
		WGPUTextureFormat_EACR11Unorm = 63,
		WGPUTextureFormat_EACR11Snorm = 64,
		WGPUTextureFormat_EACRG11Unorm = 65,
		WGPUTextureFormat_EACRG11Snorm = 66,
		WGPUTextureFormat_ASTC4x4Unorm = 67,
		WGPUTextureFormat_ASTC4x4UnormSrgb = 68,
		WGPUTextureFormat_ASTC5x4Unorm = 69,
		WGPUTextureFormat_ASTC5x4UnormSrgb = 70,
		WGPUTextureFormat_ASTC5x5Unorm = 71,
		WGPUTextureFormat_ASTC5x5UnormSrgb = 72,
		WGPUTextureFormat_ASTC6x5Unorm = 73,
		WGPUTextureFormat_ASTC6x5UnormSrgb = 74,
		WGPUTextureFormat_ASTC6x6Unorm = 75,
		WGPUTextureFormat_ASTC6x6UnormSrgb = 76,
		WGPUTextureFormat_ASTC8x5Unorm = 77,
		WGPUTextureFormat_ASTC8x5UnormSrgb = 78,
		WGPUTextureFormat_ASTC8x6Unorm = 79,
		WGPUTextureFormat_ASTC8x6UnormSrgb = 80,
		WGPUTextureFormat_ASTC8x8Unorm = 81,
		WGPUTextureFormat_ASTC8x8UnormSrgb = 82,
		WGPUTextureFormat_ASTC10x5Unorm = 83,
		WGPUTextureFormat_ASTC10x5UnormSrgb = 84,
		WGPUTextureFormat_ASTC10x6Unorm = 85,
		WGPUTextureFormat_ASTC10x6UnormSrgb = 86,
		WGPUTextureFormat_ASTC10x8Unorm = 87,
		WGPUTextureFormat_ASTC10x8UnormSrgb = 88,
		WGPUTextureFormat_ASTC10x10Unorm = 89,
		WGPUTextureFormat_ASTC10x10UnormSrgb = 90,
		WGPUTextureFormat_ASTC12x10Unorm = 91,
		WGPUTextureFormat_ASTC12x10UnormSrgb = 92,
		WGPUTextureFormat_ASTC12x12Unorm = 93,
		WGPUTextureFormat_ASTC12x12UnormSrgb = 94,
		WGPUTextureFormat_Force32 = 2147483647,
	}

	public enum WGPUTextureSampleType
	{
		WGPUTextureSampleType_Undefined = 0,
		WGPUTextureSampleType_Float = 1,
		WGPUTextureSampleType_UnfilterableFloat = 2,
		WGPUTextureSampleType_Depth = 3,
		WGPUTextureSampleType_Sint = 4,
		WGPUTextureSampleType_Uint = 5,
		WGPUTextureSampleType_Force32 = 2147483647,
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
		WGPUVertexFormat_Undefined = 0,
		WGPUVertexFormat_Uint8x2 = 1,
		WGPUVertexFormat_Uint8x4 = 2,
		WGPUVertexFormat_Sint8x2 = 3,
		WGPUVertexFormat_Sint8x4 = 4,
		WGPUVertexFormat_Unorm8x2 = 5,
		WGPUVertexFormat_Unorm8x4 = 6,
		WGPUVertexFormat_Snorm8x2 = 7,
		WGPUVertexFormat_Snorm8x4 = 8,
		WGPUVertexFormat_Uint16x2 = 9,
		WGPUVertexFormat_Uint16x4 = 10,
		WGPUVertexFormat_Sint16x2 = 11,
		WGPUVertexFormat_Sint16x4 = 12,
		WGPUVertexFormat_Unorm16x2 = 13,
		WGPUVertexFormat_Unorm16x4 = 14,
		WGPUVertexFormat_Snorm16x2 = 15,
		WGPUVertexFormat_Snorm16x4 = 16,
		WGPUVertexFormat_Float16x2 = 17,
		WGPUVertexFormat_Float16x4 = 18,
		WGPUVertexFormat_Float32 = 19,
		WGPUVertexFormat_Float32x2 = 20,
		WGPUVertexFormat_Float32x3 = 21,
		WGPUVertexFormat_Float32x4 = 22,
		WGPUVertexFormat_Uint32 = 23,
		WGPUVertexFormat_Uint32x2 = 24,
		WGPUVertexFormat_Uint32x3 = 25,
		WGPUVertexFormat_Uint32x4 = 26,
		WGPUVertexFormat_Sint32 = 27,
		WGPUVertexFormat_Sint32x2 = 28,
		WGPUVertexFormat_Sint32x3 = 29,
		WGPUVertexFormat_Sint32x4 = 30,
		WGPUVertexFormat_Force32 = 2147483647,
	}

	public enum WGPUVertexStepMode
	{
		WGPUVertexStepMode_Vertex = 0,
		WGPUVertexStepMode_Instance = 1,
		WGPUVertexStepMode_VertexBufferNotUsed = 2,
		WGPUVertexStepMode_Force32 = 2147483647,
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
		WGPUTextureUsage_TextureBinding = 4,
		WGPUTextureUsage_StorageBinding = 8,
		WGPUTextureUsage_RenderAttachment = 16,
		WGPUTextureUsage_Force32 = 2147483647,
	}

	public enum WGPUNativeSType
	{
		WGPUSType_DeviceExtras = 1610612737,
		WGPUSType_AdapterExtras = 1610612738,
		WGPUSType_RequiredLimitsExtras = 1610612739,
		WGPUSType_PipelineLayoutExtras = 1610612740,
		WGPUSType_ShaderModuleGLSLDescriptor = 1610612741,
		WGPUSType_SupportedLimitsExtras = 1610612739,
		WGPUSType_InstanceExtras = 1610612742,
		WGPUSType_SwapChainDescriptorExtras = 1610612743,
		WGPUNativeSType_Force32 = 2147483647,
	}

	public enum WGPUNativeFeature
	{
		WGPUNativeFeature_PushConstants = 1610612737,
		WGPUNativeFeature_TextureAdapterSpecificFormatFeatures = 1610612738,
		WGPUNativeFeature_MultiDrawIndirect = 1610612739,
		WGPUNativeFeature_MultiDrawIndirectCount = 1610612740,
		WGPUNativeFeature_VertexWritableStorage = 1610612741,
		WGPUNativeFeature_Force32 = 2147483647,
	}

	public enum WGPULogLevel
	{
		WGPULogLevel_Off = 0,
		WGPULogLevel_Error = 1,
		WGPULogLevel_Warn = 2,
		WGPULogLevel_Info = 3,
		WGPULogLevel_Debug = 4,
		WGPULogLevel_Trace = 5,
		WGPULogLevel_Force32 = 2147483647,
	}

	[Flags]
	public enum WGPUInstanceBackend
	{
		WGPUInstanceBackend_Vulkan = 2,
		WGPUInstanceBackend_GL = 32,
		WGPUInstanceBackend_Metal = 4,
		WGPUInstanceBackend_DX12 = 8,
		WGPUInstanceBackend_DX11 = 16,
		WGPUInstanceBackend_BrowserWebGPU = 64,
		WGPUInstanceBackend_Primary = 78,
		WGPUInstanceBackend_Secondary = 48,
		WGPUInstanceBackend_None = 0,
		WGPUInstanceBackend_Force32 = 2147483647,
	}

	public enum WGPUDx12Compiler
	{
		WGPUDx12Compiler_Undefined = 0,
		WGPUDx12Compiler_Fxc = 1,
		WGPUDx12Compiler_Dxc = 2,
		WGPUDx12Compiler_Force32 = 2147483647,
	}

	public enum WGPUCompositeAlphaMode
	{
		WGPUCompositeAlphaMode_Auto = 0,
		WGPUCompositeAlphaMode_Opaque = 1,
		WGPUCompositeAlphaMode_PreMultiplied = 2,
		WGPUCompositeAlphaMode_PostMultiplied = 3,
		WGPUCompositeAlphaMode_Inherit = 4,
		WGPUCompositeAlphaMode_Force32 = 2147483647,
	}

}
