namespace CryptoMinerBitcoinETH.Core.Configuration
{
    public class MiningOptions
    {
        public int RefreshIntervalMs { get; set; } = 30000;
        public string DataEndpoint { get; set; } = "https://lab.example.com/mining";
    }
}
