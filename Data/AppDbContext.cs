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

            modelBuilder.Entity<TestKnight>()
                .HasOne<KnightTable>(e => e.Table)
                .WithMany(e => e.Knights);

            var roundTable = new KnightTable()
            {
                Id = 1,
                Shape = "Round",
                MaxSeats = 20
            };

            modelBuilder.Entity<KnightTable>().HasData(roundTable);

            modelBuilder.Entity<TestKnight>().HasData(new TestKnight()
            {
                Id = 1,
                Name = "Lancelot",
                Quest = "To seek the holy grail",
                // Table = roundTable,
                TableId = roundTable.Id
            });

        }
    }
}