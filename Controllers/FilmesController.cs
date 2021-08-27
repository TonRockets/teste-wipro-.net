using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using LocadoraFilmes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LocadoraFilmes.Controllers
{
    [ApiController]
    [Route("v1/filmes")]
    public class PostFilmesController : Controller {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Filme>>> Get([FromServices] LocadoraContext context) {
            var filmes = await context.Filmes.ToListAsync();
            return filmes;
        }

        [HttpPost]
        [Route("cadastrar-filmes")]
        public async Task<ActionResult<Filme>> Post(
            [FromServices] LocadoraContext context, 
            [FromBody] Filme model) {

            if (ModelState.IsValid) {
                context.Filmes.Add(model);
                await context.SaveChangesAsync();
                return model;

            } else {
                return BadRequest(ModelState);
            }
            // var filmes = await context.Filmes.ToListAsync();
            // return filmes;
        }

        
    }
}