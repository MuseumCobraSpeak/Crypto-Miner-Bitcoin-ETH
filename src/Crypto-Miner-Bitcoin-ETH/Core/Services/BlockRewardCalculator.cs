using CryptoMinerBitcoinETH.Core.Models;
using Microsoft.Extensions.Logging;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public class BlockRewardCalculator : IRewardCalculator
    {
        private readonly ILogger<BlockRewardCalculator> _logger;
        private readonly Random _random = new();

        public BlockRewardCalculator(ILogger<BlockRewardCalculator> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<decimal> CalculateBlockRewardAsync(long blockHeight, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Executing {MethodName} in {ServiceName}", "CalculateBlockRewardAsync", GetType().Name);
            return 0m;
        }

        public async Task<decimal> EstimateFeeRevenueAsync(int transactionCount, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Executing {MethodName} in {ServiceName}", "EstimateFeeRevenueAsync", GetType().Name);
            return 0m;
        }
    }
}
