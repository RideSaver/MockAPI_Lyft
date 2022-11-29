using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Model
{
    public class LatLng
    {
        [Required]
        //The latitude component of a location
        public double lat { get; set; }
        [Required]
        //The longitude component of a location
        public double lng { get; set; }
    }
}
