<#
.SYNOPSIS
	Evergine bindings NuGet Packages generator script, (c) 2023 Evergine Team
.DESCRIPTION
	This script generates NuGet packages for the low-level WebGPU bindings used in Wave Engine
	It's meant to have the same behavior when executed locally as when it's executed in a CI pipeline.
.EXAMPLE
	<script> -revision 1
.LINK
	https://evergine.com/
#>

param (
    [Parameter(mandatory = $true)][string]$revision,
	[string]$outputFolderBase = "nupkgs",
	[string]$buildVerbosity = "normal",
	[string]$buildConfiguration = "Release",
	[string]$debugSymbols = "true"
	# # [string]$flavour = "Browser"
)

# Set csproj path
# # $bindingsCsprojPath = "WebGPUGen\Evergine.Bindings.WebGPU.$flavour\Evergine.Bindings.WebGPU.$flavour.csproj"
$bindingsCsprojPath = "WebGPUGen\Evergine.Bindings.WebGPU\Evergine.Bindings.WebGPU.csproj"

# Utility functions
function LogDebug($line) { Write-Host "##[debug] $line" -Foreground Blue -Background Black }

# Compute version
$version = "$(Get-Date -Format "yyyy.M.d").$revision"

# Show variables
LogDebug "############## VARIABLES ##############"
LogDebug "Version.............: $version"
LogDebug "Build configuration.: $buildConfiguration"
LogDebug "Build verbosity.....: $buildVerbosity"
LogDebug "Output folder.......: $outputFolderBase"
LogDebug "#######################################"

# Create output folder
$outputFolder = Join-Path $outputFolderBase $version
New-Item -ItemType Directory -Force -Path $outputFolder
$absoluteOutputFolder = Resolve-Path $outputFolder

# Generate packages
LogDebug "START packaging process"
& dotnet pack "$bindingsCsprojPath" -v:$buildVerbosity -p:Configuration=$buildConfiguration -p:PackageOutputPath="$absoluteOutputFolder" -p:IncludeSymbols=$debugSymbols -p:Version=$version

LogDebug "END packaging process"