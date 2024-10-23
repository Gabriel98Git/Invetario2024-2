using Microsoft.EntityFrameworkCore;
using InventarioLogica.Entidades;
namespace InventarioBack.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Pais> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pais>().HasIndex(c => c.Name).IsUnique();
        }

    }
}
