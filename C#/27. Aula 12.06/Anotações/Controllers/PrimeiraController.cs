using Microsoft.AspNetCore.Mvc;

namespace Anotações.Controllers
{
    [ApiController]
    [Route("[controller]")] //se estiver só entre aspas, aparece o palavra que está entre aspas, se estiver o [] ele aparece o nome da controller sem a palavra controller - PRIMEIRA
    public class PrimeiraController : ControllerBase
    {
        [HttpGet("primeiro")]

        public string primeiroEndPoint()
        {
            return "Aula de RestAPI";
        }

        [HttpGet ("nome")]
        public string getNome()
        {
            return "Daniela";
        }

        [HttpPost("nome/{nomeUser}")]
        public string postNome([FromRoute] string nomeUser)
        {
            return nomeUser;
        }

        [HttpGet("idade")]
        public string getIdade()
        {
            return "27";
        }

        [HttpPost("nome/{nomeUser}/idade/{idadeUser}")]
        public string postNomeIdade([FromRoute] string nomeUser, int idadeUser)
        {
            return $"Nome: {nomeUser}, Idade: {idadeUser}";
        }


    }
}
