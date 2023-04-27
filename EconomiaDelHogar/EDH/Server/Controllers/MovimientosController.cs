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
    public class MovimientosController : ControllerBase
    {
        private readonly ILogger<Movimiento> _logger;
        private readonly ApplicationDbContext _context;

        public MovimientosController(ILogger<Movimiento> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Movimiento> Get()
        {
            return _context.Movimientos.Include(x=>x.Categoria).ToList();
        }
    }
}