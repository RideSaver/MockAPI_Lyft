namespace LyftAPI.Models
{
    public class NearbyDriversByRideType
    {
        public string? RideType { get; set; }
        public NearbyDriver? Drivers { get; set; }
    }
}
