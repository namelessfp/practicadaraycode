using Microsoft.EntityFrameworkCore;

namespace practicacode.Models
{
    public class ESFEDbContext: DbContext
    {
        public ESFEDbContext(DbContextOptions<ESFEDbContext> options) : base(options) { }

        public DbSet<Proveedor> Proveedores { get; set; }

    }
}
