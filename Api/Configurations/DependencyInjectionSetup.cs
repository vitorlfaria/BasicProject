using Infrastructure.IoC;

namespace Api.Configurations;

public static class DependencyInjectionSetup
{
    public static void AddDepencyInjectionSetup(this IServiceCollection services)
    {
        if (services == null) throw new ArgumentNullException(nameof(services));

        services.AddSingleton<ILoggerFactory, LoggerFactory>();

        DependencyInjectionContainer.RegisterServices(services);
    }
}