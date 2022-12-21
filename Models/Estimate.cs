namespace LyftAPI.Models
{
    public class Estimate
    {
        public string? DisplayName { get; set; }
        public int EstimateSeconds { get; set; }
        public bool IsValidEstimate { get; set; }

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
