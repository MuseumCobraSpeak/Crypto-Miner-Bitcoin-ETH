using CryptoMinerBitcoinETH.Core.Models;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public interface ICryptoMinerBitcoinETHNetworkDifficultyRepository
    {
        Task SaveAsync(NetworkDifficulty item, CancellationToken cancellationToken = default);
        Task<List<NetworkDifficulty>> GetAllAsync(CancellationToken cancellationToken = default);
    }

    public class InMemoryCryptoMinerBitcoinETHNetworkDifficultyRepository : ICryptoMinerBitcoinETHNetworkDifficultyRepository
    {
        private readonly List<NetworkDifficulty> _items = new();
        private readonly SemaphoreSlim _lock = new(1, 1);

        public async Task SaveAsync(NetworkDifficulty item, CancellationToken cancellationToken = default)
        {
            await _lock.WaitAsync(cancellationToken);
            try { _items.Add(item); }
            finally { _lock.Release(); }
        }

        public async Task<List<NetworkDifficulty>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            await _lock.WaitAsync(cancellationToken);
            try { return _items.ToList(); }
            finally { _lock.Release(); }
        }
    }
}
