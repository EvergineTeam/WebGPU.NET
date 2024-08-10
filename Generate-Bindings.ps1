<#
.SYNOPSIS
	Evergine bindings generator script, (c) 2022 Evergine Team
.DESCRIPTION
	This script generates WebGPU bindings used in Evergine
	It's meant to have the same behavior when executed locally as when it's executed in a CI pipeline.
.EXAMPLE
	<script>
.LINK
	https://evergine.com/
#>

param (
	[string]$buildVerbosity = "normal",
	[string]$buildConfiguration = "Release"
)

# Set csproj path
$webGPUGenCsprojPath = "WebGPUGen\WebGPUGen\WebGPUGen.csproj"

# Utility functions
function LogDebug($line)
{ Write-Host "##[debug] $line" -Foreground Blue -Background Black
}

# Show variables
LogDebug "############## VARIABLES ##############"
LogDebug "Build configuration.: $buildConfiguration"
LogDebug "Build verbosity.....: $buildVerbosity"
LogDebug "#######################################"

# Compile generator
LogDebug "START generator build process"
dotnet publish -v:$buildVerbosity -p:Configuration=$buildConfiguration $webGPUGenCsprojPath
if($?)
{
   LogDebug "END generator build process"
}
else
{
	LogDebug "ERROR; Generator build failed"
   	exit -1
}

# Run generator
LogDebug "START binding generator process"
pushd .\WebGPUGen\WebGPUGen\bin\Release\net8.0\win-x64
.\publish\WebGPUGen.exe
if($?)
{
   LogDebug "END binding generator process"
}
else
{
	LogDebug "ERROR; Binding Generation failed"
   	exit -1
}
popd