using CryptoMinerBitcoinETH.Core.Models;
using Microsoft.Extensions.Logging;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public class MiningService : IMiningService
    {
        private readonly ILogger<MiningService> _logger;
        private readonly Random _random = new();

        public MiningService(ILogger<MiningService> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<MiningSummary> MineAsync(string rigId, int durationSeconds, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Executing {MethodName} in {ServiceName}", "MineAsync", GetType().Name);
            return default(MiningSummary)!;
        }

        public async Task<Block?> FindBlockAsync(string rigId, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Executing {MethodName} in {ServiceName}", "FindBlockAsync", GetType().Name);
            return default(Block?)!;
        }
    }
}
