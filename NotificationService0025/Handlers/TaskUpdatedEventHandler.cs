using EventBus0025.Interfaces;
using TaskService0025.Messaging.Events;

namespace NotificationService0025.Handlers
{
    public class TaskUpdatedEventHandler : IEventHandler<TaskUpdatedEvent>
    {
        public Task Handle(TaskUpdatedEvent @event)
        {
            Console.WriteLine($"[NotificationService] Task Updated: {@event.Title}, Status: {@event.Status}");
            // Implement notification logic
            return Task.CompletedTask;
        }
    }
}
