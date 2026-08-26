using CryptoMinerBitcoinETH.Core.Models;
using Microsoft.Extensions.Logging;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public class RandomHashGenerator : IHashGenerator
    {
        private readonly ILogger<RandomHashGenerator> _logger;
        private readonly Random _random = new();

        public RandomHashGenerator(ILogger<RandomHashGenerator> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<HashAttempt> GenerateAsync(string rigId, long nonce, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Executing {MethodName} in {ServiceName}", "GenerateAsync", GetType().Name);
            return default(HashAttempt)!;
        }

        public async Task<bool> ValidateAsync(string hash, decimal difficulty, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Executing {MethodName} in {ServiceName}", "ValidateAsync", GetType().Name);
            return false;
        }
    }
}
