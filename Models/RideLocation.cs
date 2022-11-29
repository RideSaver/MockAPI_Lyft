using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Model
{
    public class RideLocation
    {
        [Required]
        //The latitude component of a location
        public double lat { get; set; }
        [Required]
        //The longitude component of a location
        public double lng { get; set; }
        //A human readable address at/near the given location
        public string address { get; set; }
        //Estimated seconds for a driver to pickup or reach destination based on ride state
        public int eta_seconds { get; set; }
    }
}
