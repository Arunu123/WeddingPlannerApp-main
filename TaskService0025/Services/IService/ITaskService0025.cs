using TaskService0025.Models;

namespace TaskService0025.Services.IService
{
    public interface ITaskService0025
    {
        Task<Task0025> CreateTaskAsync(Task0025 task);
        Task<List<Task0025>> GetAllTasksAsync();
        Task<Task0025> GetTaskByIdAsync(string id);
        Task<Task0025> UpdateTaskAsync(string id, Task0025 updatedTask);
        Task<bool> DeleteTaskAsync(string id);
        Task<List<TaskCheckList0025>> GetTaskCheckListAsync(string taskId);
        Task<TaskCheckList0025> AddCheckListItemAsync(TaskCheckList0025 item);
        Task<bool> UpdateCheckListItemAsync(string id, TaskCheckList0025 updatedItem);
    }
}
