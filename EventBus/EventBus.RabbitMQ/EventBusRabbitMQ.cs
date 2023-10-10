using EventBus.Base;
using EventBus.Base.Events;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace EventBus.RabbitMQ
{
    public class EventBusRabbitMQ : BaseEventBus
    {
        PersistentConnection persistentConnection;
        private readonly IConnectionFactory connectionFactory;


        public EventBusRabbitMQ(IServiceProvider serviceProvider, EventBusConfig config) : base(serviceProvider, config)
        {
            if (config.Connection != null)
            {
                var connJson = JsonConvert.SerializeObject(config.Connection, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
                connectionFactory = JsonConvert.DeserializeObject<ConnectionFactory>(connJson);
            }
            else
            {
                connectionFactory = new ConnectionFactory();
            }

            persistentConnection = new PersistentConnection(connectionFactory, config.ConnectionRetryCount);
        }

        public override void Publish(IntegrationEvent @event)
        {
            throw new NotImplementedException();
        }

        public override void Subscribe<T, TH>()
        {
            var eventName = typeof(T).Name;
            eventName = ProccessEventName(eventName);
            if (!SubsManager.HasSubscriptionForEvent(eventName))
            {

            }
        }

        public override void UnSubscribe<T, TH>()
        {
            throw new NotImplementedException();
        }

        private IModel CreateConsumerChannel()
        {
            if (true)
            {

            }
        }
    }
}
