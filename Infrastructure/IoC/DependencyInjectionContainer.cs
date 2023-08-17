using Domain.Interfaces;
using Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.IoC;

public class DependencyInjectionContainer
{
    public static void RegisterServices(IServiceCollection services)
    {
        // Application
        
        
        // Repository
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IDepartmentRepository, DepartmentRepository>();
    }
}