# Architecture

Crypto-Miner-Bitcoin-ETH is a modular console simulator for mining. It separates concerns into Core, Infrastructure, and entry point layers.

## Layers

```
Program
  |
  +-- Domain Service
        |
        +-- Specialized Providers
        +-- In-Memory Repository
        +-- Configuration
```

## Key Components

| Component | Responsibility |
|-----------|---------------|
| `IDomainService` | Orchestrates simulation and analysis logic. |
| `IDataProvider` / domain providers | Fetches simulated mining data. |
| `IRepository` | In-memory storage of snapshots and results. |
| `IConfigurationLoader` | Loads settings from JSON and environment variables. |
| `ILogger` | Writes structured log output. |
