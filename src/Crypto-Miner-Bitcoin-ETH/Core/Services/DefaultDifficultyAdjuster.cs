using CryptoMinerBitcoinETH.Core.Models;
using Microsoft.Extensions.Logging;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public class DefaultDifficultyAdjuster : IDifficultyAdjuster
    {
        private readonly ILogger<DefaultDifficultyAdjuster> _logger;
        private readonly Random _random = new();

        public DefaultDifficultyAdjuster(ILogger<DefaultDifficultyAdjuster> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<NetworkDifficulty> GetCurrentDifficultyAsync(CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Executing {MethodName} in {ServiceName}", "GetCurrentDifficultyAsync", GetType().Name);
            return default(NetworkDifficulty)!;
        }

        public async Task<NetworkDifficulty> AdjustAsync(List<Block> recentBlocks, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Executing {MethodName} in {ServiceName}", "AdjustAsync", GetType().Name);
            return default(NetworkDifficulty)!;
        }
    }
}
