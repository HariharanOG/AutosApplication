using AutosApplication.Infrastructure.Interfaces;

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

        private async void AutoForm_Load(object sender, EventArgs e)
        {
            var vehicles = await _vehicleService.GetAllAsync();
            dataGridView1.DataSource = vehicles;
        }
    }
}