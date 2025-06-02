using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApi.Infranstructure
{
    public static class DependencyInfection
    {
        public static IServiceCollection AddInfranstructureDI(this IServiceCollection services)
        {
            return services;
        }
    }
}
