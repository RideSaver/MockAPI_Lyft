namespace LyftAPI.Models
{
    public class RideType
    {
        public string? DisplayName { get; set; }
        public int Seats { get; set; }
        public string? ImageUrl { get; set; }
        public PricingDetails? PriceDetails { get; set; }
        public PricingDetails? ScheduledPricingDetails { get; set; }
        public RideTypes Ride_Type { get; set; }
        public enum RideTypes
        {
            Lyft,
            LyftLine,
            LyftPlus,
            LyftSuv
        }

    }
}
