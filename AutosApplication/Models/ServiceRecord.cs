namespace AutosApplication.Models
{
    public class ServiceRecord
    {
        public int ServiceId { get; set; }

        public int VehicleId { get; set; }
        public Vehicle? Vehicle { get; set; }

        public int? VendorId { get; set; }
        public Vendor? Vendor { get; set; }

        public DateTime ServiceDate { get; set; }
        public string ServiceType { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int MileageAtService { get; set; }
        public decimal Cost { get; set; }
    }
}