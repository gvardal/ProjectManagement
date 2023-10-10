using Consul;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Http.Features;

namespace ProjectManagement_Api.Extensions
{
    public static class ConsulRegistration
    {
        public static IServiceCollection ConfigureConsul(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IConsulClient, ConsulClient>(p => new ConsulClient(consulConfig =>
            {
                var address = configuration["ConsulConfig:Address"];
                if (address != null)
                {
                    consulConfig.Address = new Uri(address);
                }
            }));
            return services;
        }

        public static IApplicationBuilder RegisterWtihConsul(this IApplicationBuilder app)
        {
            var consulClient = app.ApplicationServices.GetRequiredService<IConsulClient>();
            var features = app.Properties["server.Features"] as FeatureCollection;
            if (features != null)
            {
                var addresses = features.Get<IServerAddressesFeature>();
                if (addresses is not null)
                {
                    //var address = addresses.Addresses.FirstOrDefault();
                    var uri = new Uri("http://localhost:5002");
                    var registration = new AgentServiceRegistration()
                    {
                        ID = $"ProjectManagerApiService",
                        Name = "ProjectManagerApiService",
                        Address = $"{uri.Host}",
                        Port = uri.Port,
                        Tags = new[] { "Project Manager Api", "Project Manager" }
                    };
                    consulClient.Agent.ServiceDeregister(registration.ID).Wait();
                    consulClient.Agent.ServiceRegister(registration).Wait();

                    //if (lifetime != null)
                    //{
                    //    lifetime.ApplicationStopping.Register(() =>
                    //    {
                    //        consulClient.Agent.ServiceDeregister(registration.ID).Wait();
                    //    });
                    //}                    
                }
            }
            return app;
        }
    }
}
