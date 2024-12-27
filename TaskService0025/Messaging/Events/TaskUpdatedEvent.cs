using EventBus0025.Events;

namespace TaskService0025.Messaging.Events
{
    public class TaskUpdatedEvent : IntegrationEvent
    {
        public string TaskId { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
    }
}
