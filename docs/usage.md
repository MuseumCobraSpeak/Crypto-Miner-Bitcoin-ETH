# Usage Guide

## Running Crypto-Miner-Bitcoin-ETH

```bash
dotnet run --project src/Crypto-Miner-Bitcoin-ETH/Crypto-Miner-Bitcoin-ETH.csproj
```

## CLI Arguments

| Argument | Description |
|----------|-------------|
| `--config` | Path to a custom appsettings file. |
| `--verbose` | Enable verbose logging. |

## Sample Data

The `data/samples.json` file contains realistic-looking simulated data for local testing.

## Extending

Add new providers by implementing the domain interfaces in `Core/Services` and registering them in `Program.cs`.

## Domain

This project simulates **miningsimulator** concepts in a safe, local lab environment.
