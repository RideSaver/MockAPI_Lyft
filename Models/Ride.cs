using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Model
{
    public class Ride
    {
        //The unique ID of this ride
        private readonly int ride_id { get; set; }
        [Required]
        public RideTypeEnum ride_type { get; set; }
        [Required]
        public Location origin { get; set; }
        public Location destination { get; set; }
        //A token that confirms the user has accepted current primetime charges
        public string primetime_confirmation_token { get; set; }
    }
}
