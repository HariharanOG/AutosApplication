using Microsoft.EntityFrameworkCore;

namespace AutosApplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Add your DbSets here as you create entity models, e.g.:
        // public DbSet<Vehicle> Vehicles => Set<Vehicle>();
    }
}