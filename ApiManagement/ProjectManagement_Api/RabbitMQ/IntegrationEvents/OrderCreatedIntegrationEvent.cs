using EventBus.RabbitMQ.IntegrationEvents;

namespace ProjectManagement_Api.RabbitMQ.IntegrationEvents
{
    public class OrderCreatedIntegrationEvent : IntegrationEventBase
    {
        public int UserId { get; set; }
    }
}
