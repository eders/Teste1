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
    public class CidadesController : ControllerBase
    {
        private readonly TesteContext _context;

        public CidadesController(TesteContext context)
        {
            _context = context;
        }

        // GET: api/Cidades
        [HttpGet("Estado/{idEstado}")]
        public async Task<ActionResult<IEnumerable<Cidade>>> GetCidades(int idEstado)
        {
            return await _context.Cidades.Where(x=>x.COD_ESTADO == idEstado).ToListAsync();
        }
    }
}
