using CryptoMinerBitcoinETH.Core.Models;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public interface ICryptoMinerBitcoinETHMiningRigRepository
    {
        Task SaveAsync(MiningRig item, CancellationToken cancellationToken = default);
        Task<List<MiningRig>> GetAllAsync(CancellationToken cancellationToken = default);
    }

    public class InMemoryCryptoMinerBitcoinETHMiningRigRepository : ICryptoMinerBitcoinETHMiningRigRepository
    {
        private readonly List<MiningRig> _items = new();
        private readonly SemaphoreSlim _lock = new(1, 1);

        public async Task SaveAsync(MiningRig item, CancellationToken cancellationToken = default)
        {
            await _lock.WaitAsync(cancellationToken);
            try { _items.Add(item); }
            finally { _lock.Release(); }
        }

        public async Task<List<MiningRig>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            await _lock.WaitAsync(cancellationToken);
            try { return _items.ToList(); }
            finally { _lock.Release(); }
        }
    }
}
