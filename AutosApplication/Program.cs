using AutosApplication.Data;
using AutosApplication.Infrastructure.Interfaces;
using AutosApplication.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AutosApplication
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                .Build();

            var services = new ServiceCollection();

            services.AddDbContextFactory<AppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("Default")));

            services.AddScoped<IVehicleService, VehicleService>();
            services.AddScoped<IVendorService, VendorService>();
            services.AddScoped<IServiceRecordService, ServiceRecordService>();

            var provider = services.BuildServiceProvider();
            var vehicleService = provider.GetRequiredService<IVehicleService>();

            Application.Run(new AutoForm(vehicleService));
        }
    }
}