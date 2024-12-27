using EventBus0025.Events;

namespace TaskService0025.Messaging.Events
{
    public class TaskCreatedEvent : IntegrationEvent
    {
        public string TaskId { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
    }
}
