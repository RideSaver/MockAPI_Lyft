namespace LyftAPI.Model
{
    public class RideDetail
    {
        //The unique ID of this ride
        public string ride_id { get; set; }
        public RideStatusEnum status { get; set; }
        public RideTypeEnumWithOther ride_type { get; set; }
        public PassengerDetail passenger { get; set; }
        public DriverDetail driver { get; set; }
        public VehicleDetail vehicle { get; set; }
        public RideLocation origin  { get; set; }
        public RideLocation destination { get; set; }
        public PickUpDropoffLocation pickup { get; set; }
        public PickUpDropoffLocation dropoff { get; set; }
        public RideLocation location { get; set; }
        public string primetime_percentage { get; set; }
        public Cost price { get; set; }
        public LineItem line_items { get; set; }
        public Enum can_cancel { get; set; }
        public string canceled_by { get; set; }
        public CancellationCost cancellation_price { get; set; }
        //The rating the user left for this ride, from 1 to 5
        public int rating { get; set; }
        //The written feedback the user left for this ride
        public string feedback { get; set; }
        //The web view showing the passenger, driver, and route for this ride.
        public string route_url { get; set; }
        //The ride requested timestamp in date and time
        public string requested_at { get; set; }
    }
}
