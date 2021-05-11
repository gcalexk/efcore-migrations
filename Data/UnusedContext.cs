using Microsoft.EntityFrameworkCore;

namespace efcore_bl.Data
{
    public class UnusedContext : DbContext
    {

        public UnusedContext(DbContextOptions<UnusedContext> options): base(options) { }

        public DbSet<UnusedObject> UnusedObjects { get; set; }
        
    }
}