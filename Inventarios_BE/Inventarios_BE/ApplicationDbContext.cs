using Inventarios_BE.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Inventarios_BE
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Producto> Productos { get; set; }
    }
}
