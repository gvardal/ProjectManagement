using EventBus.RabbitMQ;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQTest.RabbitMQ.IntegrationEvent;
using RabbitMQTest.RabbitMQ.IntegrationEventHandlers;

namespace RabbitMQTest
{
    public class Tests
    {
        private ServiceCollection services;

        [SetUp]
        public void SetUp()
        {
            services = new ServiceCollection();
            services.AddLogging();
            services.AddTransient<OrderCreatedIntegrationEventHandler>();
        }

        [Test]
        public void create_exhange()
        {
            services.AddSingleton<IEventBus>(sp =>
            {
                RabbitMQConfig config = new RabbitMQConfig()
                {
                    ConnectionRetryCount = 5,
                    ExchangeName = "SellingBuddy",
                    ClientAppName = "UnitTest",
                    EventNameSuffix = "IntegrationEvent",
                };
                return EventBusFactory.Create(config, sp);
            });

            var sp = services.BuildServiceProvider();
            var eventBus = sp.GetRequiredService<IEventBus>();
            eventBus.Subscribe<OrderCreatedIntegrationEvent, OrderCreatedIntegrationEventHandler>();
        }

        [Test]
        public void unsuscripbe()
        {
            services.AddSingleton<IEventBus>(sp =>
            {
                RabbitMQConfig config = new RabbitMQConfig()
                {
                    ConnectionRetryCount = 5,
                    ExchangeName = "SellingBuddy",
                    ClientAppName = "UnitTest",
                    EventNameSuffix = "IntegrationEvent",
                };
                return EventBusFactory.Create(config, sp);
            });

            var sp = services.BuildServiceProvider();
            var eventBus = sp.GetRequiredService<IEventBus>();
            eventBus.Subscribe<OrderCreatedIntegrationEvent, OrderCreatedIntegrationEventHandler>();
            eventBus.UnSubscribe<OrderCreatedIntegrationEvent, OrderCreatedIntegrationEventHandler>();
        }

        [Test]
        public void publishMessage()
        {
            services.AddSingleton<IEventBus>(sp =>
            {
                RabbitMQConfig config = new RabbitMQConfig()
                {
                    ConnectionRetryCount = 5,
                    ExchangeName = "SellingBuddy",
                    ClientAppName = "UnitTest",
                    EventNameSuffix = "IntegrationEvent",
                };
                return EventBusFactory.Create(config, sp);
            });

            var sp = services.BuildServiceProvider();
            var eventBus = sp.GetRequiredService<IEventBus>();

            var oc = new OrderCreatedIntegrationEvent() { UserId = 1 };

            eventBus.Publish(oc);
        }

        [Test]
        public void receieveMessage()
        {
            services.AddSingleton<IEventBus>(sp =>
            {
                RabbitMQConfig config = new RabbitMQConfig()
                {
                    ConnectionRetryCount = 5,
                    ExchangeName = "SellingBuddy",
                    ClientAppName = "UnitTest",
                    EventNameSuffix = "IntegrationEvent",
                };
                return EventBusFactory.Create(config, sp);
            });
            var sp = services.BuildServiceProvider();
            var eventBus = sp.GetRequiredService<IEventBus>();
            eventBus.Subscribe<OrderCreatedIntegrationEvent, OrderCreatedIntegrationEventHandler>();
        }
    }
}