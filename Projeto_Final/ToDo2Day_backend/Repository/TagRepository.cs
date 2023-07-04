using ToDo2Day.Models;
using ToDo2Day.DataModels;
using ToDo2Day.DTOs;
using Microsoft.EntityFrameworkCore;

namespace ToDo2Day.Repository
{
    public class TagRepository : ITagRepository
    {
        private readonly Context _context;

        public TagRepository(Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tag>> GetAllTagsAsync(Guid userId)
        {
            return await _context.Tags
                .Where(tag => tag.UserId == userId)
                .ToListAsync();
        }

        public async Task<Tag> GetTagByIdAsync(Guid tagId)
        {
            return await _context.Tags.FindAsync(tagId);
        }

        public async Task<Tag> AddTagAsync(TagCreateDTO tagCreateDTO, Guid userId)
        {
            var tag = new Tag
            {
                TagId = Guid.NewGuid(),
                Name = tagCreateDTO.TagName,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                UserId = userId
            };

            await _context.Tags.AddAsync(tag);
            await _context.SaveChangesAsync();

            return tag;
        }



        public async Task UpdateTagAsync(Guid tagId, TagUpdateDTO tagUpdateDTO)
        {
            var existingTag = await _context.Tags.FindAsync(tagId);
            if (existingTag != null)
            {
                existingTag.Name = tagUpdateDTO.NewTagName;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception($"Tag with id {tagId} not found.");
            }
        }


        public async Task DeleteTagAsync(Guid tagId)
        {
            var tag = await _context.Tags.FindAsync(tagId);
            if (tag != null)
            {
                tag.DeletedAt = DateTime.UtcNow;
                await _context.SaveChangesAsync();
            }
        }
    }
}
