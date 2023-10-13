using EventBus.RabbitMQ.IntegrationEvents;

namespace EventBus.RabbitMQ.IntegrationEventHandler
{
    public interface IIntegrationEventHandler
    {
    }

    public interface IIntegrationEventHandler<TIntegrationEvent> : IIntegrationEventHandler 
        where TIntegrationEvent : IntegrationEventBase
    {
        Task Handle (TIntegrationEvent @event);
    }
}
