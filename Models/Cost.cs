using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    public class Cost
    {
        [Required]
        public int Amount { get; set; }
        [Required]
        public string? Currency { get; set; }
        [Required]
        public string? Description { get; set; }
    }
}
