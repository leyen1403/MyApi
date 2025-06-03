using MyApi.Application;
using MyApi.Core;
using MyApi.Infranstructure;

namespace MyApi.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationDI()
                .AddInfranstructureDI()
                .AddCoreDI(configuration);

            return services;
        }
    }
}
