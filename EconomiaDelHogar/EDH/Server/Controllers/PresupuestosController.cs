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
    public class PresupuestosController : ControllerBase
    {
        private readonly ILogger<Presupuesto> _logger;
        private readonly ApplicationDbContext _context;

        public PresupuestosController(ILogger<Presupuesto> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Presupuesto> Get()
        {
            return _context.Presupuestos.ToList();
        }
    }
}