param(
    [ValidateSet("Debug", "Release")]
    [string]$Configuration = "Debug"
)
$ErrorActionPreference = "Stop"
$sln = Join-Path $PSScriptRoot "..\Crypto-Miner-Bitcoin-ETH.sln"
dotnet restore $sln
dotnet build $sln --configuration $Configuration
if ($LASTEXITCODE -ne 0) { throw "Build failed" }
dotnet test $sln --configuration $Configuration
