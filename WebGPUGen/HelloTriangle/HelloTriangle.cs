using Evergine.Bindings.WebGPU;
using System;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static Evergine.Bindings.WebGPU.WebGPUNative;

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
            window.Size = new System.Drawing.Size((int)WIDTH, (int)HEIGHT);
            window.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            window.Show();
        }

        [DllImport("kernel32", ExactSpelling = true)]
        private static extern nint GetModuleHandleW(ushort* lpModuleName);

        private void InitWebGPU()
        {
            WGPUInstanceDescriptor instanceDescriptor = new WGPUInstanceDescriptor()
            {
                nextInChain = null,
            };
            Instance = wgpuCreateInstance(&instanceDescriptor);

            WGPUSurfaceDescriptorFromWindowsHWND windowsSurface = new WGPUSurfaceDescriptorFromWindowsHWND()
            {
                chain = new WGPUChainedStruct()
                {
                    sType = WGPUSType.SurfaceDescriptorFromWindowsHWND,
                },
                hinstance = (void*)Process.GetCurrentProcess().Handle,
                hwnd = (void*)window.Handle,
            };

            WGPUSurfaceDescriptor surfaceDescriptor = new WGPUSurfaceDescriptor()
            {
                nextInChain = &windowsSurface.chain,
            };

            Surface = wgpuInstanceCreateSurface(Instance, &surfaceDescriptor);

            WGPURequestAdapterOptions options = new WGPURequestAdapterOptions()
            {
                nextInChain = null,
                //backendType = WGPUBackendType.D3D12,
                compatibleSurface = Surface,
                powerPreference = WGPUPowerPreference.HighPerformance
            };

            wgpuInstanceRequestAdapter(Instance, &options, OnAdapterRequestEnded, (void*)0);

            WGPUDeviceDescriptor deviceDescriptor = new WGPUDeviceDescriptor()
            {
                nextInChain = null,
                label = null,
                requiredFeatures = (WGPUFeatureName*)0,
                requiredLimits = null,
            };

            wgpuAdapterRequestDevice(Adapter, &deviceDescriptor, OnDeviceRequestEnded, (void*)0);

            wgpuDeviceSetUncapturedErrorCallback(Device, HandleUncapturedErrorCallback, (void*)0);

            Queue = wgpuDeviceGetQueue(Device);

            SwapChainFormat = wgpuSurfaceGetPreferredFormat(Surface, Adapter);

            int width = window.ClientSize.Width;
            int height = window.ClientSize.Height;
            WGPUSwapChainDescriptor swapchainDescriptor = new WGPUSwapChainDescriptor()
            {
                nextInChain = null,
                usage = WGPUTextureUsage.RenderAttachment,
                format = SwapChainFormat,
                width = (uint)width,
                height = (uint)height,
                presentMode = WGPUPresentMode.Fifo,
            };


            SwapChain = wgpuDeviceCreateSwapChain(Device, Surface, &swapchainDescriptor);
        }

        private static void HandleUncapturedErrorCallback(WGPUErrorType type, char* pMessage, void* pUserData)
        {
            Console.WriteLine($"Uncaptured device error: type: {type} ({Helpers.GetString(pMessage)})");
        }

        private void OnAdapterRequestEnded(WGPURequestAdapterStatus status, WGPUAdapter candidateAdapter, char* message, void* pUserData)
        {
            if (status == WGPURequestAdapterStatus.Success)
            {
                Adapter = candidateAdapter;
                WGPUAdapterProperties properties;
                wgpuAdapterGetProperties(candidateAdapter, &properties);
                window.Text = $"WGPU-Native Triangle ({properties.backendType})";

                WGPUSupportedLimits limits;
                wgpuAdapterGetLimits(candidateAdapter, &limits);

                AdapterProperties = properties;
                AdapterLimits = limits;
            }
            else
            {
                Console.WriteLine($"Could not get WebGPU adapter: {Helpers.GetString(message)}");
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
                Console.WriteLine($"Could not get WebGPU device: {Helpers.GetString(message)}");
            }
        }

        private void InitResources()
        {
            WGPUPipelineLayoutDescriptor layoutDescription = new()
            {
                nextInChain = null,
                bindGroupLayoutCount = 0,
                bindGroupLayouts = null,
            };

            pipelineLayout = wgpuDeviceCreatePipelineLayout(Device, &layoutDescription);

            string shaderSource = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "Content", $"triangle.wgsl"));

            WGPUShaderModuleWGSLDescriptor shaderCodeDescriptor = new()
            {
                chain = new WGPUChainedStruct()
                {
                    next = null,
                    sType = WGPUSType.ShaderModuleWGSLDescriptor,
                },
                code = shaderSource.ToPointer(),
            };

            WGPUShaderModuleDescriptor moduleDescriptor = new()
            {
                nextInChain = &shaderCodeDescriptor.chain,
                hintCount = 0,
                hints = null,
            };

            WGPUShaderModule shaderModule = wgpuDeviceCreateShaderModule(Device, &moduleDescriptor);

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
                    offset = 16,
                    shaderLocation = 1,
                },
            };

            WGPUVertexBufferLayout vertexLayout = new WGPUVertexBufferLayout()
            {
                attributeCount = 2,
                attributes = vertexAttributes,
                arrayStride = (ulong)sizeof(Vector4) * 2,
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
                    bufferCount = 1,
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
                    cullMode = WGPUCullMode.None,
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

            pipeline = wgpuDeviceCreateRenderPipeline(Device, &pipelineDescriptor);

            wgpuShaderModuleRelease(shaderModule);

            Vector4* vertexData = stackalloc Vector4[]
            {
                new Vector4(0.0f, 0.5f, 0.5f, 1.0f),
                new Vector4(1.0f, 0.0f, 0.0f, 1.0f),
                new Vector4(0.5f, -0.5f, 0.5f, 1.0f),
                new Vector4(0.0f, 1.0f, 0.0f, 1.0f),
                new Vector4(-0.5f, -0.5f, 0.5f, 1.0f),
                new Vector4(0.0f, 0.0f, 1.0f, 1.0f)
            };

            ulong size = (ulong)(6 * sizeof(Vector4));
            WGPUBufferDescriptor bufferDescriptor = new WGPUBufferDescriptor()
            {
                nextInChain = null,
                usage = WGPUBufferUsage.Vertex | WGPUBufferUsage.CopyDst,
                size = size,
                mappedAtCreation = false,
            };
            vertexBuffer = wgpuDeviceCreateBuffer(Device, &bufferDescriptor);
            wgpuQueueWriteBuffer(Queue, vertexBuffer, 0, vertexData, size);
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
                this.DrawFrame();

                Application.DoEvents();
            }
        }

        private void DrawFrame()
        {
            WGPUTextureView nextTexture = wgpuSwapChainGetCurrentTextureView(SwapChain);

            if (nextTexture.Handle == IntPtr.Zero)
            {
                Console.WriteLine("Cannot acquire next swap chain texture");
                return;
            }

            WGPUCommandEncoderDescriptor encoderDescriptor = new WGPUCommandEncoderDescriptor()
            {
                nextInChain = null,
            };
            WGPUCommandEncoder encoder = wgpuDeviceCreateCommandEncoder(Device, &encoderDescriptor);

            WGPURenderPassColorAttachment renderPassColorAttachment = new WGPURenderPassColorAttachment()
            {
                view = nextTexture,
                resolveTarget = WGPUTextureView.Null,
                loadOp = WGPULoadOp.Clear,
                storeOp = WGPUStoreOp.Store,
                clearValue = new WGPUColor() { a = 1.0f },
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

            WGPURenderPassEncoder renderPass = wgpuCommandEncoderBeginRenderPass(encoder, &renderPassDescriptor);

            wgpuRenderPassEncoderSetPipeline(renderPass, pipeline);
            wgpuRenderPassEncoderSetVertexBuffer(renderPass, 0, vertexBuffer, 0, WGPU_WHOLE_MAP_SIZE);
            wgpuRenderPassEncoderDraw(renderPass, 3, 1, 0, 0);
            wgpuRenderPassEncoderEnd(renderPass);

            wgpuTextureViewRelease(nextTexture);

            WGPUCommandBufferDescriptor commandBufferDescriptor = new WGPUCommandBufferDescriptor()
            {
                nextInChain = null,
            };

            WGPUCommandBuffer command = wgpuCommandEncoderFinish(encoder, &commandBufferDescriptor);
            wgpuQueueSubmit(Queue, 1, &command);

            wgpuCommandEncoderRelease(encoder);

            wgpuSwapChainPresent(SwapChain);
        }

        private void CleanUp()
        {
            wgpuSwapChainRelease(SwapChain);
            wgpuDeviceDestroy(Device);
            wgpuDeviceRelease(Device);
            wgpuAdapterRelease(Adapter);
            wgpuInstanceRelease(Instance);

            this.window.Dispose();
            this.window.Close();
        }

    }
}
