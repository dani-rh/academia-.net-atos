using Microsoft.EntityFrameworkCore;
using ToDo2Day.DataModels;
using ToDo2Day.DTOs;
using ToDo2Day.Models;

namespace ToDo2Day.Repository
{
    public class TaskItemRepository : ITaskItemRepository
    {
        private readonly Context _context;

        public TaskItemRepository(Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TaskItem>> GetAllTaskItemsAsync()
        {
            return await _context.TaskItems.Include(t => t.User).Include(t => t.Tag).ToListAsync();
        }

        public async Task<TaskItem> GetTaskItemByIdAsync(Guid taskItemId)
        {
            return await _context.TaskItems.Include(t => t.User).Include(t => t.Tag).FirstOrDefaultAsync(t => t.TaskItemId == taskItemId);
        }

        public async Task<TaskItem> AddTaskItemAsync(TaskItemCreateDTO taskItemCreateDTO)
        {
            var taskItem = new TaskItem
            {
                TaskItemId = Guid.NewGuid(),
                Title = taskItemCreateDTO.Title,
                Description = taskItemCreateDTO.Description,
                UserId = taskItemCreateDTO.UserId,
                TagId = taskItemCreateDTO.TagId,
                IsCompleted = taskItemCreateDTO.IsCompleted,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await _context.TaskItems.AddAsync(taskItem);
            await _context.SaveChangesAsync();

            return taskItem;
        }

        public async Task UpdateTaskItemAsync(Guid taskItemId, TaskItemUpdateDTO taskItemUpdateDTO)
        {
            var taskItem = await _context.TaskItems.FindAsync(taskItemId);

            if (taskItem != null)
            {
                taskItem.Title = taskItemUpdateDTO.Title;
                taskItem.Description = taskItemUpdateDTO.Description;
                taskItem.UserId = taskItemUpdateDTO.UserId;
                taskItem.TagId = taskItemUpdateDTO.TagId;
                taskItem.IsCompleted = taskItemUpdateDTO.IsCompleted;
                taskItem.UpdatedAt = DateTime.UtcNow;

                _context.TaskItems.Update(taskItem);
                await _context.SaveChangesAsync();
            }
        }


        public async Task DeleteTaskItemAsync(Guid taskItemId)
        {
            var taskItem = await _context.TaskItems.FindAsync(taskItemId);
            if (taskItem != null)
            {
                _context.TaskItems.Remove(taskItem);
                await _context.SaveChangesAsync();
            }
        }
    }
}
