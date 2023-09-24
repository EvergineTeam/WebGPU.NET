# WebGPU.NET

## Introduction

WebGPU.NET is a lightweight, low-level wrapper built on top of the `wgpu-native` library from Firefox. Our aim is to facilitate swift development of an adapter for Evergine, allowing for rapid testing across Windows, Linux, and Mac platforms using DirectX, Vulkan, and Metal.

## Features

- **Low-level Access**: Get closer to the metal with our streamlined API that wraps `wgpu-native`.
  
- **Cross-Platform Support**: Test and deploy your applications seamlessly on Windows, Linux, and Mac.

- **Multiple Graphics API Compatibility**: Designed with DirectX, Vulkan, and Metal in mind.

## Prerequisites

List any dependencies, required libraries, or external factors here.

## Installation

1. Clone the repository: `git clone https://github.com/EvergineTeam/WebGPU.NET.git`
2. Navigate to the project directory.
3. Run the HelloTriangle test project.

### Usage

To include `Evergine.Bindings.WebGPU` in your project, install the NuGet package:

Install-Package Evergine.Bindings.WebGPU

Or if you use the .NET CLI:

dotnet add package Evergine.Bindings.WebGPU

## License

This project is licensed under the MIT License - see the [LICENSE.md](link_to_license.md) file for details.

## Acknowledgments

- Thanks to the Firefox team for the `wgpu-native` library. Check out the original library on [gfx-rs/wgpu-native](https://github.com/gfx-rs/wgpu-native).
