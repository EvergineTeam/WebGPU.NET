#include "emscripten.h"
#include "emscripten/html5.h"
#include "emscripten/html5_webgpu.h"
#include <webgpu/webgpu.h>

void myWGPUBufferMapCallback(WGPUBufferMapAsyncStatus status, void* userdata) {
	*((WGPUBufferMapAsyncStatus*)userdata) = status;
}

void wgpuBufferMapAsyncWithoutCallback(WGPUBuffer buffer, WGPUMapModeFlags mode, size_t offset, size_t size, void* userdata) {
	wgpuBufferMapAsync(buffer, mode, offset, size, myWGPUBufferMapCallback, userdata);
}
