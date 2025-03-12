using Contatos.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Contatos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly ContatoContext _context;
        private readonly ILogger<ContatoController> _logger;

        public ContatoController(ContatoContext context, ILogger<ContatoController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet(Name = "GetContato")]
        public async Task<IEnumerable<Contato>> Get()
        {
            return await _context.Contatos.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Contato>> Post(Contato contato)
        {
            _context.Contatos.Add(contato);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = contato.Id }, contato);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Contato contato)
        {
            if (id != contato.Id)
            {
                return BadRequest();
            }

            _context.Entry(contato).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Contatos.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
    }
}
