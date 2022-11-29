using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Model
{
    public class RatingRequest
    {
        [Required]
        //The passenger's rating of this ride from 1 to 5
        public int rating { get; set; }
        //The passenger's written feedback about this ride
        public string feedback { get; set; }
        public TipParams tip { get; set; }
    }
}
