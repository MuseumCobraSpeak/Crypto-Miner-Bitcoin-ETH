using CryptoMinerBitcoinETH.Core.Configuration;
using CryptoMinerBitcoinETH.Core.Services;
using CryptoMinerBitcoinETH.Core.Utils;
using CryptoMinerBitcoinETH.Infrastructure.Configuration;
using CryptoMinerBitcoinETH.Infrastructure.ConsoleUi;
using CryptoMinerBitcoinETH.Infrastructure.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CryptoMinerBitcoinETH
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "CryptoMinerBitcoinETH";
            var arguments = ArgumentParser.Parse(args);
            var services = ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();
            var logger = serviceProvider.GetRequiredService<ILogger<Program>>();
            var domainService = serviceProvider.GetRequiredService<IDomainService>();
            var healthChecker = serviceProvider.GetRequiredService<IHealthChecker>();
            var menuRenderer = serviceProvider.GetRequiredService<MenuRenderer>();

            logger.LogInformation("CryptoMinerBitcoinETH simulator started");
            await healthChecker.CheckAsync(CancellationToken.None);
            PrintBanner();
            await RunInteractiveLoop(domainService, menuRenderer, logger, CancellationToken.None);
        }

        static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();
            var configuration = ConfigurationLoader.Build(Array.Empty<string>());
            services.AddSingleton(configuration);
            services.AddSingleton(configuration.BindOptions());
            services.AddLogging(builder => builder.AddProvider(new ConsoleLoggerProvider()));
                        services.AddSingleton<IDomainService, CryptoMinerBitcoinETHDomainService>();
            services.AddSingleton<IMiningService, MiningService>();
            services.AddSingleton<IRigRegistry, StaticRigRegistry>();
            services.AddSingleton<IHashGenerator, RandomHashGenerator>();
            services.AddSingleton<IDifficultyAdjuster, DefaultDifficultyAdjuster>();
            services.AddSingleton<IBlockMiner, SimpleBlockMiner>();
            services.AddSingleton<IRewardCalculator, BlockRewardCalculator>();
            services.AddSingleton<IHealthChecker, EndpointHealthChecker>();

            return services;
        }

        static void PrintBanner() { System.Console.WriteLine("CryptoMinerBitcoinETH simulator initialized."); }

        static async Task RunInteractiveLoop(IDomainService domainService, MenuRenderer menuRenderer, ILogger logger, CancellationToken cancellationToken)
        {
            var menuOptions = new[]
            {
                "List mining rigs",
                "Mine for blocks",
                "Show mining summary",
                "Check network difficulty",
                "Simulate hash attempts",
                "Exit",
            };
            while (true)
            {
                menuRenderer.RenderHeader("CryptoMinerBitcoinETH - mining Simulator");
                menuRenderer.RenderMenu(menuOptions);
                var choice = System.Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        try
                        {
                            var result = await domainService.GetSummaryAsync(cancellationToken);
                            System.Console.WriteLine($"[+] Summary: {result}");
                        }
                        catch (Exception ex)
                        {
                            logger.LogError(ex, "Operation failed");
                        }
                        break;
                    case "2":
                        try
                        {
                            var result = await domainService.SimulateAsync(cancellationToken);
                            System.Console.WriteLine($"[+] Simulation result: {result}");
                        }
                        catch (Exception ex)
                        {
                            logger.LogError(ex, "Operation failed");
                        }
                        break;
                    case "6":
                    case "7":
                        return;
                    default:
                        logger.LogWarning("Invalid choice");
                        break;
                }
            }
        }
    }
}
