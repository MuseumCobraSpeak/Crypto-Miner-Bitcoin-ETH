using CryptoMinerBitcoinETH.Core.Models;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public interface IBlockMiner
    {
        Task<Block> BuildBlockAsync(string rigId, long height, string previousHash, CancellationToken cancellationToken = default);
        Task<string> ComputeHashAsync(string data, long nonce, CancellationToken cancellationToken = default);
    }
}
