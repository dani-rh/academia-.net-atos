using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ToDo2Day.DTOs;
using ToDo2Day.Models;
using ToDo2Day.Repository;
using ToDo2Day.Settings;


namespace ToDo2Day.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUserRepository _userRepository;
        private readonly IOptions<JwtSettings> _jwtSettings;

        public AuthController(IConfiguration configuration, IUserRepository userRepository, IOptions<JwtSettings> jwtSettings)
        {
            _configuration = configuration;
            _userRepository = userRepository;
            _jwtSettings = jwtSettings;
        }

        /// <summary>
        /// Registers a new user.
        /// </summary>
        /// <param name="userDto">User details.</param>
        /// <returns>Newly registered user details.</returns>
        /// <response code="201">Returns the newly registered user.</response>
        /// <response code="400">If the user is null.</response>   
        [HttpPost("Register")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<User>> Register(UserCreateDTO userDto)
        {
            // Antes de registrar, verifica se já existe um usuário com o mesmo email
            var existingUser = await _userRepository.GetUserByEmailAsync(userDto.Email);
            if (existingUser != null)
            {
                return BadRequest("A user with this email already exists");
            }

            var user = await _userRepository.AddUserAsync(userDto);
            return CreatedAtAction(nameof(UserController.GetUser), "User", new { id = user.UserId }, user);

        }

        /// <summary>
        /// User login endpoint. Generate and returns a JWT token.
        /// </summary>
        /// <param name="userLoginDTO">Login payload</param>
        /// <returns>A JWT token</returns>
        /// <response code="200">Returns the newly generated token</response>
        /// <response code="401">If the user login credentials are not valid</response>  
        [HttpPost("Login")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(void), 401)]
        public async Task<IActionResult> Login(UserLoginDTO userLoginDTO)
        {
            // Fetch the user from the database
            var userFromDb = await _userRepository.GetUserByEmailAsync(userLoginDTO.Email);

            // Check if the user exists and the password is correct
            if (userFromDb == null || userFromDb.Password != userLoginDTO.Password)
            {
                return Unauthorized();
            }

            // Create the token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtSettings.Value.SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim(ClaimTypes.NameIdentifier, userFromDb.UserId.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = _jwtSettings.Value.Issuer,
                Audience = _jwtSettings.Value.Audience
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new { token = tokenHandler.WriteToken(token) });
        }

    }
}
