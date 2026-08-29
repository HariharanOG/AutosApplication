using AutosApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutosApplication.Infrastructure.Interfaces
{
    public interface IVehicleService
    {
        Task<List<Vehicle>> GetAllAsync();
        Task<Vehicle?> GetByIdAsync(int vehicleId);
        Task<Vehicle> AddAsync(Vehicle vehicle);
        Task<Vehicle> UpdateAsync(Vehicle vehicle);
        Task DeleteAsync(int vehicleId);

    }
}
