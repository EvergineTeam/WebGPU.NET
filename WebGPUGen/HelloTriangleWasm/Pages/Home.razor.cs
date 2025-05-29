using Evergine.Bindings.WebGPU;
using static Evergine.Bindings.WebGPU.WebGPUNative;
using static HelloTriangleWasm.WebGPUEmscripten;

namespace HelloTriangleWasm.Pages
{
    public partial class Home
    {
        public unsafe void Run()
        {
            var device = webgpu_native_emscripten_webgpu_get_device();
            var queue = wgpuDeviceGetQueue(device);
            double width, height;
            webgpu_native_emscripten_get_element_css_size("canvas".ToPointer(), &width, &height);
            var surfaceDescriptorFromCanvasHTMLSelector = new WGPUSurfaceDescriptorFromCanvasHTMLSelector()
            {
                chain = new WGPUChainedStruct() 
                { 
                    sType = WGPUSType.SurfaceDescriptorFromCanvasHTMLSelector,
                },
                selector = "canvas".ToPointer(),
            };
            var surfaceDescriptor = new WGPUSurfaceDescriptor()
            {
                nextInChain = (WGPUChainedStruct*)&surfaceDescriptorFromCanvasHTMLSelector,
            };
            var surface = wgpuInstanceCreateSurface(instance: IntPtr.Zero, &surfaceDescriptor);
            var swapChainDescriptor = new WGPUSwapChainDescriptor()
            {
                usage = WGPUTextureUsage.RenderAttachment,
                format = WGPUTextureFormat.BGRA8Unorm,
                width = (uint)width,
                height = (uint)height,
                presentMode = WGPUPresentMode.Fifo,
            };
            var swapChain = wgpuDeviceCreateSwapChain(device, surface, &swapChainDescriptor);
            var triangleWGSL = @"
// attribute/uniform decls

struct VertexIn {
    @location(0) aPos : vec2<f32>,
    @location(1) aCol : vec3<f32>,
};
struct VertexOut {
    @location(0) vCol : vec3<f32>,
    @builtin(position) Position : vec4<f32>,
};
struct Rotation {
    @location(0) degs : f32,
};
@group(0) @binding(0) var<uniform> uRot : Rotation;

// vertex shader

@vertex
fn vs_main(input : VertexIn) -> VertexOut {
    var rads : f32 = radians(uRot.degs);
    var cosA : f32 = cos(rads);
    var sinA : f32 = sin(rads);
    var rot : mat3x3<f32> = mat3x3<f32>(
        vec3<f32>( cosA, sinA, 0.0),
        vec3<f32>(-sinA, cosA, 0.0),
        vec3<f32>( 0.0,  0.0,  1.0));
    var output : VertexOut;
    output.Position = vec4<f32>(rot * vec3<f32>(input.aPos, 1.0), 1.0);
    output.vCol = input.aCol;
    return output;
}

// fragment shader

@fragment
fn fs_main(@location(0) vCol : vec3<f32>) -> @location(0) vec4<f32> {
    return vec4<f32>(vCol, 1.0);
}
";
            var shader_triangle = create_shader(triangleWGSL, label: default, device);
            WGPUVertexAttribute* vertex_attrib = stackalloc WGPUVertexAttribute[]
            {
                // position: x, y
                new WGPUVertexAttribute()
                {
                    format = WGPUVertexFormat.Float32x2,
                    offset = 0,
                    shaderLocation = 0,
                },
                // color: r, g, b
                new WGPUVertexAttribute()
                {
                    format = WGPUVertexFormat.Float32x3,
                    offset = 2 * sizeof(float),
                    shaderLocation = 1,
                }
            };
            WGPUVertexBufferLayout vertex_buffer_layout = new WGPUVertexBufferLayout
            {
                arrayStride = 5 * sizeof(float),
                attributeCount = 2,
                attributes = vertex_attrib,
            };

            // describe pipeline layout
            var entries = stackalloc WGPUBindGroupLayoutEntry[]
            {
                new WGPUBindGroupLayoutEntry()
                {
                    binding = 0,
                    visibility = WGPUShaderStage.Vertex,
                    // buffer binding layout
                    buffer = new WGPUBufferBindingLayout()
                    {
                        type = WGPUBufferBindingType.Uniform,
                    },
                },
            };
            var bindGroupLayoutDescriptor = new WGPUBindGroupLayoutDescriptor()
            {
                entryCount = 1,
                // bind group layout entry
                entries = entries,
            };
            WGPUBindGroupLayout bindgroup_layout = wgpuDeviceCreateBindGroupLayout(device, &bindGroupLayoutDescriptor);
            var pipelineLayoutDescriptor = new WGPUPipelineLayoutDescriptor()
            {
                bindGroupLayoutCount = 1,
                bindGroupLayouts = &bindgroup_layout,
            };
            WGPUPipelineLayout pipeline_layout = wgpuDeviceCreatePipelineLayout(device, &pipelineLayoutDescriptor);
            // create pipeline
            var blendState = new WGPUBlendState()
            {
                color = new WGPUBlendComponent()
                {
                    operation = WGPUBlendOperation.Add,
                    srcFactor = WGPUBlendFactor.One,
                    dstFactor = WGPUBlendFactor.One,
                },
                alpha = {
                    operation = WGPUBlendOperation.Add,
                    srcFactor = WGPUBlendFactor.One,
                    dstFactor = WGPUBlendFactor.One,
                },
            };
            var targetState = new WGPUColorTargetState()
            {
                format = WGPUTextureFormat.BGRA8Unorm,
                writeMask = WGPUColorWriteMask.All,
                // blend state
                blend = &blendState,
            };
            var fragmentState = new WGPUFragmentState()
            {
                module = shader_triangle,
                entryPoint = "fs_main".ToPointer(),
                targetCount = 1,
                // color target state
                targets = &targetState,
            };
            var renderPipelineDescriptor = new WGPURenderPipelineDescriptor()
            {
                // pipeline layout
                layout = pipeline_layout,
                // vertex state
                vertex = new WGPUVertexState()
                {
                    module = shader_triangle,
                    entryPoint = "vs_main".ToPointer(),
                    bufferCount = 1,
                    buffers = &vertex_buffer_layout,
                },
                // primitive state
                primitive = new WGPUPrimitiveState()
                {
                    frontFace = WGPUFrontFace.CCW,
                    cullMode = WGPUCullMode.None,
                    topology = WGPUPrimitiveTopology.TriangleList,
                    stripIndexFormat = WGPUIndexFormat.Undefined,
                },
                // fragment state
                fragment = &fragmentState,
                // multi-sampling state
                multisample = new WGPUMultisampleState()
                {
                    count = 1,
                    mask = 0xFFFFFFFF,
                    alphaToCoverageEnabled = false,
                },
                // depth-stencil state
                depthStencil = null,
            };
            var pipeline = wgpuDeviceCreateRenderPipeline(device, &renderPipelineDescriptor);
            wgpuBindGroupLayoutRelease(bindgroup_layout);
            wgpuPipelineLayoutRelease(pipeline_layout);
            wgpuShaderModuleRelease(shader_triangle);
            // create the vertex buffer (x, y, r, g, b) and index buffer
            var vertex_data = stackalloc float[]
            {
                // x, y          // r, g, b
               -0.5f, -0.5f,     1.0f, 0.0f, 0.0f, // bottom-left
                0.5f, -0.5f,     0.0f, 1.0f, 0.0f, // bottom-right
                0.5f,  0.5f,     0.0f, 0.0f, 1.0f, // top-right
               -0.5f,  0.5f,     1.0f, 1.0f, 0.0f, // top-left
            };
            var index_data = stackalloc ushort[]
            {
                0, 1, 2,
                0, 2, 3,
            };
            // TODO fix TypeError: Cannot mix BigInt and other types, use explicit conversions
            //var vbuffer = create_buffer(vertex_data, 5 * 4 * sizeof(float), WGPUBufferUsage.Vertex, device, queue);
            //var ibuffer = create_buffer(index_data, 3 * 2 * sizeof(float), WGPUBufferUsage.Index, device, queue);
            //// create the uniform bind group
            //float rot;
            //var ubuffer = create_buffer(&rot, 1, WGPUBufferUsage.Uniform, device, queue);
            //var bindGroupEntry = new WGPUBindGroupEntry()
            //{
            //    binding = 0,
            //    offset = 0,
            //    buffer = ubuffer,
            //    size = 1,
            //};
            //var bindGroupDescriptor = new WGPUBindGroupDescriptor()
            //{
            //    layout = wgpuRenderPipelineGetBindGroupLayout(pipeline, 0),
            //    entryCount = 1,
            //    // bind group entry
            //    entries = &bindGroupEntry,
            //};
            //var bindgroup = wgpuDeviceCreateBindGroup(device, &bindGroupDescriptor);
            draw(swapChain, device, queue);
        }

        private unsafe WGPUBuffer create_buffer(void* data, ulong size, WGPUBufferUsage usage, WGPUDevice device, WGPUQueue queue)
        {
            var bufferDescriptor = new WGPUBufferDescriptor()
            {
                usage = WGPUBufferUsage.CopyDst,
                size = size,
            };
            WGPUBuffer buffer = wgpuDeviceCreateBuffer(device, &bufferDescriptor);
            wgpuQueueWriteBuffer(queue, buffer, 0u, data, size);
            
            return buffer;
        }

        private unsafe WGPUShaderModule create_shader(string code, string? label, WGPUDevice device)
        {
            var shaderModuleWGSLDescriptor = new WGPUShaderModuleWGSLDescriptor
            {
                chain = new WGPUChainedStruct() 
                { 
                    sType = WGPUSType.ShaderModuleWGSLDescriptor,
                },
                source = code.ToPointer(),
            };
            var shaderModuleDescriptor = new WGPUShaderModuleDescriptor()
            {
                nextInChain = (WGPUChainedStruct*)&shaderModuleWGSLDescriptor,
                label = label == default ? null : label.ToPointer(),
            };
            var shaderModule = wgpuDeviceCreateShaderModule(device, &shaderModuleDescriptor);
            
            return shaderModule;
        }

        private unsafe void draw(WGPUSwapChain swapchain, WGPUDevice device, WGPUQueue queue)
        {
            // create texture view
            WGPUTextureView back_buffer = wgpuSwapChainGetCurrentTextureView(swapchain);

            // create command encoder
            WGPUCommandEncoder cmd_encoder = wgpuDeviceCreateCommandEncoder(device, null);

            // begin render pass
            var colorAttachment = new WGPURenderPassColorAttachment()
            {
                view = back_buffer,
                loadOp = WGPULoadOp.Clear,
                storeOp = WGPUStoreOp.Store,
                clearValue = new WGPUColor()
                { 
                    r = 1.0f, 
                    g = 0.0f, 
                    b = 1.0f, 
                    a = 1.0f,
                },
            };
            var renderPassDescriptor = new WGPURenderPassDescriptor()
            {
                // color attachments
                colorAttachmentCount = 1,
                colorAttachments = &colorAttachment,
            };
            WGPURenderPassEncoder render_pass = wgpuCommandEncoderBeginRenderPass(cmd_encoder, &renderPassDescriptor);

            // end render pass
            wgpuRenderPassEncoderEnd(render_pass);

            // create command buffer
            WGPUCommandBuffer cmd_buffer = wgpuCommandEncoderFinish(cmd_encoder, null); // after 'end render pass'

            // submit commands    
            wgpuQueueSubmit(queue, 1, &cmd_buffer);

            // release all
            wgpuRenderPassEncoderRelease(render_pass);
            wgpuCommandEncoderRelease(cmd_encoder);
            wgpuCommandBufferRelease(cmd_buffer);
            wgpuTextureViewRelease(back_buffer);
        }
    }
}
