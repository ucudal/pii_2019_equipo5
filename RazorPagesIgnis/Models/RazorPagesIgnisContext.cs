using Microsoft.EntityFrameworkCore;
using RazorPagesIgnis.Models;
using Ignis;

namespace RazorPagesIgnis.Models
{
    public class RazorPagesIgnisContext : DbContext
    {
        public RazorPagesIgnisContext (DbContextOptions<RazorPagesIgnisContext> options)
            : base(options)
        {
        }
        public DbSet<Ignis.Administrador> Administrador { get; set; }
        public DbSet<Ignis.Cliente> Cliente { get; set; }
        public DbSet<Ignis.Tecnico> Tecnico { get; set; }
        public DbSet<Ignis.Solicitud> Solicitud { get; set; }
        public DbSet<Ignis.Proyecto> Proyecto { get; set; }

    }
}