namespace LyftAPI.Models
{
    public class CreateRideRequest
    {
        public string? CostToken { get; set; }
        public RideTypes RideType { get; set; }
        public Location? Origin { get; set; }
        public Location? Destination { get; set; }
        public PassengerDetail? Passenger { get; set; }
        public enum RideTypes
        {
            Lyft,
            LyftLine,
            LyftPlus,
            LyftSuv
        }
    }
}
