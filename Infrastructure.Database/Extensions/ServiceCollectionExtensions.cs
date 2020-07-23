using Domain.Models.Models;
using Infrastructure.Database.Implementations;
using Infrastructure.Database.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Database.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<EApplication>, EApplicationRepository>();
            return services;
        }
    }
}