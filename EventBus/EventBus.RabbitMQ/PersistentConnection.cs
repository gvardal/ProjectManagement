using Polly;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.Exceptions;
using System.Net.Sockets;

namespace EventBus.RabbitMQ
{
    public class PersistentConnection : IDisposable
    {
        private readonly IConnectionFactory connectionFactory;
        private readonly RabbitMQConfig config;
        private bool _dispose;
        private IConnection connection;
        private object lock_object = new object();

        public PersistentConnection(IConnectionFactory connectionFactory, RabbitMQConfig config)
        {
            this.connectionFactory = connectionFactory;
            this.config = config;
        }

        public bool IsConnected => connection != null && connection.IsOpen;

        public IModel CreateModel() { return connection.CreateModel(); }

        public void Dispose()
        {
            _dispose= true;
            connection.Dispose();
        }
    
        public bool TryConnect()
        {
            lock (lock_object)
            {
                var policy = Policy.Handle<SocketException>()
                    .Or<BrokerUnreachableException>()
                    .WaitAndRetry(config.ConnectionRetryCount, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)), (ex, time) => { });
                policy.Execute(() =>
                {
                    connection = connectionFactory.CreateConnection();
                });
                if (IsConnected)
                {
                    connection.ConnectionShutdown += Connection_Shutdown;
                    connection.ConnectionBlocked += Connection_Blocked;
                    connection.CallbackException += Connection_CallBackException;
                    return true;
                }
                return false;
            }
        }

        private void Connection_CallBackException(object? sender, CallbackExceptionEventArgs e)
        {
            if (_dispose) return;
            TryConnect();
        }

        private void Connection_Blocked(object? sender, ConnectionBlockedEventArgs e)
        {
            if (_dispose) return;
            TryConnect();
        }

        private void Connection_Shutdown(object? sender, ShutdownEventArgs e)
        {
            if (_dispose) return;
            TryConnect();
        }
    }
}
