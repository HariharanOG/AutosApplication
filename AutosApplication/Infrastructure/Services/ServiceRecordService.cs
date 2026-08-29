using AutosApplication.Data;
using AutosApplication.Infrastructure.Interfaces;
using AutosApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace AutosApplication.Infrastructure.Services
{
    public class ServiceRecordService : IServiceRecordService
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;

        public ServiceRecordService (IDbContextFactory<AppDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<List<ServiceRecord>> GetAllAsync()
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            return await db.ServiceRecords.AsNoTracking().ToListAsync();
        }

        public async Task<List<ServiceRecord>> GetByVehicleIdAsync(int vehicleId)
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            return await db.ServiceRecords.AsNoTracking()
                .Where(s => s.VehicleId == vehicleId)
                .OrderByDescending(s => s.ServiceDate)
                .ToListAsync();
        }

        public async Task<ServiceRecord?> GetByIdAsync(int serviceId)
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            return await db.ServiceRecords.AsNoTracking().FirstOrDefaultAsync(s => s.ServiceId == serviceId);
        }

        public async Task<ServiceRecord> AddAsync(ServiceRecord serviceRecord)
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            db.ServiceRecords.Add(serviceRecord);
            await db.SaveChangesAsync();
            return serviceRecord;
        }

        public async Task UpdateAsync(ServiceRecord serviceRecord)
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            db.ServiceRecords.Update(serviceRecord);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int serviceId)
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            var record = await db.ServiceRecords.FindAsync(serviceId);
            if (record is null) return;

            db.ServiceRecords.Remove(record);
            await db.SaveChangesAsync();
        }
    }
}
