using MarketApi.Application.AppServices;
using MarketApi.Application.Mapper;
using MarketApi.CrossCutting.CommonServices;
using Microsoft.Extensions.DependencyInjection;

namespace MarketApi.Application.Extensions
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddAppAutoMapper(this IServiceCollection services)
        {
            return services.AddAutoMapper(typeof(MarketProfile));

            //1° => Add nos servicoes a partir do GetAssembly
            //2° => Criar profile dos products
        }
    }
}
