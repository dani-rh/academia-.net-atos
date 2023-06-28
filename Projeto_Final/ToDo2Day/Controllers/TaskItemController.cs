using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDo2Day.DTOs;
using ToDo2Day.Models;
using ToDo2Day.Repository;

namespace ToDo2Day.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskItemController : ControllerBase
    {
        private readonly ITaskItemRepository _taskItemRepository;

        public TaskItemController(ITaskItemRepository taskItemRepository)
        {
            _taskItemRepository = taskItemRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<TaskItem>>> GetTaskItems()
        {
            return Ok(await _taskItemRepository.GetAllTaskItemsAsync());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TaskItem>> GetTaskItem(Guid id)
        {
            var taskItem = await _taskItemRepository.GetTaskItemByIdAsync(id);
            if (taskItem == null)
                return NotFound();

            return Ok(taskItem);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TaskItem>> AddTaskItem(TaskItemCreateDTO taskItemCreateDTO)
        {
            var taskItem = await _taskItemRepository.AddTaskItemAsync(taskItemCreateDTO);
            return CreatedAtAction(nameof(GetTaskItem), new { id = taskItem.TaskItemId }, taskItem);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateTaskItem(Guid id, TaskItemUpdateDTO taskItemUpdateDTO)
        {
            var taskItem = await _taskItemRepository.GetTaskItemByIdAsync(id);

            if (taskItem == null)
                return NotFound();

            await _taskItemRepository.UpdateTaskItemAsync(id, taskItemUpdateDTO);

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteTaskItem(Guid id)
        {
            var taskItem = await _taskItemRepository.GetTaskItemByIdAsync(id);

            if (taskItem == null)
                return NotFound();

            await _taskItemRepository.DeleteTaskItemAsync(id);
            return NoContent();
        }
    }
}
