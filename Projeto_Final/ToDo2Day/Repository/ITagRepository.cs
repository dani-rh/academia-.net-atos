using ToDo2Day.Models;
using ToDo2Day.DTOs;

namespace ToDo2Day.Repository
{
    public interface ITagRepository
    {
        Task<IEnumerable<Tag>> GetAllTagsAsync();
        Task<Tag> GetTagByIdAsync(Guid tagId);
        Task<Tag> AddTagAsync(TagCreateDTO tagCreateDTO);
        Task UpdateTagAsync(Guid tagId, TagUpdateDTO tagUpdateDTO);
        Task DeleteTagAsync(Guid tagId);
    }
}
