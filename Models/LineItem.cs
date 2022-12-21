using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    public class LineItem
    {
        [Required]
        public string? Type { get ; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public string? Currency { get; set; }
    }
}
