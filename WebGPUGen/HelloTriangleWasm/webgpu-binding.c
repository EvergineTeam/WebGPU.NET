#include "emscripten.h"
#include "emscripten/html5.h"
#include "emscripten/html5_webgpu.h"

WGPUDevice webgpu_binding_emscripten_webgpu_get_device() {
    return emscripten_webgpu_get_device();
}
