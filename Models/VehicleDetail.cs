using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Model
{
    public class VehicleDetail
    {
        //The vehicle's maker
        public string make { get; set; }
        [Required]
        //The vehicle's model
        public string model { get; set; }
        [Required]
        //The vehicle's model year
        public int year { get; set; }
        [Required]
        //The vehicle's license plate
        public string license_plate { get; set; }
        //The vehicle's license plate state
        public string license_plate_state { get; set; }
        [Required]
        //The vehicle's color
        public string color { get; set; }
        [Required]
        //The vehicle's image url
        public string image_url { get; set; }
    }
}
