
using EventBus.RabbitMQ;
using ProjectManagement_Api.Extensions;
using ProjectManagement_Api.RabbitMQ.IntegrationEventHandlers;
using ProjectManagement_Api.RabbitMQ.IntegrationEvents;

namespace ProjectManagement_Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers()
                .AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly);


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            // Extension Services
            builder.Services.ConfigureSqlContext(builder.Configuration);
            builder.Services.ConfigureRepositoryManager();
            builder.Services.ConfigureServiceManager();
            builder.Services.ConfigureConsul(builder.Configuration);
            builder.Services.ConfigureRabbitMQ();

            var app = builder.Build();

            var eventBus = app.Services.GetRequiredService<IEventBus>();
            eventBus.Subscribe<OrderCreatedIntegrationEvent, OrderCreatedIntegrationEventHandler>();


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.RegisterWtihConsul();

            app.Run();
        }
    }
}