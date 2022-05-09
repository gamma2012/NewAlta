using Microsoft.Extensions.DependencyInjection;
using Alta.Presenters;
using Alta.UseCases;
using Alta.PrimeClient;

namespace Alta.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddAltaDependencies(this IServiceCollection services)
        {
            services.AddUseCasesServices();
            services.AddPresenters();
            services.AddPrimeClientServices();
            return services;
        }
    }
}
