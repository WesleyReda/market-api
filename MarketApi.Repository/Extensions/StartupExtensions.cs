using MarketApi.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
        public static IServiceCollection AddContext(this IServiceCollection service, IConfiguration configuration)
        {
            return service.AddDbContext<DbContext>(op => op.UseNpgsql(configuration.GetConnectionString("pgconnection")));
        }
    }
}
