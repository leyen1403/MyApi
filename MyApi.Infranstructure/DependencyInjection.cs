using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MyApi.Core.Interfaces;
using MyApi.Core.Options;
using MyApi.Infranstructure.Data;
using MyApi.Infranstructure.Repositories;

namespace MyApi.Infranstructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfranstructureDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>((provider, options) =>
            {
                options.UseSqlServer(provider.GetRequiredService<IOptionsSnapshot<ConnectionStringOptions>>().Value.DefaultConnection);
            });

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
                
            return services;
        }
    }
}
