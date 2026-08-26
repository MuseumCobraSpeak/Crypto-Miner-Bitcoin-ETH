using CryptoMinerBitcoinETH.Core.Models;
using Microsoft.Extensions.Logging;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public class CryptoMinerBitcoinETHDomainService : IDomainService
    {
        private readonly ILogger<CryptoMinerBitcoinETHDomainService> _logger;
        private readonly Random _random = new();

        public CryptoMinerBitcoinETHDomainService(ILogger<CryptoMinerBitcoinETHDomainService> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<object> GetSummaryAsync(CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Executing {MethodName} in {ServiceName}", "GetSummaryAsync", GetType().Name);
            return new object();
        }

        public async Task<object> SimulateAsync(CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Executing {MethodName} in {ServiceName}", "SimulateAsync", GetType().Name);
            return new object();
        }
    }
}
