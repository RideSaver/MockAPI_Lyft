using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    public class UserDetail
    {
        [Required]
        public string? FirstName { get; set; }
        public string? ImageUrl { get; set; }
        public string? Rating { get; set; }
    }
}
