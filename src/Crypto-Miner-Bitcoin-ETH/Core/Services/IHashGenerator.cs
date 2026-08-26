using CryptoMinerBitcoinETH.Core.Models;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public interface IHashGenerator
    {
        Task<HashAttempt> GenerateAsync(string rigId, long nonce, CancellationToken cancellationToken = default);
        Task<bool> ValidateAsync(string hash, decimal difficulty, CancellationToken cancellationToken = default);
    }
}
