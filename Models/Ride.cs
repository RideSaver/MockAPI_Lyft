using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    public class Ride
    {
        [Required]
        public int RideId { get; set; }
        public Location? Origin { get; set; }
        public Location? Destination { get; set; }
        public string? PrimeTimeConfirmationToken { get; set; }
        public RideTypes RideType { get; set; }
        public enum RideTypes
        {
            Lyft,
            LyftLine,
            LyftPlus,
            LyftSuv
        }
    }
}
