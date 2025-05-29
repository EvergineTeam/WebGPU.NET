#include "emscripten.h"
#include "emscripten/html5.h"
#include "emscripten/html5_webgpu.h"
#include <webgpu/webgpu.h>

void webgpu_native_emscripten_get_element_css_size(const char* target, double* width, double* height) {
    emscripten_get_element_css_size(target, width, height);
}

WGPUDevice webgpu_native_emscripten_webgpu_get_device() {
    return emscripten_webgpu_get_device();
}
