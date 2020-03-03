using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Teste1.Domain.Entidades;
using Teste1.Infra.Context;

namespace Teste1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoesController : ControllerBase
    {
        private readonly TesteContext _context;

        public EnderecoesController(TesteContext context)
        {
            _context = context;
        }

        // GET: api/Enderecoes
        [HttpGet("cidade/{idCidade}")]
        public async Task<ActionResult<IEnumerable<Endereco>>> GetEnderecos(int idCidade)
        {
            return await _context.Enderecos.Where(x=>x.COD_CIDADE == idCidade).ToListAsync();
        }
    }
}
