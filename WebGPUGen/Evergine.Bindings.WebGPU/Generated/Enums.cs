using System;

namespace Evergine.Bindings.WebGPU
{
	public enum WGPUAdapterType
	{
		DiscreteGPU = 0,
		IntegratedGPU = 1,
		CPU = 2,
		Unknown = 3,
		Force32 = 2147483647,
	}

	public enum WGPUAddressMode
	{
		Repeat = 0,
		MirrorRepeat = 1,
		ClampToEdge = 2,
		Force32 = 2147483647,
	}

	public enum WGPUBackendType
	{
		Undefined = 0,
		Null = 1,
		WebGPU = 2,
		D3D11 = 3,
		D3D12 = 4,
		Metal = 5,
		Vulkan = 6,
		OpenGL = 7,
		OpenGLES = 8,
		Force32 = 2147483647,
	}

	public enum WGPUBlendFactor
	{
		Zero = 0,
		One = 1,
		Src = 2,
		OneMinusSrc = 3,
		SrcAlpha = 4,
		OneMinusSrcAlpha = 5,
		Dst = 6,
		OneMinusDst = 7,
		DstAlpha = 8,
		OneMinusDstAlpha = 9,
		SrcAlphaSaturated = 10,
		Constant = 11,
		OneMinusConstant = 12,
		Force32 = 2147483647,
	}

	public enum WGPUBlendOperation
	{
		Add = 0,
		Subtract = 1,
		ReverseSubtract = 2,
		Min = 3,
		Max = 4,
		Force32 = 2147483647,
	}

	public enum WGPUBufferBindingType
	{
		Undefined = 0,
		Uniform = 1,
		Storage = 2,
		ReadOnlyStorage = 3,
		Force32 = 2147483647,
	}

	public enum WGPUBufferMapAsyncStatus
	{
		Success = 0,
		ValidationError = 1,
		Unknown = 2,
		DeviceLost = 3,
		DestroyedBeforeCallback = 4,
		UnmappedBeforeCallback = 5,
		MappingAlreadyPending = 6,
		OffsetOutOfRange = 7,
		SizeOutOfRange = 8,
		Force32 = 2147483647,
	}

	public enum WGPUBufferMapState
	{
		Unmapped = 0,
		Pending = 1,
		Mapped = 2,
		Force32 = 2147483647,
	}

	public enum WGPUCompareFunction
	{
		Undefined = 0,
		Never = 1,
		Less = 2,
		LessEqual = 3,
		Greater = 4,
		GreaterEqual = 5,
		Equal = 6,
		NotEqual = 7,
		Always = 8,
		Force32 = 2147483647,
	}

	public enum WGPUCompilationInfoRequestStatus
	{
		Success = 0,
		Error = 1,
		DeviceLost = 2,
		Unknown = 3,
		Force32 = 2147483647,
	}

	public enum WGPUCompilationMessageType
	{
		Error = 0,
		Warning = 1,
		Info = 2,
		Force32 = 2147483647,
	}

	public enum WGPUComputePassTimestampLocation
	{
		Beginning = 0,
		End = 1,
		Force32 = 2147483647,
	}

	public enum WGPUCreatePipelineAsyncStatus
	{
		Success = 0,
		ValidationError = 1,
		InternalError = 2,
		DeviceLost = 3,
		DeviceDestroyed = 4,
		Unknown = 5,
		Force32 = 2147483647,
	}

	public enum WGPUCullMode
	{
		None = 0,
		Front = 1,
		Back = 2,
		Force32 = 2147483647,
	}

	public enum WGPUDeviceLostReason
	{
		Undefined = 0,
		Destroyed = 1,
		Force32 = 2147483647,
	}

	public enum WGPUErrorFilter
	{
		Validation = 0,
		OutOfMemory = 1,
		Internal = 2,
		Force32 = 2147483647,
	}

	public enum WGPUErrorType
	{
		NoError = 0,
		Validation = 1,
		OutOfMemory = 2,
		Internal = 3,
		Unknown = 4,
		DeviceLost = 5,
		Force32 = 2147483647,
	}

	public enum WGPUFeatureName
	{
		Undefined = 0,
		DepthClipControl = 1,
		Depth32FloatStencil8 = 2,
		TimestampQuery = 3,
		PipelineStatisticsQuery = 4,
		TextureCompressionBC = 5,
		TextureCompressionETC2 = 6,
		TextureCompressionASTC = 7,
		IndirectFirstInstance = 8,
		ShaderF16 = 9,
		RG11B10UfloatRenderable = 10,
		BGRA8UnormStorage = 11,
		Float32Filterable = 12,
		Force32 = 2147483647,
	}

	public enum WGPUFilterMode
	{
		Nearest = 0,
		Linear = 1,
		Force32 = 2147483647,
	}

	public enum WGPUFrontFace
	{
		CCW = 0,
		CW = 1,
		Force32 = 2147483647,
	}

	public enum WGPUIndexFormat
	{
		Undefined = 0,
		Uint16 = 1,
		Uint32 = 2,
		Force32 = 2147483647,
	}

	public enum WGPULoadOp
	{
		Undefined = 0,
		Clear = 1,
		Load = 2,
		Force32 = 2147483647,
	}

	public enum WGPUMipmapFilterMode
	{
		Nearest = 0,
		Linear = 1,
		Force32 = 2147483647,
	}

	public enum WGPUPipelineStatisticName
	{
		VertexShaderInvocations = 0,
		ClipperInvocations = 1,
		ClipperPrimitivesOut = 2,
		FragmentShaderInvocations = 3,
		ComputeShaderInvocations = 4,
		Force32 = 2147483647,
	}

	public enum WGPUPowerPreference
	{
		Undefined = 0,
		LowPower = 1,
		HighPerformance = 2,
		Force32 = 2147483647,
	}

	public enum WGPUPresentMode
	{
		Immediate = 0,
		Mailbox = 1,
		Fifo = 2,
		Force32 = 2147483647,
	}

	public enum WGPUPrimitiveTopology
	{
		PointList = 0,
		LineList = 1,
		LineStrip = 2,
		TriangleList = 3,
		TriangleStrip = 4,
		Force32 = 2147483647,
	}

	public enum WGPUQueryType
	{
		Occlusion = 0,
		PipelineStatistics = 1,
		Timestamp = 2,
		Force32 = 2147483647,
	}

	public enum WGPUQueueWorkDoneStatus
	{
		Success = 0,
		Error = 1,
		Unknown = 2,
		DeviceLost = 3,
		Force32 = 2147483647,
	}

	public enum WGPURenderPassTimestampLocation
	{
		Beginning = 0,
		End = 1,
		Force32 = 2147483647,
	}

	public enum WGPURequestAdapterStatus
	{
		Success = 0,
		Unavailable = 1,
		Error = 2,
		Unknown = 3,
		Force32 = 2147483647,
	}

	public enum WGPURequestDeviceStatus
	{
		Success = 0,
		Error = 1,
		Unknown = 2,
		Force32 = 2147483647,
	}

	public enum WGPUSType
	{
		Invalid = 0,
		SurfaceDescriptorFromMetalLayer = 1,
		SurfaceDescriptorFromWindowsHWND = 2,
		SurfaceDescriptorFromXlibWindow = 3,
		SurfaceDescriptorFromCanvasHTMLSelector = 4,
		ShaderModuleSPIRVDescriptor = 5,
		ShaderModuleWGSLDescriptor = 6,
		PrimitiveDepthClipControl = 7,
		SurfaceDescriptorFromWaylandSurface = 8,
		SurfaceDescriptorFromAndroidNativeWindow = 9,
		SurfaceDescriptorFromXcbWindow = 10,
		RenderPassDescriptorMaxDrawCount = 15,
		Force32 = 2147483647,
	}

	public enum WGPUSamplerBindingType
	{
		Undefined = 0,
		Filtering = 1,
		NonFiltering = 2,
		Comparison = 3,
		Force32 = 2147483647,
	}

	public enum WGPUStencilOperation
	{
		Keep = 0,
		Zero = 1,
		Replace = 2,
		Invert = 3,
		IncrementClamp = 4,
		DecrementClamp = 5,
		IncrementWrap = 6,
		DecrementWrap = 7,
		Force32 = 2147483647,
	}

	public enum WGPUStorageTextureAccess
	{
		Undefined = 0,
		WriteOnly = 1,
		Force32 = 2147483647,
	}

	public enum WGPUStoreOp
	{
		Undefined = 0,
		Store = 1,
		Discard = 2,
		Force32 = 2147483647,
	}

	public enum WGPUTextureAspect
	{
		All = 0,
		StencilOnly = 1,
		DepthOnly = 2,
		Force32 = 2147483647,
	}

	public enum WGPUTextureDimension
	{
		_1D = 0,
		_2D = 1,
		_3D = 2,
		Force32 = 2147483647,
	}

	public enum WGPUTextureFormat
	{
		Undefined = 0,
		R8Unorm = 1,
		R8Snorm = 2,
		R8Uint = 3,
		R8Sint = 4,
		R16Uint = 5,
		R16Sint = 6,
		R16Float = 7,
		RG8Unorm = 8,
		RG8Snorm = 9,
		RG8Uint = 10,
		RG8Sint = 11,
		R32Float = 12,
		R32Uint = 13,
		R32Sint = 14,
		RG16Uint = 15,
		RG16Sint = 16,
		RG16Float = 17,
		RGBA8Unorm = 18,
		RGBA8UnormSrgb = 19,
		RGBA8Snorm = 20,
		RGBA8Uint = 21,
		RGBA8Sint = 22,
		BGRA8Unorm = 23,
		BGRA8UnormSrgb = 24,
		RGB10A2Unorm = 25,
		RG11B10Ufloat = 26,
		RGB9E5Ufloat = 27,
		RG32Float = 28,
		RG32Uint = 29,
		RG32Sint = 30,
		RGBA16Uint = 31,
		RGBA16Sint = 32,
		RGBA16Float = 33,
		RGBA32Float = 34,
		RGBA32Uint = 35,
		RGBA32Sint = 36,
		Stencil8 = 37,
		Depth16Unorm = 38,
		Depth24Plus = 39,
		Depth24PlusStencil8 = 40,
		Depth32Float = 41,
		Depth32FloatStencil8 = 42,
		BC1RGBAUnorm = 43,
		BC1RGBAUnormSrgb = 44,
		BC2RGBAUnorm = 45,
		BC2RGBAUnormSrgb = 46,
		BC3RGBAUnorm = 47,
		BC3RGBAUnormSrgb = 48,
		BC4RUnorm = 49,
		BC4RSnorm = 50,
		BC5RGUnorm = 51,
		BC5RGSnorm = 52,
		BC6HRGBUfloat = 53,
		BC6HRGBFloat = 54,
		BC7RGBAUnorm = 55,
		BC7RGBAUnormSrgb = 56,
		ETC2RGB8Unorm = 57,
		ETC2RGB8UnormSrgb = 58,
		ETC2RGB8A1Unorm = 59,
		ETC2RGB8A1UnormSrgb = 60,
		ETC2RGBA8Unorm = 61,
		ETC2RGBA8UnormSrgb = 62,
		EACR11Unorm = 63,
		EACR11Snorm = 64,
		EACRG11Unorm = 65,
		EACRG11Snorm = 66,
		ASTC4x4Unorm = 67,
		ASTC4x4UnormSrgb = 68,
		ASTC5x4Unorm = 69,
		ASTC5x4UnormSrgb = 70,
		ASTC5x5Unorm = 71,
		ASTC5x5UnormSrgb = 72,
		ASTC6x5Unorm = 73,
		ASTC6x5UnormSrgb = 74,
		ASTC6x6Unorm = 75,
		ASTC6x6UnormSrgb = 76,
		ASTC8x5Unorm = 77,
		ASTC8x5UnormSrgb = 78,
		ASTC8x6Unorm = 79,
		ASTC8x6UnormSrgb = 80,
		ASTC8x8Unorm = 81,
		ASTC8x8UnormSrgb = 82,
		ASTC10x5Unorm = 83,
		ASTC10x5UnormSrgb = 84,
		ASTC10x6Unorm = 85,
		ASTC10x6UnormSrgb = 86,
		ASTC10x8Unorm = 87,
		ASTC10x8UnormSrgb = 88,
		ASTC10x10Unorm = 89,
		ASTC10x10UnormSrgb = 90,
		ASTC12x10Unorm = 91,
		ASTC12x10UnormSrgb = 92,
		ASTC12x12Unorm = 93,
		ASTC12x12UnormSrgb = 94,
		Force32 = 2147483647,
	}

	public enum WGPUTextureSampleType
	{
		Undefined = 0,
		Float = 1,
		UnfilterableFloat = 2,
		Depth = 3,
		Sint = 4,
		Uint = 5,
		Force32 = 2147483647,
	}

	public enum WGPUTextureViewDimension
	{
		Undefined = 0,
		_1D = 1,
		_2D = 2,
		_2DArray = 3,
		Cube = 4,
		CubeArray = 5,
		_3D = 6,
		Force32 = 2147483647,
	}

	public enum WGPUVertexFormat
	{
		Undefined = 0,
		Uint8x2 = 1,
		Uint8x4 = 2,
		Sint8x2 = 3,
		Sint8x4 = 4,
		Unorm8x2 = 5,
		Unorm8x4 = 6,
		Snorm8x2 = 7,
		Snorm8x4 = 8,
		Uint16x2 = 9,
		Uint16x4 = 10,
		Sint16x2 = 11,
		Sint16x4 = 12,
		Unorm16x2 = 13,
		Unorm16x4 = 14,
		Snorm16x2 = 15,
		Snorm16x4 = 16,
		Float16x2 = 17,
		Float16x4 = 18,
		Float32 = 19,
		Float32x2 = 20,
		Float32x3 = 21,
		Float32x4 = 22,
		Uint32 = 23,
		Uint32x2 = 24,
		Uint32x3 = 25,
		Uint32x4 = 26,
		Sint32 = 27,
		Sint32x2 = 28,
		Sint32x3 = 29,
		Sint32x4 = 30,
		Force32 = 2147483647,
	}

	public enum WGPUVertexStepMode
	{
		Vertex = 0,
		Instance = 1,
		VertexBufferNotUsed = 2,
		Force32 = 2147483647,
	}

	[Flags]
	public enum WGPUBufferUsage
	{
		None = 0,
		MapRead = 1,
		MapWrite = 2,
		CopySrc = 4,
		CopyDst = 8,
		Index = 16,
		Vertex = 32,
		Uniform = 64,
		Storage = 128,
		Indirect = 256,
		QueryResolve = 512,
		Force32 = 2147483647,
	}

	[Flags]
	public enum WGPUColorWriteMask
	{
		None = 0,
		Red = 1,
		Green = 2,
		Blue = 4,
		Alpha = 8,
		All = 15,
		Force32 = 2147483647,
	}

	[Flags]
	public enum WGPUMapMode
	{
		None = 0,
		Read = 1,
		Write = 2,
		Force32 = 2147483647,
	}

	[Flags]
	public enum WGPUShaderStage
	{
		None = 0,
		Vertex = 1,
		Fragment = 2,
		Compute = 4,
		Force32 = 2147483647,
	}

	[Flags]
	public enum WGPUTextureUsage
	{
		None = 0,
		CopySrc = 1,
		CopyDst = 2,
		TextureBinding = 4,
		StorageBinding = 8,
		RenderAttachment = 16,
		Force32 = 2147483647,
	}

	public enum WGPUNativeSType
	{
		DeviceExtras = 1610612737,
		AdapterExtras = 1610612738,
		RequiredLimitsExtras = 1610612739,
		PipelineLayoutExtras = 1610612740,
		ShaderModuleGLSLDescriptor = 1610612741,
		SupportedLimitsExtras = 1610612739,
		InstanceExtras = 1610612742,
		SwapChainDescriptorExtras = 1610612743,
		Force32 = 2147483647,
	}

	public enum WGPUNativeFeature
	{
		PushConstants = 1610612737,
		TextureAdapterSpecificFormatFeatures = 1610612738,
		MultiDrawIndirect = 1610612739,
		MultiDrawIndirectCount = 1610612740,
		VertexWritableStorage = 1610612741,
		Force32 = 2147483647,
	}

	public enum WGPULogLevel
	{
		Off = 0,
		Error = 1,
		Warn = 2,
		Info = 3,
		Debug = 4,
		Trace = 5,
		Force32 = 2147483647,
	}

	[Flags]
	public enum WGPUInstanceBackend
	{
		Vulkan = 2,
		GL = 32,
		Metal = 4,
		DX12 = 8,
		DX11 = 16,
		BrowserWebGPU = 64,
		Primary = 78,
		Secondary = 48,
		None = 0,
		Force32 = 2147483647,
	}

	public enum WGPUDx12Compiler
	{
		Undefined = 0,
		Fxc = 1,
		Dxc = 2,
		Force32 = 2147483647,
	}

	public enum WGPUCompositeAlphaMode
	{
		Auto = 0,
		Opaque = 1,
		PreMultiplied = 2,
		PostMultiplied = 3,
		Inherit = 4,
		Force32 = 2147483647,
	}

}
