using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Infrastructure.Persistence.Repositories;
using CleanArchtecture.Application.Interfaces;
using CleanArchtecture.Application.Servies;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
