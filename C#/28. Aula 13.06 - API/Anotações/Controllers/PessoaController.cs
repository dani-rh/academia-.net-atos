using Anotações.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using System.Runtime.InteropServices;

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
                return Created($"pessoas/pessoas/{pessoa.id}", pessoa);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        //[HttpPost]

        //[Route("emails/post/{id}")]

        //public async Task<IActionResult> PostAsync(

        //    [FromBody] Email? email,

        //    [FromRoute] int id)

        //{

        //    if (!ModelState.IsValid) // validações colocadas com notações na classe models, como required, tamanho entre outros

        //    {

        //        return BadRequest();

        //    }

        //    try

        //    {

        //        Pessoa? p = await _context.Pessoas.FindAsync(id);

        //        email.Pessoa = p;

        //        await _context.Emails.AddAsync(email);

        //        await _context.SaveChangesAsync();

        //        return Created($"api/emails/{email.id}", email);

        //    }

        //    catch (Exception ex)

        //    {

        //        return BadRequest(ex.ToString());

        //    }

        //}

        [HttpPut]
        [Route("pessoas/{id}")]

        public async Task<IActionResult> PutAsync
            (
                [FromServices] Contexto contexto,
                [FromBody] Pessoa pessoa,
                [FromRoute] int id
            )
        {
            if (!ModelState.IsValid) //Verifica os atributos
                return BadRequest("Model inválida");

            var p = await contexto.Pessoas
                .FirstOrDefaultAsync(x => x.id == id);

            if (p == null)
                return NotFound("Pessoa não encontrada!");

            try
            {
                p.nome = pessoa.nome;

                contexto.Pessoas.Update(p);
                await contexto.SaveChangesAsync();
                return Ok(p);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromServices] Contexto contexto,
            [FromRoute] int id)
        {
            var p = await contexto.Pessoas.FirstOrDefaultAsync(x => x.id == id);

            if (p == null)
                return BadRequest("Pessoa não encontrada");
            try
            {
                contexto.Pessoas.Remove(p);
                await contexto.SaveChangesAsync();

                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    

 
    }
}
