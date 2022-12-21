namespace LyftAPI.Models
{
    public class RideRequest
    {
        public string? RideId { get; set; }
        public RideStatusEnum? Status { get; set; }
        public Location? Origin { get; set; }
        public Location? Destination { get; set; }
        public PassengerDetail? Passenger { get; set; }

    }
}
