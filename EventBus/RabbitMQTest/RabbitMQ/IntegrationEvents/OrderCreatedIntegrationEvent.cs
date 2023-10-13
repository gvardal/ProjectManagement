using EventBus.RabbitMQ.IntegrationEvents;

namespace RabbitMQTest.RabbitMQ.IntegrationEvent
{
    public class OrderCreatedIntegrationEvent : IntegrationEventBase
    {
        public int UserId { get; set; }
    }
}
