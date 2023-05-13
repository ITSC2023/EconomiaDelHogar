

using Duende.IdentityServer.EntityFramework.Options;
using EDH.Server.Models;
using EDH.Shared.Modelos;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EDH.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Divisa> Divisas { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }
        public DbSet<Presupuesto> Presupuestos { get; set; }
        public DbSet<Subcategoria> Subcategorias { get; set; }
        public DbSet<Tarjeta> Tarjetas { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Categoria>().HasIndex(x => x.Nombre).IsUnique();
        }
    }
}
