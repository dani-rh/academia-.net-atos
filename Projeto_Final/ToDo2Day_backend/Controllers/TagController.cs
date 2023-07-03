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
    public class TagController : ControllerBase
    {
        private readonly ITagRepository _tagRepository;

        public TagController(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        /// <summary>
        /// Gets list of all tags.
        /// </summary>
        /// <returns>List of all tags.</returns>
        /// <response code="200">Returns the list of tags.</response>
        /// <response code="401">If the user is not authenticated.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<IEnumerable<Tag>>> GetTags()
        {
            var userId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            return Ok(await _tagRepository.GetAllTagsAsync(userId));
        }

        /// <summary>
        /// Gets a specific tag by ID.
        /// </summary>
        /// <param name="id">Tag ID.</param>
        /// <returns>Specific tag details.</returns>
        /// <response code="200">Returns the tag details.</response>
        /// <response code="401">If the user is not authenticated.</response>
        /// <response code="404">If the tag does not exist.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Tag>> GetTag(Guid id)
        {
            var tag = await _tagRepository.GetTagByIdAsync(id);
            if (tag == null)
                return NotFound();

            return Ok(tag);
        }

        /// <summary>
        /// Adds a new tag.
        /// </summary>
        /// <param name="tagDto">Tag details.</param>
        /// <returns>Newly created tag details.</returns>
        /// <response code="201">Returns the newly created tag.</response>
        /// <response code="401">If the user is not authenticated.</response>
        /// <response code="400">If the tag is null.</response>   
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Tag>> AddTag([FromBody] TagCreateDTO tagCreateDTO)
        {
            var userId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var tag = await _tagRepository.AddTagAsync(tagCreateDTO, userId);
            return CreatedAtAction(nameof(GetTag), new { id = tag.TagId }, tag);
        }

        /// <summary>
        /// Updates a specific tag.
        /// </summary>
        /// <param name="id">Tag ID.</param>
        /// <param name="NewTagName">An object with the new tag name.</param>
        /// <returns>None.</returns>
        /// <response code="204">If update is successful.</response>
        /// <response code="401">If the user is not authenticated.</response>
        /// <response code="400">If the ID does not match the tag's ID.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateTag(Guid id, [FromBody] TagUpdateDTO tagUpdateDTO)
        {
            await _tagRepository.UpdateTagAsync(id, tagUpdateDTO);

            return NoContent();
        }

        /// <summary>
        /// Deletes a specific tag.
        /// </summary>
        /// <param name="id">Tag ID.</param>
        /// <returns>None.</returns>
        /// <response code="204">If deletion is successful.</response>
        /// <response code="401">If the user is not authenticated.</response>
        /// <response code="404">If the tag does not exist.</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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
