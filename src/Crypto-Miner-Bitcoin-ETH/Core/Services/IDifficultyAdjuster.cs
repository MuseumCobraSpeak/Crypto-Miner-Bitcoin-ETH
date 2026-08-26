using CryptoMinerBitcoinETH.Core.Models;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public interface IDifficultyAdjuster
    {
        Task<NetworkDifficulty> GetCurrentDifficultyAsync(CancellationToken cancellationToken = default);
        Task<NetworkDifficulty> AdjustAsync(List<Block> recentBlocks, CancellationToken cancellationToken = default);
    }
}
