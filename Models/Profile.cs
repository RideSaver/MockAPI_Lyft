using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    public class Profile
    {
        [Required]
        public string? Id { get; set; }
    }
}
