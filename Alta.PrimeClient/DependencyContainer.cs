using Alta.EFCore.Repositories;
using Alta.Entities.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.PrimeClient
{
    public static class DependencyContainer
    {
        public static IServiceCollection  AddPrimeClientServices(this IServiceCollection services)
        {
            services.AddScoped<ILoggingRepository, ConsoleLoggingRepository>();
            services.AddScoped<IPrimeClient, HttpPrimeClient>();
            return services;
        }
    }
}
