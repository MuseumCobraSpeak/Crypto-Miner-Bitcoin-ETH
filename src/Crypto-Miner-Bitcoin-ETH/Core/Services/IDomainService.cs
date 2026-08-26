using CryptoMinerBitcoinETH.Core.Models;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public interface IDomainService
    {
        Task<object> GetSummaryAsync(CancellationToken cancellationToken = default);
        Task<object> SimulateAsync(CancellationToken cancellationToken = default);
    }
}
