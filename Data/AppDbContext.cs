using Microsoft.EntityFrameworkCore;

namespace efcore_bl.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<TestKnight> TestKnights { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestKnight>().Property(e => e.Id).UseIdentityColumn();
        }
    }
}