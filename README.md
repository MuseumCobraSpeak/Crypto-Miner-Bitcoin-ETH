# Crypto-Miner-Bitcoin-ETH

<p align="center">
  <img src="https://img.shields.io/badge/C%23-10.0-239120?style=for-the-badge&logo=csharp" alt="C# 10.0">
  <img src="https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet" alt=".NET 10">
  <img src="https://img.shields.io/badge/platform-Windows%20%7C%20Linux%20%7C%20macOS-0078D4?style=for-the-badge" alt="Platform">
</p>

<p align="center">
  <img src="https://img.shields.io/badge/build-passing-brightgreen?style=flat-square" alt="Build">
  <img src="https://img.shields.io/badge/tests-xUnit-6C4AB6?style=flat-square" alt="Tests">
  <img src="https://img.shields.io/badge/CI-GitHub%20Actions-2088FF?style=flat-square&logo=githubactions" alt="CI">
  <img src="https://img.shields.io/badge/license-MIT-green?style=flat-square" alt="License">
</p>

<h2 align="center">A modular console proof-of-work mining simulator</h2>

<p align="center">
  <strong>Crypto-Miner-Bitcoin-ETH</strong> is a research-oriented, educational console module for developers, analysts, and crypto enthusiasts who need a structured, extensible foundation for exploring mining concepts, data aggregation, and simulation logic in a safe, local lab environment.
</p>

---

> This project is intended for educational labs, CTF exercises, and authorized research only. It does not interact with real blockchains, exchanges, or user funds.

## Why Crypto-Miner-Bitcoin-ETH?

Real-world mining systems are complex, closed-source, and often risky to experiment with. Crypto-Miner-Bitcoin-ETH bridges the gap by offering a local, safe sandbox with enterprise-grade .NET architecture:

- A **clean, layered architecture** with Core, Infrastructure, and Tests.
- **Dependency injection**, structured logging, and configuration-driven behavior.
- **Domain-specific services** for realistic simulation logic.
- **A built-in test suite** covering core calculations and orchestration.
- **CI/CD pipeline** ready to run on every push and pull request.

## Features

| Feature | Description |
|---------|-------------|
| **Simulation engine** | Run deterministic or randomized mining simulations. |
| **Domain-specific services** | Multiple interfaces and implementations for core domain logic. |
| **In-memory repository** | Thread-safe storage for snapshots, results, and history. |
| **Configuration-driven** | JSON and environment-variable configuration support. |
| **Structured logging** | Color-coded console logs with Microsoft.Extensions.Logging. |
| **xUnit test suite** | Unit tests covering services and providers. |
| **GitHub Actions CI** | Automated build and test pipeline on Windows runners. |
| **Mining** | rig registry with hashrate and power metrics |
| **Random** | hash generator with difficulty validation |
| **Network** | difficulty adjustment simulation |
| **Block** | miner with nonce and hash computation |
| **Block** | reward calculator with halving epochs |
| **Mining** | summary and statistics |

## Architecture

```
Crypto-Miner-Bitcoin-ETH
├── src/Crypto-Miner-Bitcoin-ETH
│   ├── Core
│   │   ├── Configuration       # MiningOptions
│   │   ├── Constants           # Domain constants
│   │   ├── Enums               # Status enum
│   │   ├── Models              # Domain entities
│   │   ├── Services            # Domain services and interfaces
│   │   ├── Utils               # ValidationUtils, ArgumentParser
│   │   └── Exceptions          # Domain exception hierarchy
│   └── Infrastructure
│       ├── Background          # DomainHostedService
│       ├── Clients             # SimulatedExternalDataClient
│       ├── Configuration       # ConfigurationLoader
│       ├── ConsoleUi           # MenuRenderer
│       ├── Logging             # ConsoleLogger
│       ├── Metrics             # ConsoleMetricsPublisher
│       ├── Persistence         # JsonRepository<T>
│       └── Validation          # DefaultRequestValidator
├── tests/Crypto-Miner-Bitcoin-ETH.Tests          # xUnit tests
├── config                      # appsettings.json, dev/prod overrides
├── data                        # samples.json
├── docs                        # architecture, security, api, development, usage, faq
└── scripts                     # build.ps1, run.ps1, test.ps1
```

## Quick Start

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download) or later

### Installation

```bash
git clone https://github.com/yourusername/Crypto-Miner-Bitcoin-ETH.git
cd Crypto-Miner-Bitcoin-ETH
dotnet restore Crypto-Miner-Bitcoin-ETH.sln
dotnet build Crypto-Miner-Bitcoin-ETH.sln
```

### Interactive Usage

```bash
dotnet run --project src/Crypto-Miner-Bitcoin-ETH/Crypto-Miner-Bitcoin-ETH.csproj
scripts/run.ps1
```

### Example Session

```
  ╔══════════════════════════════════════════════════════════╗
  ║              Crypto-Miner-Bitcoin-ETH - PoW Mining Simulator        ║
  ║        Educational simulation for proof-of-work mining     ║
  ╚══════════════════════════════════════════════════════════╝

Select an option:
  1. List mining rigs
  2. Mine for blocks
  3. Show mining summary
  4. Check network difficulty
  5. Simulate hash attempts
  6. Exit
> 2
Rig ID: rig-01
Duration (seconds): 60
[+] Mining started: 110 TH/s
[+] Blocks mined: 3
[+] Total rewards: 18.75000000 BTC
[+] Network difficulty: 84.35 T

```

## Configuration

Edit `config/appsettings.json`:

```json
{
  "Mining": {
    "RefreshIntervalMs": 30000,
    "DataEndpoint": "https://lab.example.com/mining",
    "LogLevel": "Information"
  }
}
```

Environment variables prefixed with `MINING_` are also supported.

## Roadmap

- [ ] Stratum protocol simulation
- [ ] Mining pool share tracking
- [ ] Power cost and profitability calculator
- [ ] ASIC efficiency comparison
- [ ] Block propagation latency model

## Documentation

- [Architecture](docs/architecture.md)
- [Security & Threat Model](docs/security.md)
- [Development Guide](docs/development.md)
- [API Reference](docs/api.md)

## Contributing

We welcome contributions. Please read [CONTRIBUTING.md](CONTRIBUTING.md) for guidelines.

## License

Crypto-Miner-Bitcoin-ETH is released under the MIT License. See [LICENSE](LICENSE) for details.

## Performance & Extensibility

Crypto-Miner-Bitcoin-ETH is built for clarity and extension:

- **No real network calls** by default — all simulations run locally.
- **Provider pattern** makes swapping in real adapters straightforward.
- **JSON persistence** layer for caching simulated results.
- **Metrics publisher** ready for console, Prometheus, or cloud sinks.
- **Background service** template for periodic polling tasks.
- **xUnit test suite** with core and additional integration-style tests.

## Sample Data

A sample dataset is included in `data/samples.json` to demonstrate the expected input/output shape for mining workflows.

## FAQ

See [docs/faq.md](docs/faq.md) for common questions.

## Usage

See [docs/usage.md](docs/usage.md) for detailed usage instructions.

---

<p align="center">
  Built with .NET 10 for researchers, developers, and crypto enthusiasts.
</p>
