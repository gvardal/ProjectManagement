using EventBus.RabbitMQ.IntegrationEvents;
using Newtonsoft.Json;
using Polly;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.Exceptions;
using System.Net.Sockets;
using System.Text;

namespace EventBus.RabbitMQ
{
    public class EventBusRabbitMQ : EventBus
    {
        private ConnectionFactory connectionFactory;
        private PersistentConnection persistentConnection;
        private readonly RabbitMQConfig rabbitMQConfig = new();
        private readonly IModel consumerChannel;

        public EventBusRabbitMQ(RabbitMQConfig config, IServiceProvider serviceProvider) : base(config, serviceProvider)
        {
            connectionFactory = new ConnectionFactory();
            connectionFactory.UserName = "giray";
            connectionFactory.Password = "123";
            persistentConnection = new PersistentConnection(connectionFactory, rabbitMQConfig);
            consumerChannel = CreateExchange(rabbitMQConfig);
            SubsManager.OnEventRemoved += SubsManager_OnEventRemoved;
        }

        private void SubsManager_OnEventRemoved(object? sender, string eventName)
        {
            eventName = ProcessEventName(eventName);
            if(!persistentConnection.IsConnected)
            {
                persistentConnection.TryConnect();
            }
            consumerChannel.QueueUnbind(queue: eventName, exchange: rabbitMQConfig.ExchangeName, routingKey: eventName);
            if (SubsManager.IsEmpty)
            {
                consumerChannel.Close();
            }
        }

        private IModel CreateExchange(RabbitMQConfig rabbitMQConfig)
        {
            if (!persistentConnection.IsConnected)
            {
                persistentConnection.TryConnect();
            }
            var channel = persistentConnection.CreateModel();
            channel.ExchangeDeclare(exchange: rabbitMQConfig.ExchangeName, type: "direct");
            return channel;
        }

        private void StartBasicConsume(string eventName)
        {
            if (consumerChannel is not null)
            {
                var consumer = new EventingBasicConsumer(consumerChannel);
                consumer.Received += Consumer_Received;
                consumerChannel.BasicConsume(queue: GetSubName(eventName), autoAck: false, consumer: consumer);
            }
        }

        private async void Consumer_Received(object? sender, BasicDeliverEventArgs e)
        {
            var eventName = e.RoutingKey;
            eventName = ProcessEventName(eventName);
            var message = Encoding.UTF8.GetString(e.Body.Span);
            try
            {
                await ProcessEvent(eventName, message);
            }
            catch (Exception ex)
            {
                //log
                Console.WriteLine(ex.ToString());
            }
            consumerChannel.BasicAck(e.DeliveryTag, multiple: false);
        }

        public override void Publish(IntegrationEventBase @event)
        {
            if (!persistentConnection.IsConnected)
            {
                persistentConnection.TryConnect();
            }

            var eventName = @event.GetType().Name;
            eventName = ProcessEventName(eventName);
            var message = JsonConvert.SerializeObject(@event);
            var body = Encoding.UTF8.GetBytes(message);
            consumerChannel.ExchangeDeclare(exchange: rabbitMQConfig.ExchangeName, type: "direct");
            var policy = Policy.Handle<BrokerUnreachableException>()
                .Or<SocketException>()
                .WaitAndRetry(rabbitMQConfig.ConnectionRetryCount, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)), (ex, time) => { });

            policy.Execute(() =>
            {
                var properties = consumerChannel.CreateBasicProperties();
                properties.DeliveryMode = 2;

                consumerChannel.QueueDeclare(queue: GetSubName(eventName),
                    durable: true,
                    exclusive: false,
                    autoDelete: false,
                    null);

                consumerChannel.QueueBind(queue: GetSubName(eventName), exchange: rabbitMQConfig.ExchangeName, routingKey: eventName);

                consumerChannel.BasicPublish(exchange: rabbitMQConfig.ExchangeName, routingKey: eventName
                    , mandatory: true
                    , basicProperties: properties, body: body);
            });
        }
        
        public override void Subscribe<T, TH>()
        {
            var eventName = typeof(T).Name;
            eventName = ProcessEventName(eventName);
            consumerChannel.QueueDeclare
                ( 
                    queue: GetSubName(eventName),
                    durable: true,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null
                );

            consumerChannel.QueueBind
                (
                    queue: GetSubName(eventName),
                    exchange: rabbitMQConfig.ExchangeName,
                    routingKey: eventName
                );
            SubsManager.AddSubscription<T, TH>();
            StartBasicConsume(eventName);
        }

        public override void UnSubscribe<T, TH>()
        {
            SubsManager.RemoveSubscription<T, TH>();    
        }
    }
}
