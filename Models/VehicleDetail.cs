using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    public class VehicleDetail
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public string? LicensePlate { get; set; }
        public string? LicensePlateState { get; set; }
        public string? Color { get; set; }
        public string? ImageUrl { get; set; }
    }
}
