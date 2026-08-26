using CryptoMinerBitcoinETH.Core.Models;
using Microsoft.Extensions.Logging;

namespace CryptoMinerBitcoinETH.Core.Services
{
    public class StaticRigRegistry : IRigRegistry
    {
        private readonly ILogger<StaticRigRegistry> _logger;
        private readonly Random _random = new();

        public StaticRigRegistry(ILogger<StaticRigRegistry> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IEnumerable<MiningRig>> GetRigsAsync(CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Executing {MethodName} in {ServiceName}", "GetRigsAsync", GetType().Name);
            return new List<MiningRig>();
        }

        public async Task<MiningRig?> GetRigAsync(string rigId, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Executing {MethodName} in {ServiceName}", "GetRigAsync", GetType().Name);
            return default(MiningRig?)!;
        }
    }
}
