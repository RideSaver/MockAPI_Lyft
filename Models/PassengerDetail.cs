using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Model
{
    public class PassengerDetail
    {
        [Required]
        //The passenger's first name
        public string first_name { get; set; }
        [Required]
        //The passenger's profile image
        public string image_url { get; set; }
        [Required]
        //The passenger's rating
        public string rating { get; set; }
    }
}
