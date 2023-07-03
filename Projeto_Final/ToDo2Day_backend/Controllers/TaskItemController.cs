using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ToDo2Day.DTOs;
using ToDo2Day.Models;
using ToDo2Day.Repository;

namespace ToDo2Day.Controllers
{
    [Produces("application/json")]
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class TaskItemController : ControllerBase
    {
        private readonly ITaskItemRepository _taskItemRepository;

        public TaskItemController(ITaskItemRepository taskItemRepository)
        {
            _taskItemRepository = taskItemRepository;
        }

        /// <summary>
        /// Gets list of all task items.
        /// </summary>
        /// <returns>List of all task items.</returns>
        /// <response code="200">Returns the list of task items.</response>
        /// <response code="401">If the user is not authenticated.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<IEnumerable<TaskItem>>> GetTaskItems()
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return Ok(await _taskItemRepository.GetAllTaskItemsAsync(userId));
        }

        /// <summary>
        /// Gets a specific task item by ID.
        /// </summary>
        /// <param name="id">Task item ID.</param>
        /// <returns>Specific task item details.</returns>
        /// <response code="200">Returns the task item details.</response>
        /// <response code="401">If the user is not authenticated.</response>
        /// <response code="404">If the task item does not exist.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<TaskItem>> GetTaskItem(Guid id)
        {
            var taskItem = await _taskItemRepository.GetTaskItemByIdAsync(id);
            if (taskItem == null)
                return NotFound();

            return Ok(taskItem);
        }

        /// <summary>
        /// Adds a new task item.
        /// </summary>
        /// <param name="taskItemCreateDTO">Task item creation details.</param>
        /// <returns>Newly created task item details.</returns>
        /// <response code="201">Returns the newly created task item.</response>
        /// <response code="400">If the task item is null.</response>
        /// <response code="401">If the user is not authenticated.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<TaskItem>> AddTaskItem(TaskItemCreateDTO taskItemCreateDTO)
        {
            var taskItem = await _taskItemRepository.AddTaskItemAsync(taskItemCreateDTO);
            return CreatedAtAction(nameof(GetTaskItem), new { id = taskItem.TaskItemId }, taskItem);
        }

        /// <summary>
        /// Updates a specific task item.
        /// </summary>
        /// <param name="id">Task item ID.</param>
        /// <param name="taskItemUpdateDTO">Task item update details.</param>
        /// <returns>None.</returns>
        /// <response code="204">If update is successful.</response>
        /// <response code="400">If the task item is not found.</response>
        /// <response code="401">If the user is not authenticated.</response>
        /// <response code="404">If the ID does not match the task item's ID.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateTaskItem(Guid id, TaskItemUpdateDTO taskItemUpdateDTO)
        {
            var taskItem = await _taskItemRepository.GetTaskItemByIdAsync(id);

            if (taskItem == null)
                return NotFound();

            await _taskItemRepository.UpdateTaskItemAsync(id, taskItemUpdateDTO);

            return NoContent();
        }


        /// <summary>
        /// Deletes a specific task item.
        /// </summary>
        /// <param name="id">Task item ID.</param>
        /// <returns>None.</returns>
        /// <response code="204">If deletion is successful.</response>
        /// <response code="401">If the user is not authenticated.</response>
        /// <response code="404">If the task item does not exist.</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
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
