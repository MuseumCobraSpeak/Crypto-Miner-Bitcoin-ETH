using CryptoMinerBitcoinETH.Core.Models;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public interface IRigRegistry
    {
        Task<IEnumerable<MiningRig>> GetRigsAsync(CancellationToken cancellationToken = default);
        Task<MiningRig?> GetRigAsync(string rigId, CancellationToken cancellationToken = default);
    }
}
