using Anotações.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;

namespace Anotações.Controllers
{
    public class PessoaController : ControllerBase
    { 
        [HttpGet]
        [Route("pessoas")]
        
        public async Task <IActionResult> getAllAsync(
            [FromServices] Contexto contexto)
        {
            var pessoas = await contexto
                .Pessoas
                .AsNoTracking() //só pode ser utilizado em consultas - altamente recomendado
                .ToListAsync();

            return pessoas == null ? NotFound() : Ok(pessoas);
        }

        [HttpGet]
        [Route("pessoas/{id}")]

        public async Task<IActionResult> getByIdAsync(
            [FromServices] Contexto contexto, [FromRoute] int id)
        {
            var pessoa = await contexto
                .Pessoas.AsNoTracking()
                .FirstOrDefaultAsync(p => p.id == id);

            return pessoa == null ? NotFound() : Ok(pessoa);
        }

        [HttpPost]
        [Route("pessoas")]

        public async Task<IActionResult> PostAsync(
            [FromServices] Contexto contexto, [FromBody] Pessoa pessoa)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                await contexto.Pessoas.AddAsync(pessoa);
                await contexto.SaveChangesAsync();
                return Created($"pessoa/pessoas/{pessoa.id}", pessoa);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    

 
    }
}
