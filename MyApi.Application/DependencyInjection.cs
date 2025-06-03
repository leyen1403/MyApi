using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace MyApi.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            services.AddMediatR(typeof(DependencyInjection).Assembly);

            return services;
        }
    }
}
