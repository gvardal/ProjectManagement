using Newtonsoft.Json;

namespace EventBus.RabbitMQ.IntegrationEvents
{
    public class IntegrationEventBase
    {
        [JsonProperty]
        public Guid Id { get; set; }
        [JsonProperty]
        public DateTime CreatedDate { get; set; }

        [JsonConstructor]
        public IntegrationEventBase(Guid Id, DateTime createdDate)
        {
            this.Id = Id;
            this.CreatedDate = createdDate;
        }

        public IntegrationEventBase()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }
    }
}
