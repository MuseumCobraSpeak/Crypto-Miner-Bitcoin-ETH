using CryptoMinerBitcoinETH.Core.Models;
using Microsoft.Extensions.Logging;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public class EndpointHealthChecker : IHealthChecker
    {
        private readonly ILogger<EndpointHealthChecker> _logger;
        private readonly Random _random = new();

        public EndpointHealthChecker(ILogger<EndpointHealthChecker> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<bool> CheckAsync(CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Executing {MethodName} in {ServiceName}", "CheckAsync", GetType().Name);
            return false;
        }

        public async Task<bool> HealthCheckAsync(CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Executing {MethodName} in {ServiceName}", "HealthCheckAsync", GetType().Name);
            return false;
        }
    }
}
