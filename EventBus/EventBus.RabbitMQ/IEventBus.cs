using EventBus.RabbitMQ.IntegrationEventHandler;
using EventBus.RabbitMQ.IntegrationEvents;

namespace EventBus.RabbitMQ
{
    public interface IEventBus
    {
        void Publish(IntegrationEventBase @event);
        void Subscribe<T, TH>() where T : IntegrationEventBase where TH : IIntegrationEventHandler<T>;
        void UnSubscribe<T, TH>() where T : IntegrationEventBase where TH : IIntegrationEventHandler<T>;
    }
}
