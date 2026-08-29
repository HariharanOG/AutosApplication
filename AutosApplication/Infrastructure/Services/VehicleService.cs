using AutosApplication.Data;
using AutosApplication.Infrastructure.Interfaces;
using AutosApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace AutosApplication.Infrastructure.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;

        public VehicleService(IDbContextFactory<AppDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<List<Vehicle>> GetAllAsync()
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            return await db.Vehicles.AsNoTracking().ToListAsync();
        }

        public async Task<Vehicle?> GetByIdAsync(int vehicleId)
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            return await db.Vehicles.AsNoTracking().FirstOrDefaultAsync(v => v.VehicleId == vehicleId);
        }

        public async Task<Vehicle> AddAsync(Vehicle vehicle)
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            db.Vehicles.Add(vehicle);
            await db.SaveChangesAsync();
            return vehicle;
        }

        public async Task<Vehicle> UpdateAsync(Vehicle vehicle)
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            db.Vehicles.Update(vehicle);
            await db.SaveChangesAsync();
            return vehicle;
        }

        public async Task DeleteAsync(int vehicleId)
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            var vehicle = await db.Vehicles.FindAsync(vehicleId);
            if (vehicle is null) return;

            db.Vehicles.Remove(vehicle);
            await db.SaveChangesAsync();
        }
    }
}
