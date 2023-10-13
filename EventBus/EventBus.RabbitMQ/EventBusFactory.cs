namespace EventBus.RabbitMQ
{
    public static class EventBusFactory
    {
        public static IEventBus Create(RabbitMQConfig config, IServiceProvider serviceProvider)
        {
            return new EventBusRabbitMQ(config,serviceProvider);
        }
    }
}
