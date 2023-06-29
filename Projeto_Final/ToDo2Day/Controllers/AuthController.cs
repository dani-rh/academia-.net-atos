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
    [Route("[controller]")]
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

        [HttpPost("Register")]
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

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDTO userLoginDTO)
        {
            // Busca o usuário no banco de dados
            var userFromDb = await _userRepository.GetUserByEmailAsync(userLoginDTO.Email);

            // Verifica se o usuário existe e se a senha está correta
            if (userFromDb == null || userFromDb.Password != userLoginDTO.Password)
            {
                return Unauthorized();
            }

            //Criação do token
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

            return Ok(new {token = tokenHandler.WriteToken(token)});
        }

    }
}
