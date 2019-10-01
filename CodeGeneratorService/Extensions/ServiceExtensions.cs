using CodeGeneratorService.Businesses;
using CodeGeneratorService.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CodeGeneratorService.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IGeneratorBusiness, GeneratorBusiness>();
            // Add all other services here.
            return services;
        }
    }
}