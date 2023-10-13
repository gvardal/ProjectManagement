using EventBus.RabbitMQ.IntegrationEventHandler;
using EventBus.RabbitMQ.IntegrationEvents;

namespace EventBus.RabbitMQ.Subscription
{
    public interface ISubscriptionManager
    {
        event EventHandler<string> OnEventRemoved;
        bool IsEmpty { get; }
        void AddSubscription<T, TH>() where T : IntegrationEventBase where TH : IIntegrationEventHandler<T>;
        void RemoveSubscription<T, TH>() where T : IntegrationEventBase where TH : IIntegrationEventHandler<T>;
        bool HasSubscriptionForEvent<T>() where T : IntegrationEventBase;
        bool HasSubscriptionForEvent(string eventName);
        Type GetEventTypeByName(string eventName);
        void Clear();
        IEnumerable<SubcriptionInfo> GetHandlersForEvent<T>() where T : IntegrationEventBase;
        IEnumerable<SubcriptionInfo> GetHandlersForEvent(string eventName);
        string GetEventKey<T>();
    }
}
