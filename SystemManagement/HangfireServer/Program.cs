using Hangfire;
using HangfireServer.Context;
using Microsoft.EntityFrameworkCore;


namespace HangfireServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                {
                    options.UseSqlServer(connectionString: configuration.GetConnectionString("HangifireConnectionMsSql"));
                });

            builder.Services.AddHangfire(x =>
                {
                    x.UseSqlServerStorage(configuration.GetConnectionString("HangifireConnectionMsSql"));
                }

            );

            builder.Services.AddHangfireServer();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.UseHangfireDashboard();

            app.Run();
        }
    }
}