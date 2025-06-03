using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MyApi.Core.Interfaces;
using MyApi.Core.Options;
using MyApi.Infranstructure.Data;
using MyApi.Infranstructure.Repositories;
using MyApi.Infranstructure.Services;

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
            services.AddScoped<IExternalVendorRepository, ExternalVendorRepository>();

            services.AddHttpClient<JsonplaceholderHttpClientService>(option=>
            {
                option.BaseAddress = new Uri("http://localhost:2025/api/");
            });

            services.AddHttpClient<JokeHttpClientService>(option =>
            {
                option.BaseAddress = new Uri("https://official-joke-api.appspot.com/");
            });


            return services;
        }
    }
}
