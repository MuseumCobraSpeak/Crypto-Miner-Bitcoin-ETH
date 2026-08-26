using CryptoMinerBitcoinETH.Core.Models;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public interface ICryptoMinerBitcoinETHMiningRewardRepository
    {
        Task SaveAsync(MiningReward item, CancellationToken cancellationToken = default);
        Task<List<MiningReward>> GetAllAsync(CancellationToken cancellationToken = default);
    }

    public class InMemoryCryptoMinerBitcoinETHMiningRewardRepository : ICryptoMinerBitcoinETHMiningRewardRepository
    {
        private readonly List<MiningReward> _items = new();
        private readonly SemaphoreSlim _lock = new(1, 1);

        public async Task SaveAsync(MiningReward item, CancellationToken cancellationToken = default)
        {
            await _lock.WaitAsync(cancellationToken);
            try { _items.Add(item); }
            finally { _lock.Release(); }
        }

        public async Task<List<MiningReward>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            await _lock.WaitAsync(cancellationToken);
            try { return _items.ToList(); }
            finally { _lock.Release(); }
        }
    }
}
