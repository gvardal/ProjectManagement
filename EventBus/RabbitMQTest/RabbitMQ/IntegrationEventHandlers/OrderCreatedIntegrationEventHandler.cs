using EventBus.RabbitMQ.IntegrationEventHandler;
using RabbitMQTest.RabbitMQ.IntegrationEvent;

namespace RabbitMQTest.RabbitMQ.IntegrationEventHandlers
{
    public class OrderCreatedIntegrationEventHandler : IIntegrationEventHandler<OrderCreatedIntegrationEvent>
    {
        public Task Handle(OrderCreatedIntegrationEvent @event)
        {
            Console.WriteLine(@event.UserId);
            return Task.CompletedTask;
        }
    }
}
