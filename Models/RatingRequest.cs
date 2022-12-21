using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    public class RatingRequest
    {
        [Required]
        public int Rating { get; set; }
        public string? FeedBack { get; set; }
        public TipParams? Tip { get; set; }
    }
}
