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
            return await db.Vehicle.AsNoTracking().ToListAsync();
        }

        public async Task<Vehicle?> GetByIdAsync(int vehicleId)
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            return await db.Vehicle.AsNoTracking().FirstOrDefaultAsync(v => v.VehicleId == vehicleId);
        }

        public async Task<Vehicle> AddAsync(Vehicle vehicle)
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            db.Vehicle.Add(vehicle);
            await db.SaveChangesAsync();
            return vehicle;
        }

        public async Task<Vehicle> UpdateAsync(Vehicle vehicle)
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            db.Vehicle.Update(vehicle);
            await db.SaveChangesAsync();
            return vehicle;
        }

        public async Task DeleteAsync(int vehicleId)
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            var vehicle = await db.Vehicle.FindAsync(vehicleId);
            if (vehicle is null) return;

            db.Vehicle.Remove(vehicle);
            await db.SaveChangesAsync();
        }
    }
}
