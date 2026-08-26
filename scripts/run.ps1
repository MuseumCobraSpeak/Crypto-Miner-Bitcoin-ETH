$ErrorActionPreference = "Stop"
$project = Join-Path $PSScriptRoot "..\src\Crypto-Miner-Bitcoin-ETH\Crypto-Miner-Bitcoin-ETH.csproj"
dotnet run --project $project -- @args
