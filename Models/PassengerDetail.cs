using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    public class PassengerDetail
    {
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        [Required]
        public string? Rating { get; set; }
    }
}
