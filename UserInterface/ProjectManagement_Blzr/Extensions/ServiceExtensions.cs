using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using ProjectManagement_Blzr.Models;
using System.Runtime.CompilerServices;

namespace ProjectManagement_Blzr.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlServer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProjectManagementDbContext>(opt =>
            {
                opt.UseSqlServer(connectionString: configuration.GetConnectionString("ProjectManagementDb"));
            });
        }

        public static void ConfigureHttpClient(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(configuration["ApiUrl"]!) });
        }
    }
}
