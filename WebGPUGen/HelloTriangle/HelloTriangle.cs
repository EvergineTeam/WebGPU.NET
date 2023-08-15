using Evergine.Bindings.WebGPU;
using Microsoft.VisualBasic.Logging;
using System;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Windows.Forms;

namespace HelloTriangle
{
    public unsafe class HelloTriangle
    {
        const uint WIDTH = 800;
        const uint HEIGHT = 600;

        private Form window;
        private WGPUInstance Instance;
        private WGPUSurface Surface;
        private WGPUAdapter Adapter;
        private WGPUAdapterProperties AdapterProperties;
        private WGPUSupportedLimits AdapterLimits;
        private WGPUDevice Device;
        private WGPUTextureFormat SwapChainFormat;
        private WGPUSwapChain SwapChain;
        private WGPUQueue Queue;

        private WGPUPipelineLayout pipelineLayout;
        private WGPURenderPipeline pipeline;
        private WGPUBuffer vertexBuffer;

        public void Run()
        {
            this.InitWindow();

            this.InitWebGPU();

            this.InitResources();

            this.MainLoop();

            this.CleanUp();
        }

        private void InitWindow()
        {
            window = new Form();
            window.Text = "WGPU-Native Triangle Rasterization";
            window.Size = new System.Drawing.Size((int)WIDTH, (int)HEIGHT);
            window.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            window.Show();
        }


        private void InitWebGPU()
        {
            WGPUInstanceDescriptor instanceDescriptor = new WGPUInstanceDescriptor()
            {
                nextInChain = null,
            };
            Instance = WebGPUNative.wgpuCreateInstance(&instanceDescriptor);


            WGPUSurfaceDescriptorFromWindowsHWND windowsSurface = new WGPUSurfaceDescriptorFromWindowsHWND()
            {
                chain = new WGPUChainedStruct() 
                { 
                    sType = WGPUSType.SurfaceDescriptorFromWindowsHWND, 
                    next = null,
                },
                hinstance = (void*)Process.GetCurrentProcess().Handle,
                hwnd = (void*)window.Handle,
            };

            WGPUSurfaceDescriptor surfaceDescriptor = new WGPUSurfaceDescriptor()
            {
                nextInChain = &windowsSurface.chain,
                label = null,
            };

            Surface = WebGPUNative.wgpuInstanceCreateSurface(Instance, &surfaceDescriptor);

            WGPURequestAdapterOptions options = new WGPURequestAdapterOptions()
            {
                nextInChain = null,
                backendType = WGPUBackendType.D3D12,
                compatibleSurface = Surface,
                powerPreference = WGPUPowerPreference.HighPerformance
            };

            WebGPUNative.wgpuInstanceRequestAdapter(Instance, &options, OnAdapterRequestEnded, (void*)0);

            WGPUDeviceDescriptor deviceDescriptor = new WGPUDeviceDescriptor()
            {
                nextInChain = null,
                label = null,
                requiredFeatures = (WGPUFeatureName*)0,
                requiredLimits = null,
            };

            WebGPUNative.wgpuAdapterRequestDevice(Adapter, &deviceDescriptor, OnDeviceRequestEnded, (void*)0);

            WebGPUNative.wgpuDeviceSetUncapturedErrorCallback(Device, HandleUncapturedErrorCallback, (void*)0);

            Queue = WebGPUNative.wgpuDeviceGetQueue(Device);

            SwapChainFormat = WebGPUNative.wgpuSurfaceGetPreferredFormat(Surface, Adapter);

            WGPUSwapChainDescriptor swapchainDescriptor = new WGPUSwapChainDescriptor()
            {
                nextInChain = null,
                usage = WGPUTextureUsage.RenderAttachment,
                format = SwapChainFormat,
                width = (uint)window.Width,
                height = (uint)window.Height,
                presentMode = WGPUPresentMode.Fifo,
            };

            SwapChain = WebGPUNative.wgpuDeviceCreateSwapChain(Device, Surface, &swapchainDescriptor);
        }

        private static void HandleUncapturedErrorCallback(WGPUErrorType type, char* pMessage, void* pUserData)
        {
            string message = Helpers.GetString(pMessage);
            Console.Write($"Uncaptured device error: type: {type} ({message})");
        }

        private void OnAdapterRequestEnded(WGPURequestAdapterStatus status, WGPUAdapter candidateAdapter, char* message, void* pUserData)
        {
            if (status == WGPURequestAdapterStatus.Success)
            {
                Adapter = candidateAdapter;
                WGPUAdapterProperties properties;
                WebGPUNative.wgpuAdapterGetProperties(candidateAdapter, &properties);

                WGPUSupportedLimits limits;
                WebGPUNative.wgpuAdapterGetLimits(candidateAdapter, &limits);

                AdapterProperties = properties;
                AdapterLimits = limits;
            }
            else
            {
                Console.WriteLine($"Could not get WebGPU adapter: { Helpers.GetString(message) }");
            }
        }

        private void OnDeviceRequestEnded(WGPURequestDeviceStatus status, WGPUDevice device, char* message, void* pUserData)
        {
            if (status == WGPURequestDeviceStatus.Success)
            {
                Device = device;
            }
            else
            {
                Console.WriteLine($"Could not get WebGPU device: { Helpers.GetString(message) }");
            }
        }

        private void InitResources()
        {
            WGPUPipelineLayoutDescriptor layoutDescription = new WGPUPipelineLayoutDescriptor()
            {
                nextInChain = null,
                bindGroupLayoutCount = 0,
                bindGroupLayouts = null,
            };

            pipelineLayout = WebGPUNative.wgpuDeviceCreatePipelineLayout(Device, &layoutDescription);

            string shaderSource = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "Content", $"triangle.wgsl"));

            WGPUShaderModuleWGSLDescriptor shaderCodeDescriptor = new WGPUShaderModuleWGSLDescriptor()
            {
                chain = new WGPUChainedStruct()
                { 
                    next = null,
                    sType = WGPUSType.ShaderModuleWGSLDescriptor,
                },
                code = shaderSource.ToPointer(),
            };

            WGPUShaderModuleDescriptor moduleDescriptor = new WGPUShaderModuleDescriptor()
            {
                nextInChain = &shaderCodeDescriptor.chain,
                hintCount = 0,
                hints = null,
            };

            WGPUShaderModule shaderModule = WebGPUNative.wgpuDeviceCreateShaderModule(Device, &moduleDescriptor);

            WGPUVertexAttribute* vertexAttributes = stackalloc WGPUVertexAttribute[2]
            {
                new WGPUVertexAttribute()
                {
                    format = WGPUVertexFormat.Float32x4,
                    offset = 0,
                    shaderLocation = 0,
                },
                new WGPUVertexAttribute()
                {
                    format = WGPUVertexFormat.Float32x4,
                    offset = 12,
                    shaderLocation = 1,
                },
            };

            WGPUVertexBufferLayout vertexLayout = new WGPUVertexBufferLayout()
            {
                attributeCount = 2,
                attributes = vertexAttributes,
                arrayStride = (ulong)VertexPositionColor.SizeInBytes,
                stepMode = WGPUVertexStepMode.Vertex,
            };

            WGPUBlendState blendState = new WGPUBlendState()
            {
                color = new WGPUBlendComponent()
                {
                    srcFactor = WGPUBlendFactor.One,
                    dstFactor = WGPUBlendFactor.Zero,
                    operation = WGPUBlendOperation.Add,
                },
                alpha = new WGPUBlendComponent()
                {
                    srcFactor = WGPUBlendFactor.One,
                    dstFactor = WGPUBlendFactor.Zero,
                    operation = WGPUBlendOperation.Add,
                }
            };

            WGPUColorTargetState colorTargetState = new WGPUColorTargetState()
            {
                nextInChain = null,
                format = SwapChainFormat,
                blend = &blendState,
                writeMask = WGPUColorWriteMask.All,
            };

            WGPUFragmentState fragmentState = new WGPUFragmentState()
            {
                nextInChain = null,
                module = shaderModule,
                entryPoint = "fragmentMain".ToPointer(),
                constantCount = 0,
                constants = null,
                targetCount = 1,
                targets = &colorTargetState,
            };

            WGPURenderPipelineDescriptor pipelineDescriptor = new WGPURenderPipelineDescriptor()
            {
                layout = pipelineLayout,
                vertex = new WGPUVertexState()
                {
                    bufferCount = 0,
                    buffers = &vertexLayout,

                    module = shaderModule,
                    entryPoint = "vertexMain".ToPointer(),
                    constantCount = 0,
                    constants = null,
                },
                primitive = new WGPUPrimitiveState()
                {
                    topology = WGPUPrimitiveTopology.TriangleList,
                    stripIndexFormat = WGPUIndexFormat.Undefined,
                    frontFace = WGPUFrontFace.CCW,
                    cullMode = WGPUCullMode.Back,
                },
                fragment = &fragmentState,
                depthStencil = null,
                multisample = new WGPUMultisampleState()
                {
                    count = 1,
                    mask = ~0u,
                    alphaToCoverageEnabled = false,
                }
            };

            pipeline = WebGPUNative.wgpuDeviceCreateRenderPipeline(Device, ref pipelineDescriptor);

            WebGPUNative.wgpuShaderModuleRelease(shaderModule);

            VertexPositionColor* vertexData = stackalloc VertexPositionColor[]
            {
                // TriangleList
                new(new Vector3(0.0f, 0.5f, 0.5f), new Vector4(1.0f, 0.0f, 0.0f, 1.0f)),
                new(new Vector3(0.5f, -0.5f, 0.5f), new Vector4(0.0f, 1.0f, 0.0f, 1.0f)),
                new(new Vector3(-0.5f, -0.5f, 0.5f), new Vector4(0.0f, 0.0f, 1.0f, 1.0f)),
            };

            WGPUBufferDescriptor bufferDescriptor = new WGPUBufferDescriptor()
            {
                nextInChain = null,
                usage = WGPUBufferUsage.Vertex | WGPUBufferUsage.CopyDst,
                size = 96,
                mappedAtCreation = false,
            };
            vertexBuffer = WebGPUNative.wgpuDeviceCreateBuffer(Device, ref bufferDescriptor);

            ulong size = (ulong)(3 * sizeof(VertexPositionColor));
            WebGPUNative.wgpuQueueWriteBuffer(Queue, vertexBuffer, 0, vertexData, size);
        }


        private void MainLoop()
        {
            bool isClosing = false;
            window.FormClosing += (s, e) =>
            {
                isClosing = true;
            };

            while (!isClosing)
            {
                Application.DoEvents();

                this.DrawFrame();
            }
        }

        private void DrawFrame()
        {
            WGPUTextureView nextTexture = WebGPUNative.wgpuSwapChainGetCurrentTextureView(SwapChain);

            WGPUCommandEncoderDescriptor encoderDescriptor = new WGPUCommandEncoderDescriptor()
            {
                nextInChain = null,
                label = (char*)0,
            };
            WGPUCommandEncoder encoder = WebGPUNative.wgpuDeviceCreateCommandEncoder(Device, &encoderDescriptor);

            WGPURenderPassColorAttachment renderPassColorAttachment = new WGPURenderPassColorAttachment()
            {
                view = nextTexture,
                resolveTarget = WGPUTextureView.Null,
                loadOp = WGPULoadOp.Clear,
                storeOp = WGPUStoreOp.Store,
                clearValue = new WGPUColor() { r = 0.392156869f, g = 00.58431375f, b = 00.929411769f, a = 1.0f },
            };

            WGPURenderPassDescriptor renderPassDescriptor = new WGPURenderPassDescriptor()
            {
                nextInChain = null,
                colorAttachmentCount = 1,
                colorAttachments = &renderPassColorAttachment,
                depthStencilAttachment = null,
                timestampWriteCount = 0,
                timestampWrites = null,
            };

            WGPURenderPassEncoder renderPass = WebGPUNative.wgpuCommandEncoderBeginRenderPass(encoder, &renderPassDescriptor);

            WebGPUNative.wgpuRenderPassEncoderSetPipeline(renderPass, pipeline);
            WebGPUNative.wgpuRenderPassEncoderSetVertexBuffer(renderPass, 0, vertexBuffer, 0, (ulong)0xffffffffffffffffUL);
            WebGPUNative.wgpuRenderPassEncoderDraw(renderPass, 3, 1, 0, 0);
            WebGPUNative.wgpuRenderPassEncoderEnd(renderPass);

            WebGPUNative.wgpuTextureViewRelease(nextTexture);

            WGPUCommandBufferDescriptor commandBufferDescriptor = new WGPUCommandBufferDescriptor()
            {
                nextInChain = null,
                label = (char*)0,
            };

            WGPUCommandBuffer command = WebGPUNative.wgpuCommandEncoderFinish(encoder, &commandBufferDescriptor);
            WebGPUNative.wgpuQueueSubmit(Queue, 1, &command);

            WebGPUNative.wgpuCommandEncoderRelease(encoder);

            WebGPUNative.wgpuSwapChainPresent(SwapChain);

        }

        private void CleanUp()
        {
            WebGPUNative.wgpuSwapChainRelease(SwapChain);
            WebGPUNative.wgpuDeviceDestroy(Device);
            WebGPUNative.wgpuDeviceRelease(Device);
            WebGPUNative.wgpuAdapterRelease(Adapter);
            WebGPUNative.wgpuInstanceRelease(Instance);

            this.window.Dispose();
            this.window.Close();
        }

    }
}
