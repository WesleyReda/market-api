using MarketApi.Application.AppServices;
using MarketApi.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Application.Extensions
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddScopedAppServices(this IServiceCollection services)
        {

            //Homework: encapsulate logic and apply to all layers(projects)
            var appServices = Assembly.GetAssembly(typeof(BaseAppService))!
                .GetTypes()
                .Where(t => t.IsSubclassOf(typeof(BaseAppService)) &&
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
