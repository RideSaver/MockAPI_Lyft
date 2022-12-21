using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    public class LatLng
    {
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
    }
}
