using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Model
{
    public class DriverDetail
    {
        [Required]
        //The driver's first name
        public string first_name { get; set; }
        [Required]
        //The driver's contact phone number. Must be E.164 formatted.
        public string phone_number { get; set; }
        [Required]
        //The driver's rating based in 0-5 scale
        public string rating { get; set; }
        public string image_url { get; set; }
    }
}
