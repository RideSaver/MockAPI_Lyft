using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    public class Charge
    {
        [Required]
        public int Amount { get; set; }
        [Required]
        public string? Currency { get; set; }
        [Required]
        public string? PaymentMethod { get; set; }
    }
}
