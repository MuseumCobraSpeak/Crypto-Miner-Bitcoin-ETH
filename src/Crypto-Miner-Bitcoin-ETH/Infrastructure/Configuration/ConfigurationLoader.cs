using Microsoft.Extensions.Configuration;
using CryptoMinerBitcoinETH.Core.Configuration;

namespace CryptoMinerBitcoinETH.Infrastructure.Configuration
{
    public static class ConfigurationLoader
    {
        public static IConfiguration Build(string[] args)
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables("MINING_")
                .Build();
        }

        public static MiningOptions BindOptions(this IConfiguration configuration)
        {
            var options = new MiningOptions();
            configuration.GetSection("Mining").Bind(options);
            return options;
        }
    }
}
