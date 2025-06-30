const initWebGPU = async () => {
    const adapter = await navigator.gpu.requestAdapter();
    const device = await adapter.requestDevice();
    Module.preinitializedWebGPUDevice = device;
}

initWebGPU();