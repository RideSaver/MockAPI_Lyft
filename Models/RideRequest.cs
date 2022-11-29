namespace LyftAPI.Model
{
    public class RideRequest
    {
        //The ID of the requested ride
        public string ride_id { get; set; }
        public RideStatusEnum status { get; set; }
        public Location origin { get; set; }
        public Location destination { get; set; }
        public PassengerDetail passenger { get; set; }

    }
}
