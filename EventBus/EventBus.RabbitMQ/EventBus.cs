using EventBus.RabbitMQ.IntegrationEventHandler;
using EventBus.RabbitMQ.IntegrationEvents;
using EventBus.RabbitMQ.Subscription;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace EventBus.RabbitMQ
{
    public abstract class EventBus : IEventBus
    {
        private RabbitMQConfig config;
        public readonly IServiceProvider serviceProvider;
        public readonly ISubscriptionManager SubsManager;

        protected EventBus(RabbitMQConfig config, IServiceProvider serviceProvider)
        {
            this.config = config;
            this.serviceProvider = serviceProvider;
            SubsManager = new SubscriptionManager(ProcessEventName);
        }

        public virtual string ProcessEventName(string eventName)
        {
            if (config is not null)
            {
                if (config.DeleteEventPrefix)
                {
                    eventName = eventName.TrimStart(config.EventNamePrefix.ToArray());
                }
                if (config.DeleteEventSuffix)
                {
                    eventName = eventName.TrimEnd(config.EventNameSuffix.ToArray());
                }
            }
            return eventName;
        }

        public virtual string GetSubName(string eventName)
        {
            return $"{config.ClientAppName}.{ProcessEventName(eventName)}";
        }

        public async Task<bool> ProcessEvent(string eventName, string message)
        {
            eventName = ProcessEventName(eventName);
            var processed = false;
            if (SubsManager.HasSubscriptionForEvent(eventName))
            {
                var subscriptions = SubsManager.GetHandlersForEvent(eventName);
                using (var scope = serviceProvider.CreateScope())
                {
                    foreach (var subscription in subscriptions)
                    {
                        var handler = serviceProvider.GetService(subscription.HandlerType);
                        if (handler == null) continue;

                        var eventType = SubsManager.GetEventTypeByName($"{config.EventNamePrefix}{eventName}{config.EventNameSuffix}");
                        var integrationEvent = JsonConvert.DeserializeObject(message, eventType);
                        var concreteType = typeof(IIntegrationEventHandler<>).MakeGenericType(eventType);
                        await (Task)concreteType.GetMethod("Handle").Invoke(handler, new object[] { integrationEvent });
                    }
                }
                processed = true;
            }
            return processed;
        }

        public virtual void Dispose()
        {
            config = null;
        }

        public abstract void Publish(IntegrationEventBase @event);

        public abstract void Subscribe<T, TH>()
            where T : IntegrationEventBase
            where TH : IIntegrationEventHandler<T>;

        public abstract void UnSubscribe<T, TH>()
            where T : IntegrationEventBase
            where TH : IIntegrationEventHandler<T>;
    }
}
