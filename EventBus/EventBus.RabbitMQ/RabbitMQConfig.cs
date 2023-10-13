namespace EventBus.RabbitMQ
{
    public class RabbitMQConfig
    {
        public int ConnectionRetryCount { get; set; } = 5;
        public string ExchangeName { get; set; } = "ProjectManagement";
        public string ClientAppName { get; set; } = string.Empty;
        public string EventNamePrefix { get; set; } = string.Empty;
        public string EventNameSuffix { get; set; } = string.Empty;
        public bool DeleteEventPrefix => !string.IsNullOrEmpty(EventNamePrefix);
        public bool DeleteEventSuffix => !string.IsNullOrEmpty(EventNameSuffix);
    }
}
