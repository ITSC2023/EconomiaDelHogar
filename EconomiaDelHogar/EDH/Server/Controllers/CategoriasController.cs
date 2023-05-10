using EDH.Server.Data;
using EDH.Shared.Modelos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EDH.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
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
            return _context.Categorias.ToList();
        }
    }
}