using Microsoft.EntityFrameworkCore;

namespace Fondo.DAL
{
    public class FondoContext : DbContext
    {
        DbContextOptions<FondoContext> _options;
        public FondoContext(DbContextOptions<FondoContext> options) : base(options)
        {
            _options = options;
        }

        public FondoContext() : base()
        { }

        public DbSet<Consignacion> Consignacion { get; set; }
        public DbSet<Prestamo> Prestamo { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Parametros> Parametros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=fondo;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
            
        }
    }
}
