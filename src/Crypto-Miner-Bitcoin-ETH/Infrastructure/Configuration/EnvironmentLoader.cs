using Microsoft.Extensions.Configuration;

namespace CryptoMinerBitcoinETH.Infrastructure.Configuration
{
    public static class EnvironmentLoader
    {
        public static IConfigurationRoot Load(string[]? args = null)
        {
            return new ConfigurationBuilder()
                .AddEnvironmentVariables("MININGSIMULATOR_")
                .AddCommandLine(args ?? Array.Empty<string>())
                .Build();
        }
    }
}
