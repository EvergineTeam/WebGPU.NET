struct VertexInput {
    @location(0) position: vec4f,
    @location(1) color: vec4f,
};

/**
 * A structure with fields labeled with builtins and locations can also be used
 * as *output* of the vertex shader, which is also the input of the fragment
 * shader.
 */
struct VertexOutput {
    @builtin(position) position: vec4f,
    // The location here does not refer to a vertex attribute, it just means
    // that this field must be handled by the rasterizer.
    // (It can also refer to another field of another struct that would be used
    // as input to the fragment shader.)
    @location(0) color: vec4f,
};

@vertex
fn vertexMain(in: VertexInput) -> VertexOutput {
    var out: VertexOutput;
    out.position = in.position;
    out.color = in.color; // forward to the fragment shader
    return out;
}

@fragment
fn fragmentMain(in: VertexOutput) -> @location(0) vec4f {
    return in.color;
}
