namespace LyftAPI.Models
{
    public class RideDetail
    {
        public int RideId { get; set; }
        public RideStatusEnum? Status { get; set; }
        public PassengerDetail? Passenger { get; set; }
        public DriverDetail? Driver { get; set; }
        public VehicleDetail? Vehicle { get; set; }
        public RideLocation? Origin  { get; set; }
        public RideLocation? Destination { get; set; }
        public PickUpDropoffLocation? PickUp { get; set; }
        public PickUpDropoffLocation? DropOff { get; set; }
        public RideLocation? RideLocation { get; set; }
        public string? PrimeTimePercentage { get; set; }
        public Cost? Price { get; set; }
        public LineItem? LineItem { get; set; }
        public Enum? CanCancel { get; set; }
        public string? CanceledBy { get; set; }
        public CancellationCost? CancellationCost { get; set; }
        public int Rating { get; set; }
        public string? FeedBack { get; set; }
        public string? RouteUrl { get; set; }
        public string? RequestedAt { get; set; }
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
