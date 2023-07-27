using MarketApi.Domain.Interfaces;
using MarketApi.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Domain.Extensions
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddScopedDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IProductsService, ProductsService>()
                .AddScoped<IMarketsService, MarketsService>();
            return services;
        }
    }
}
