using EventBus.RabbitMQ.IntegrationEventHandler;
using ProjectManagement_Api.RabbitMQ.IntegrationEvents;

namespace ProjectManagement_Api.RabbitMQ.IntegrationEventHandlers
{
    public class OrderCreatedIntegrationEventHandler : IIntegrationEventHandler<OrderCreatedIntegrationEvent>
    {
        public Task Handle(OrderCreatedIntegrationEvent @event)
        {
            Console.WriteLine($"Handle Method Work with id {@event.UserId}");
            return Task.CompletedTask;
        }
    }
}
