using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using LocadoraFilmes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LocadoraFilmes.Controllers
{
    [ApiController]
    [Route("v1/clientes")]
    public class ClienteController : Controller {

         [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Cliente>>> Get([FromServices] LocadoraContext context) {
            var clientes = await context.Clientes.ToListAsync();
            return clientes;
        }


        [HttpPost]
        [Route("cadastrar-clientes")]
        public async Task<ActionResult<Cliente>> Post(
            [FromServices] LocadoraContext context, 
            [FromBody] Cliente model) {

            if (ModelState.IsValid) {
                context.Clientes.Add(model);
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