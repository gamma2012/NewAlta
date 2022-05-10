using Alta.EFCore.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Alta.EFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddEF(this IServiceCollection services, IConfiguration configuration )
        {
            services.AddDbContext<AltaContext>(opts => opts.UseSqlServer(configuration.GetConnectionString("AltaDbConnectionString")));
            return services;
        }

    }
}
