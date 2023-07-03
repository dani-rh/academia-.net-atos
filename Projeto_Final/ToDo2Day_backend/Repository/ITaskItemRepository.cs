using ToDo2Day.DTOs;
using ToDo2Day.Models;

namespace ToDo2Day.Repository
{
    public interface ITaskItemRepository
    {
        Task<IEnumerable<TaskItem>> GetAllTaskItemsAsync(Guid userId);
        Task<TaskItem> GetTaskItemByIdAsync(Guid taskItemId);
        Task<TaskItem> AddTaskItemAsync(TaskItemCreateDTO taskItemCreateDTO);
        Task UpdateTaskItemAsync(Guid taskItemId, TaskItemUpdateDTO taskItemUpdateDTO);
        Task DeleteTaskItemAsync(Guid taskItemId);
    }
}
