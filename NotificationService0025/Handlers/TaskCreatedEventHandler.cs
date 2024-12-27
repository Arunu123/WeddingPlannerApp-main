using EventBus0025.Interfaces;
using TaskService0025.Messaging.Events;

namespace NotificationService0025.Handlers
{
    public class TaskCreatedEventHandler : IEventHandler<TaskCreatedEvent>
    {
        public Task Handle(TaskCreatedEvent @event)
        {
            Console.WriteLine($"[NotificationService] Task Created: {@event.Title}, Due: {@event.DueDate}");
            // Implement notification logic
            return Task.CompletedTask;
        }
    }
}
