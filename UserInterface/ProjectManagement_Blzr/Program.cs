using Microsoft.AspNetCore.ResponseCompression;
using ProjectManagement_Blzr.Data;
using ProjectManagement_Blzr.Extensions;
using ProjectManagement_Blzr.Hubs;
using Syncfusion.Blazor;

namespace ProjectManagement_Blzr
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddSyncfusionBlazor();

            // Custom Service Extensions
            builder.Services.ConfigureSqlServer(builder.Configuration);
            builder.Services.ConfigureHttpClient(builder.Configuration);

            builder.Services.AddResponseCompression(opt =>
            {
                opt.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[] { "application/octet/stream" });
            });

            var app = builder.Build();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NGaF5cXmRCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdgWXhfcHRWR2ZfUEJ0Vko=");

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }


            app.UseStaticFiles();

            app.UseRouting();
            app.MapDefaultControllerRoute();
            app.MapBlazorHub();
            app.MapHub<KanbanHub>("/kanbanhub");
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}