using Evergine.Bindings.WebGPU;
using Microsoft.VisualBasic.Logging;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace HelloTriangle
{
    public unsafe class HelloTriangle
    {
        const uint WIDTH = 800;
        const uint HEIGHT = 600;

        private Form window;
        public WGPUInstance Instance;
        public WGPUSurface Surface;
        public WGPUAdapter Adapter;
        public WGPUAdapterProperties AdapterProperties;
        public WGPUSupportedLimits AdapterLimits;
        public WGPUDevice Device;
        public WGPUSwapChain SwapChain;
        public WGPUQueue Queue;

        public void Run()
        {
            this.InitWindow();

            this.InitWebGPU();

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
                    sType = WGPUSType.WGPUSType_SurfaceDescriptorFromWindowsHWND, 
                    next = null 
                },
                hinstance = (void*)Process.GetCurrentProcess().Handle,
                hwnd = (void*)window.Handle,
            };

            WGPUSurfaceDescriptor surfaceDescriptor = new WGPUSurfaceDescriptor()
            {
                nextInChain = (WGPUChainedStruct*)&windowsSurface,
                label = null,
            };

            Surface = WebGPUNative.wgpuInstanceCreateSurface(Instance, &surfaceDescriptor);

            WGPURequestAdapterOptions options = new WGPURequestAdapterOptions()
            {
                nextInChain = null,
                backendType = WGPUBackendType.WGPUBackendType_D3D12,
                compatibleSurface = Surface,
                powerPreference = WGPUPowerPreference.WGPUPowerPreference_HighPerformance
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

            WGPUTextureFormat swapChainFormat = WebGPUNative.wgpuSurfaceGetPreferredFormat(Surface, Adapter);

            WGPUSwapChainDescriptor swapchainDescriptor = new WGPUSwapChainDescriptor()
            {
                nextInChain = null,
                usage = WGPUTextureUsage.WGPUTextureUsage_RenderAttachment,
                format = swapChainFormat,
                width = (uint)window.Width,
                height = (uint)window.Height,
                presentMode = WGPUPresentMode.WGPUPresentMode_Fifo,
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
            if (status == WGPURequestAdapterStatus.WGPURequestAdapterStatus_Success)
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
            if (status == WGPURequestDeviceStatus.WGPURequestDeviceStatus_Success)
            {
                Device = device;
            }
            else
            {
                Console.WriteLine($"Could not get WebGPU device: { Helpers.GetString(message) }");
            }
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
                loadOp = WGPULoadOp.WGPULoadOp_Clear,
                storeOp = WGPUStoreOp.WGPUStoreOp_Store,
                clearValue = new WGPUColor() { r = 0f, g = 0f, b = 0f, a = 1.0f },
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
