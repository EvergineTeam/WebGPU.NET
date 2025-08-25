# WebGPU.NET

## Introduction

WebGPU.NET is a lightweight, low-level wrapper built on top of the Emscripten's [WebGPU header](https://github.com/emscripten-core/emscripten/blob/main/system/include/webgpu/webgpu.h). Our aim is to facilitate swift development of an adapter for Evergine, allowing for rapid testing across different browsers.

**NOTE:** On June 30th, 2025, we removed support for platforms different from browser, mainly because .NET SDK is highly coupled with a specific version of Emscripten (3.34 for .NET 8, for example). We would really like to bring them back in a future; however, we have not found an approach to support everything simultaneously.

[![CI](https://github.com/EvergineTeam/WebGPU.NET/actions/workflows/CI.yml/badge.svg)](https://github.com/EvergineTeam/WebGPU.NET/actions/workflows/CI.yml)
[![CD WebGPU](https://github.com/EvergineTeam/WebGPU.NET/actions/workflows/cd.yml/badge.svg)](https://github.com/EvergineTeam/WebGPU.NET/actions/workflows/cd.yml)
[![Nuget](https://img.shields.io/nuget/v/Evergine.Bindings.WebGPU?logo=nuget)](https://www.nuget.org/packages/Evergine.Bindings.WebGPU)

## Installation

To include `Evergine.Bindings.WebGPU` in your project, install the NuGet package:

`Install-Package Evergine.Bindings.WebGPU`

Or if you use the .NET CLI:

`dotnet add package Evergine.Bindings.WebGPU`

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
