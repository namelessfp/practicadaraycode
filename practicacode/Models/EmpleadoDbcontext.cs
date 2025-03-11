using Microsoft.EntityFrameworkCore;

namespace practicacode.Models
{
    public class EmpleadoDbContext : DbContext
    {
        public EmpleadoDbContext(DbContextOptions<EmpleadoDbContext> options) : base(options) { }
        public DbSet<Empleado> Empleado { get; set; }

    }
}