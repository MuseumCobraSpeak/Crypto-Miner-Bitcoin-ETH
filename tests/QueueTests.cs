using CryptoMinerBitcoinETH.Core.Models;
using CryptoMinerBitcoinETH.Infrastructure.Queue;
using Microsoft.Extensions.Logging.Abstractions;
using Xunit;

namespace CryptoMinerBitcoinETH.Tests
{
    public class QueueTests
    {
        [Fact]
        public async Task JobQueue_EnqueueAndDequeue()
        {
            var queue = new InMemoryJobQueue(NullLogger<InMemoryJobQueue>.Instance);
            await queue.EnqueueAsync(new Job { Name = "test" });
            var job = await queue.DequeueAsync();
            Assert.NotNull(job);
            Assert.Equal("test", job.Name);
        }
    }
}
