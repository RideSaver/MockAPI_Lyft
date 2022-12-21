using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    public class RideRequestError
    {
        [Required]
        public string? Error { get; set; }
        public ErrorDetail? ErrorDetail { get; set; }
        public string? ErrorDescription { get; set; }
        public string? PrimeTimePercentage { get; set; }
        public string? PrimeTimeConfirmationToken { get; set; }
        public string? TokenDuration { get; set; }
    }
}
