using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    public class RideLocation
    {
        [Required]
        public double Lat { get; set; }
        [Required]
        public double Long { get; set; }
        public string? Address { get; set; }
        public int EstimateSeconds { get; set; }
    }
}
