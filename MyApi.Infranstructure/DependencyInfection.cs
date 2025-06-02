using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
using MyApi.Core.Interfaces;
using MyApi.Infranstructure.Data;
using MyApi.Infranstructure.Repositories;

namespace MyApi.Infranstructure
{
    public static class DependencyInfection
    {
        public static IServiceCollection AddInfranstructureDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
                
            return services;
        }
    }
}
