using Microsoft.EntityFrameworkCore;


namespace Litmus.Entities
{
    public class LitmusDbContext : DbContext
    {
        public LitmusDbContext(DbContextOptions<LitmusDbContext> options)
            : base(options)
        {

        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}
