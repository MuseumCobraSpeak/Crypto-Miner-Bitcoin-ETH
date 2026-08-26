using CryptoMinerBitcoinETH.Core.Models;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public interface IMiningService
    {
        Task<MiningSummary> MineAsync(string rigId, int durationSeconds, CancellationToken cancellationToken = default);
        Task<Block?> FindBlockAsync(string rigId, CancellationToken cancellationToken = default);
    }
}
