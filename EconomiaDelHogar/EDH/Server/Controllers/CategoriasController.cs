using EDH.Server.Data;
using EDH.Shared.Modelos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EDH.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/categorias")]
    public class CategoriasController : ControllerBase
    {
        private readonly ILogger<Categoria> _logger;
        private readonly ApplicationDbContext _context;

        public CategoriasController(ILogger<Categoria> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Categoria> Get()
        {
            _logger.LogInformation("Se llamo al Get de Categorias");
            return _context.Categorias.ToList();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Categoria categoria)
        {

            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();
            return Ok(categoria);
        }
    }
}