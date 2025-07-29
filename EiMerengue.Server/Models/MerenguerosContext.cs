using Microsoft.EntityFrameworkCore;

namespace EiMerengue.Server.Models
{
    public class MerenguerosContext:DbContext
    {
        public MerenguerosContext(DbContextOptions<MerenguerosContext> options) : base(options)
        { 
        }
        public DbSet<Merenguero> Merengueros { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Merenguero>().HasIndex(m => m.Nombre).IsUnique();
        }


    }
}
