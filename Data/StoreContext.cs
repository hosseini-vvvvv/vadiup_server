using Microsoft.EntityFrameworkCore;
using server.Entity;

namespace server.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Setting>().HasIndex(c => c.key).IsUnique();
        }
        public DbSet<Category> category { get; set; }
        public DbSet<Setting> setting { get; set; }

    }


}