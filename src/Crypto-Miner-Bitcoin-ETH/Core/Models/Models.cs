namespace CryptoMinerBitcoinETH.Core.Models
{
    public class MiningRig
    {
        public string RigId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal HashRateThs { get; set; }
        public decimal PowerWatts { get; set; }
        public decimal EfficiencyJTh { get; set; }
        public bool IsActive { get; set; } = true;
    }

    public class Block
    {
        public long BlockHeight { get; set; }
        public string BlockHash { get; set; } = string.Empty;
        public string MinerRigId { get; set; } = string.Empty;
        public decimal Reward { get; set; }
        public long Nonce { get; set; }
        public DateTime MinedAt { get; set; } = DateTime.UtcNow;
    }

    public class NetworkDifficulty
    {
        public long Epoch { get; set; }
        public decimal Difficulty { get; set; }
        public DateTime AdjustedAt { get; set; } = DateTime.UtcNow;
    }

    public class HashAttempt
    {
        public string RigId { get; set; } = string.Empty;
        public long Nonce { get; set; }
        public string Hash { get; set; } = string.Empty;
        public bool IsSuccess { get; set; }
        public DateTime AttemptedAt { get; set; } = DateTime.UtcNow;
    }

    public class MiningReward
    {
        public string RigId { get; set; } = string.Empty;
        public long BlockHeight { get; set; }
        public decimal Amount { get; set; }
        public decimal FeeRevenue { get; set; }
        public DateTime EarnedAt { get; set; } = DateTime.UtcNow;
    }

    public class MiningSummary
    {
        public string RigId { get; set; } = string.Empty;
        public long BlocksMined { get; set; }
        public decimal TotalRewards { get; set; }
        public decimal TotalHashAttempts { get; set; }
        public decimal AverageTimePerBlockMs { get; set; }
    }
}
