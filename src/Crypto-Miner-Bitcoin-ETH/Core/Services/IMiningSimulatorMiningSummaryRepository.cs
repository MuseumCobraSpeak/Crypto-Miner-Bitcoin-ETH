using CryptoMinerBitcoinETH.Core.Models;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public interface ICryptoMinerBitcoinETHMiningSummaryRepository
    {
        Task SaveAsync(MiningSummary item, CancellationToken cancellationToken = default);
        Task<List<MiningSummary>> GetAllAsync(CancellationToken cancellationToken = default);
    }

    public class InMemoryCryptoMinerBitcoinETHMiningSummaryRepository : ICryptoMinerBitcoinETHMiningSummaryRepository
    {
        private readonly List<MiningSummary> _items = new();
        private readonly SemaphoreSlim _lock = new(1, 1);

        public async Task SaveAsync(MiningSummary item, CancellationToken cancellationToken = default)
        {
            await _lock.WaitAsync(cancellationToken);
            try { _items.Add(item); }
            finally { _lock.Release(); }
        }

        public async Task<List<MiningSummary>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            await _lock.WaitAsync(cancellationToken);
            try { return _items.ToList(); }
            finally { _lock.Release(); }
        }
    }
}
