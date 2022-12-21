namespace LyftAPI.Models
{
    public class CostEstimate
    {
        public string? DisplayName { get; set; }
        public string? Currency { get; set; }
        public int EstimatedCostMin { get; set; }
        public int EstimatedCostMax { get; set; }
        public double EstimatedDistanceMiles { get; set; }
        public int EstimatedDurationSeconds { get; set; }
        public bool IsValidEstimate { get; set; }
        public string? PrimeTimePercentage { get; set; }
        public string? PrimeTimeConfirmationToken { get; set; }
        public RideTypes RideType { get; set; }
        public enum RideTypes
        {
            Lyft,
            LyftLine,
            LyftPlus,
            LyftSuv
        }
    }
}
