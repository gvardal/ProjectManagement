﻿using EventBus.RabbitMQ.IntegrationEvents;

namespace ProjectManagement_Api.RabbitMQ.IntegrationEvents
{
    public class SubTaskCreatedIntegrationEvent : IntegrationEventBase
    {
        public int ProjectId { get; set; }
        public int ParentId { get; set; }
        public string TaskName { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = string.Empty;
    }
}
