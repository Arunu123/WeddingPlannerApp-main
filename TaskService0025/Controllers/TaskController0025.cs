using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskService0025.Models;
using TaskService0025.Services.IService;

namespace TaskService0025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController0025 : ControllerBase
    {
        private readonly ITaskService0025 _taskService;

        public TaskController0025(ITaskService0025 taskService)
        {
            _taskService = taskService;
        }

        [HttpPost("CreateTask")]
        public async Task<IActionResult> CreateTask([FromBody] Task0025 task)
        {
            var createdTask = await _taskService.CreateTaskAsync(task);
            return CreatedAtAction(nameof(GetTaskById), new { id = createdTask.Id }, createdTask);
        }

        [HttpGet("GetAllTasks")]
        public async Task<IActionResult> GetAllTasks()
        {
            return Ok(await _taskService.GetAllTasksAsync());
        }

        [HttpGet("GetTaskById/{id}")]
        public async Task<IActionResult> GetTaskById(string id)
        {
            var task = await _taskService.GetTaskByIdAsync(id);
            if (task == null) return NotFound();
            return Ok(task);
        }

        [HttpPut("UpdateTask/{id}")]
        public async Task<IActionResult> UpdateTask(string id, [FromBody] Task0025 updatedTask)
        {
            var task = await _taskService.UpdateTaskAsync(id, updatedTask);
            if (task == null) return NotFound();
            return Ok(task);
        }

        [HttpDelete("DeleteTask/{id}")]
        public async Task<IActionResult> DeleteTask(string id)
        {
            var success = await _taskService.DeleteTaskAsync(id);
            if (!success) return NotFound();
            return NoContent();
        }

        [HttpGet("GetTaskCheckList/{taskId}")]
        public async Task<IActionResult> GetTaskCheckList(string taskId)
        {
            return Ok(await _taskService.GetTaskCheckListAsync(taskId));
        }

        [HttpPost("AddCheckListItem")]
        public async Task<IActionResult> AddCheckListItem([FromBody] TaskCheckList0025 item)
        {
            var createdItem = await _taskService.AddCheckListItemAsync(item);
            return Ok(createdItem);
        }

        [HttpPut("UpdateCheckListItem/{id}")]
        public async Task<IActionResult> UpdateCheckListItem(string id, [FromBody] TaskCheckList0025 updatedItem)
        {
            var success = await _taskService.UpdateCheckListItemAsync(id, updatedItem);
            if (!success) return NotFound();
            return NoContent();
        }
    }
}
