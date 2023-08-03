using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.CrossCutting.CommonServices
{
    public static class BootstrapExtensions
    {
        public static IServiceCollection AddScopedServicesByBaseServiceType<TBaseService>(this IServiceCollection services)
        {
            var appServices = Assembly.GetAssembly(typeof(TBaseService))!
                .GetTypes()
                .Where(t => t.IsSubclassOf(typeof(TBaseService)) &&
                            t.IsClass &&
                            !t.IsAbstract)
                .Select(s => (Interface: s.GetInterfaces()[0], Implementation: s));
            foreach (var appService in appServices)
            {
                services.AddScoped(appService.Interface, appService.Implementation);
            }

            return services;
        }
    }
}
