using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    public class CancellationCostError
    {
        [Required]
        public int Amount { get; set; }
        [Required]
        public string? Currency { get; set; }
        [Required]
        public string? Description { get; set; }
        public string? Token { get; set; }
        public int TokenDuration { get; set; }
        public string? Error { get; set; }
        public ErrorDetail? ErrorDetail { get; set; }

        public string? ErrorDescription { get; set; }

    }
}
