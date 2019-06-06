using Microsoft.EntityFrameworkCore;
using RazorPagesIgnis.Models;
using RazorPagesIgnis;

namespace RazorPagesIgnis.Models
{
    public class RazorPagesIgnisContext : DbContext
    {
        public RazorPagesIgnisContext (DbContextOptions<RazorPagesIgnisContext> options)
            : base(options)
        {
        }
        public DbSet<RazorPagesIgnis.Administrador> Administrador { get; set; }
        public DbSet<RazorPagesIgnis.Cliente> Cliente { get; set; }
        public DbSet<RazorPagesIgnis.Tecnico> Tecnico { get; set; }
        public DbSet<RazorPagesIgnis.Solicitud> Solicitud { get; set; }
        public DbSet<RazorPagesIgnis.Proyecto> Proyecto { get; set; }

    }
}