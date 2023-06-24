using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace WebApplication1.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class PrimeiraController : ControllerBase
    {

    }

    [HttpGet("primeiro")]
    public string primeiroEndPoint()
    {
        return "Aula de RestAPI";
    }

    [AllowAnonymous]
    [HttpGet("segundo")]
    public string segundoEndPoint()
    {
        return "Aula de JWT";
    }

    [AllowAnonymous]
    [HttpPost("autenticar")]
    public IActionResult Authenticate([FromBody] Usuario user)
    {
        var token = _jWTAuthenticationManager.Authenticate(user.Username, user.Password);

        if (token == null)
        {
            return Unauthorized();
        }

        return Ok(token);
    }
}
