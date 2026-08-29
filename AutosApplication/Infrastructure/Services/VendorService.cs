using AutosApplication.Data;
using AutosApplication.Models;
using AutosApplication.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutosApplication.Infrastructure.Services
{
    public class VendorService : IVendorService
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;

        public VendorService(IDbContextFactory<AppDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<List<Vendor>> GetAllAsync()
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            return await db.Vendor.AsNoTracking().ToListAsync();
        }

        public async Task<Vendor?> GetByIdAsync(int vendorId)
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            return await db.Vendor.AsNoTracking().FirstOrDefaultAsync(v => v.VendorId == vendorId);
        }

        public async Task<Vendor> AddAsync(Vendor vendor)
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            db.Vendor.Add(vendor);
            await db.SaveChangesAsync();
            return vendor;
        }

        public async Task UpdateAsync(Vendor vendor)
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            db.Vendor.Update(vendor);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int vendorId)
        {
            await using var db = await _dbContextFactory.CreateDbContextAsync();
            var vendor = await db.Vendor.FindAsync(vendorId);
            if (vendor is null) return;

            db.Vendor.Remove(vendor);
            await db.SaveChangesAsync();
        }


    }
}
