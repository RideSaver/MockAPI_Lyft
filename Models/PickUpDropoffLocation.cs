using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    public class PickUpDropoffLocation
    {
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
        public string? Address { get; set; }
        public string? Time { get; set; }
    }
}
