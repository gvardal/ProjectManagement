using EventBus.RabbitMQ;
using Microsoft.EntityFrameworkCore;
using ProjectManagement_Api.RabbitMQ.IntegrationEventHandlers;
using Repositories.Contracts;
using Repositories.Infrastructure;
using Services.Contracts;
using Services.Infrastructure;

namespace ProjectManagement_Api.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("LocalDb"));
            });
        }

        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }

        public static void ConfigureServiceManager(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
        }

        public static void ConfigureRabbitMQ(this IServiceCollection services)
        {
            services.AddTransient<OrderCreatedIntegrationEventHandler>();
            services.AddSingleton<IEventBus>(sp =>
            {
                RabbitMQConfig config = new RabbitMQConfig()
                {
                    ConnectionRetryCount = 5,
                    ExchangeName = "ProjectManagement",
                    ClientAppName = "ProjectManagement.Api",
                    EventNameSuffix = "IntegrationEvent",
                };
                return EventBusFactory.Create(config, sp);
            });
        }
    }
}
