$ErrorActionPreference = "Stop"
$sln = Join-Path $PSScriptRoot "..\Crypto-Miner-Bitcoin-ETH.sln"
dotnet test $sln --configuration Release --verbosity normal
