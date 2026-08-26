using CryptoMinerBitcoinETH.Core.Services;
using Microsoft.Extensions.Logging.Abstractions;
using Xunit;

namespace CryptoMinerBitcoinETH.Tests
{
    public class CryptoMinerBitcoinETHTests
    {
        private readonly IDomainService _service;

        public CryptoMinerBitcoinETHTests()
        {
            _service = new CryptoMinerBitcoinETHDomainService(NullLogger<CryptoMinerBitcoinETHDomainService>.Instance);
        }

        [Fact]
        public async Task GetSummaryAsync_ReturnsResult()
        {
            var result = await _service.GetSummaryAsync();
            Assert.NotNull(result);
        }

        [Fact]
        public async Task SimulateAsync_ThrowsNotImplementedException()
        {
            await Assert.ThrowsAsync<NotImplementedException>(() => _service.SimulateAsync());
        }
    }
}
