using Microsoft.AspNetCore.Mvc;
using ToDo2Day.DTOs;
using ToDo2Day.Models;
using ToDo2Day.Repository;

namespace ToDo2Day.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Gets list of all users.
        /// </summary>
        /// <returns>List of all users.</returns>
        /// <response code="200">Returns the list of users.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return Ok(await _userRepository.GetAllUsersAsync());
        }

        /// <summary>
        /// Gets a specific user by ID.
        /// </summary>
        /// <param name="id">User ID.</param>
        /// <returns>Specific user details.</returns>
        /// <response code="200">Returns the user details.</response>
        /// <response code="404">If the user does not exist.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<User>> GetUser(Guid id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            if (user == null)
                return NotFound();

            return Ok(user);
        }

        /// <summary>
        /// Updates a specific user.
        /// </summary>
        /// <param name="id">User ID.</param>
        /// <param name="userUpdateDTO">Updated user details.</param>
        /// <returns>None.</returns>
        /// <response code="204">If the update is successful.</response>
        /// <response code="400">If the user data is invalid.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateUser(Guid id, [FromBody] UserUpdateDTO userUpdateDTO)
        {
            await _userRepository.UpdateUserAsync(id, userUpdateDTO);
            return NoContent();
        }

        /// <summary>
        /// Deletes a specific user.
        /// </summary>
        /// <param name="id">User ID.</param>
        /// <returns>None.</returns>
        /// <response code="204">If deletion is successful.</response>
        /// <response code="404">If the user does not exist.</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);

            if (user == null)
                return NotFound();

            await _userRepository.DeleteUserAsync(id);
            return NoContent();
        }
    }
}
