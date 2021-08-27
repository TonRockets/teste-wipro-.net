using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using LocadoraFilmes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LocadoraFilmes.Controllers
{
    [ApiController]
    [Route("v1/locacoes")]
    public class LocacaoController : Controller {

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Locacao>>> Get([FromServices] LocadoraContext context) {
            var locacao = await context.Locacoes.Include(x => x.Filme).ToListAsync();
            return locacao;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Locacao>> GetById([FromServices] LocadoraContext context, int id) {
            var locacaoById = await context.Locacoes.Include(x => x.Filme)
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.LocacaoId == id);
            return locacaoById;
        }

        [HttpGet]
        [Route("locacao/{id:int}")]
        public async Task<ActionResult<Locacao>> GetByFilme([FromServices] LocadoraContext context, int id) {
            var locacaoById = await context.Locacoes.Include(x => x.Filme)
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.LocacaoId == id);
            return locacaoById;
        }
    }
}