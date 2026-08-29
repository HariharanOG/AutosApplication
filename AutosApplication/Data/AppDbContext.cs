using Microsoft.EntityFrameworkCore;
using AutosApplication.Models;

namespace AutosApplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles => Set<Vehicle>();
        public DbSet<Vendor> Vendors => Set<Vendor>();
        public DbSet<ServiceRecord> ServiceRecords => Set<ServiceRecord>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceRecord>()
                .Property(s => s.Cost)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ServiceRecord>()
                .HasOne(s => s.Vehicle)
                .WithMany(v => v.ServiceRecords)
                .HasForeignKey(s => s.VehicleId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ServiceRecord>()
                .HasOne(s => s.Vendor)
                .WithMany(v => v.ServiceRecords)
                .HasForeignKey(s => s.VendorId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}