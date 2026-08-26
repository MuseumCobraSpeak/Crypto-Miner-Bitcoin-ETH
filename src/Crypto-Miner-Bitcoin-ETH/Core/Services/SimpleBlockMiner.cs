using CryptoMinerBitcoinETH.Core.Models;
using Microsoft.Extensions.Logging;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public class SimpleBlockMiner : IBlockMiner
    {
        private readonly ILogger<SimpleBlockMiner> _logger;
        private readonly Random _random = new();

        public SimpleBlockMiner(ILogger<SimpleBlockMiner> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Block> BuildBlockAsync(string rigId, long height, string previousHash, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Executing {MethodName} in {ServiceName}", "BuildBlockAsync", GetType().Name);
            return default(Block)!;
        }

        public async Task<string> ComputeHashAsync(string data, long nonce, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Executing {MethodName} in {ServiceName}", "ComputeHashAsync", GetType().Name);
            return string.Empty;
        }
    }
}
