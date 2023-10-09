using Microsoft.EntityFrameworkCore;
using ProjectManagement_Blzr.Models;
using Serilog;

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

        public static void SetUpGrayLog(this IServiceCollection services)
        {
            var serilogConfig = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("serilog.json")
                .AddEnvironmentVariables()
                .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(serilogConfig)
                .CreateLogger();

            Log.Information("Starting Blazor application");

        }
    }
}
