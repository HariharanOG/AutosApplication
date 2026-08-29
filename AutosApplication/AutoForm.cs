using AutosApplication.Data;
using AutosApplication.Infrastructure.Interfaces;
using AutosApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace AutosApplication
{
    public partial class AutoForm : Form
    {
        private readonly IVehicleService _vehicleService;

        public AutoForm(IVehicleService vehicleService)
        {
            InitializeComponent();
            _vehicleService = vehicleService;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vehicles = _vehicleService.GetAllAsync();
            dataGridView1.DataSource = vehicles;
        }
    }
}