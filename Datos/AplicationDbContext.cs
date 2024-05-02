
using AppNetRazor.Modelos;
using Microsoft.EntityFrameworkCore;

namespace AppNetRazor.Datos
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Curso> Curso { get; set; }
    }
}
