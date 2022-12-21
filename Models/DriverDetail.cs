using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    public class DriverDetail
    {
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        public string? Rating { get; set; }
        public string? ImageUrl { get; set; }
    }
}
