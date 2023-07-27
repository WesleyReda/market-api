using MarketApi.Repository.Interfaces;
using MarketApi.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Repository.Extensions
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddScopedRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<IProductsRepository, ProductsRepository>()
                .AddScoped<IMarketsRepository, MarketsRepository>();
            return services;
        }
    }
}
