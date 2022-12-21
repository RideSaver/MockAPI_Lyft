using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    public class Location
    {
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
        public string? Address { get; set; }
    }
}
