using Microsoft.Extensions.DependencyInjection;
using Alta.Presenters;
using Alta.UseCases;

namespace Alta.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddAltaDependencies(this IServiceCollection services)
        {
            services.AddUseCasesServices();
            services.AddPresenters();

            return services;
        }
    }
}
