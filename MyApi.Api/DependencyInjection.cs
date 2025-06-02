using MyApi.Application;
using MyApi.Infranstructure;

namespace MyApi.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services)
        {
            services.AddApplicationDI()
                .AddInfranstructureDI();
            return services;
        }
    }
}
