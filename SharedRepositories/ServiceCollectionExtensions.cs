using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SharedRepositories
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDbContext<ApplicationContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")))
                .AddScoped<IApplicationContext>(sp => sp.GetRequiredService<ApplicationContext>());

            return services;
        }
    }
}
