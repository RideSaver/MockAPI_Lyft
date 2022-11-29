using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Model
{
    public class Location
    {
        [Required]
        //The latitude component of a location
        public double lat { get; set; }
        [Required]
        //The longitude component of a location
        public double lng { get; set; }
        //A human readable address at/near the given location
        public string address { get; set; }
    }
}
