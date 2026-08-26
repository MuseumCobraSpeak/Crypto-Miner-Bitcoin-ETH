using CryptoMinerBitcoinETH.Core.Models;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public interface IHealthChecker
    {
        Task<bool> CheckAsync(CancellationToken cancellationToken = default);
        Task<bool> HealthCheckAsync(CancellationToken cancellationToken = default);
    }
}
