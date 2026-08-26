using CryptoMinerBitcoinETH.Core.Events;
using CryptoMinerBitcoinETH.Core.Pipelines;
using CryptoMinerBitcoinETH.Infrastructure.Events;
using CryptoMinerBitcoinETH.Infrastructure.Metrics;
using CryptoMinerBitcoinETH.Infrastructure.Persistence;
using CryptoMinerBitcoinETH.Infrastructure.Validation;
using Microsoft.Extensions.DependencyInjection;

namespace CryptoMinerBitcoinETH.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomainInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton(typeof(IJsonRepository<>), typeof(JsonRepository<>));
            services.AddSingleton<IRequestValidator<object>, DefaultRequestValidator<object>>();
            services.AddSingleton<IMetricsPublisher, ConsoleMetricsPublisher>();
            services.AddSingleton<IDomainEventBus, InMemoryDomainEventBus>();
            services.AddSingleton(typeof(IPipelineBehavior<,>), typeof(LoggingPipelineBehavior<,>));
            return services;
        }
    }
}
