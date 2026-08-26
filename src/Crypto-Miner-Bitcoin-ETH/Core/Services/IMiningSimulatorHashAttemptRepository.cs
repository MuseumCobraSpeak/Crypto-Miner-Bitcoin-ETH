using CryptoMinerBitcoinETH.Core.Models;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public interface ICryptoMinerBitcoinETHHashAttemptRepository
    {
        Task SaveAsync(HashAttempt item, CancellationToken cancellationToken = default);
        Task<List<HashAttempt>> GetAllAsync(CancellationToken cancellationToken = default);
    }

    public class InMemoryCryptoMinerBitcoinETHHashAttemptRepository : ICryptoMinerBitcoinETHHashAttemptRepository
    {
        private readonly List<HashAttempt> _items = new();
        private readonly SemaphoreSlim _lock = new(1, 1);

        public async Task SaveAsync(HashAttempt item, CancellationToken cancellationToken = default)
        {
            await _lock.WaitAsync(cancellationToken);
            try { _items.Add(item); }
            finally { _lock.Release(); }
        }

        public async Task<List<HashAttempt>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            await _lock.WaitAsync(cancellationToken);
            try { return _items.ToList(); }
            finally { _lock.Release(); }
        }
    }
}
