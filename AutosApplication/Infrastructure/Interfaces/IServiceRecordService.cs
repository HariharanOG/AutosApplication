using AutosApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutosApplication.Infrastructure.Interfaces
{
    public interface IServiceRecordService
    {
        Task<List<ServiceRecord>> GetAllAsync();
        Task<List<ServiceRecord>> GetByVehicleIdAsync(int vehicleId);
        Task<ServiceRecord?> GetByIdAsync(int serviceId);
        Task<ServiceRecord> AddAsync(ServiceRecord serviceRecord);
        Task UpdateAsync(ServiceRecord serviceRecord);
        Task DeleteAsync(int serviceId);
    }
}
