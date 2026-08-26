using CryptoMinerBitcoinETH.Core.Models;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public interface IRewardCalculator
    {
        Task<decimal> CalculateBlockRewardAsync(long blockHeight, CancellationToken cancellationToken = default);
        Task<decimal> EstimateFeeRevenueAsync(int transactionCount, CancellationToken cancellationToken = default);
    }
}
