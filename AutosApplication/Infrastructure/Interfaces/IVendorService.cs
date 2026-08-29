using AutosApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutosApplication.Infrastructure.Interfaces
{
    public interface IVendorService
    {
        Task<List<Vendor>> GetAllAsync();
        Task<Vendor?> GetByIdAsync(int vendorId);
        Task<Vendor> AddAsync(Vendor vendor);
        Task UpdateAsync(Vendor vendor);
        Task DeleteAsync(int vendorId);
    }
}
