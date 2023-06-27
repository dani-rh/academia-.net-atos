using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDo2Day.DTOs;
using ToDo2Day.Models;
using ToDo2Day.Repository;

namespace ToDo2Day.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        //injeção de dependência - permite que o controlador acesse a lógica de acesso aos dados fornecida pela interface
        private readonly ITagRepository _tagRepository;

        public TagController(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tag>>> GetTags()
        {
            return Ok(await _tagRepository.GetAllTagsAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tag>> GetTag(Guid id)
        {
            var tag = await _tagRepository.GetTagByIdAsync(id);
            if (tag == null)
                return NotFound();

            return Ok(tag);
        }

        [HttpPost]
        public async Task<ActionResult<Tag>> AddTag([FromBody] TagCreateDTO tagCreateDTO)
        {
            var tag = await _tagRepository.AddTagAsync(tagCreateDTO);
            return CreatedAtAction(nameof(GetTag), new { id = tag.TagId }, tag);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTag(Guid id, [FromBody] TagUpdateDTO tagUpdateDTO)
        {
            await _tagRepository.UpdateTagAsync(id, tagUpdateDTO);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTag(Guid id)
        {
            var tag = await _tagRepository.GetTagByIdAsync(id);

            if (tag == null)
                return NotFound();

            await _tagRepository.DeleteTagAsync(id);
            return NoContent();
        }

    }
}
