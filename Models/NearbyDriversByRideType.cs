namespace LyftAPI.Model
{
    public class NearbyDriversByRideType
    {
        //driver's ride type. if driver is eligable for several ride types, he will be duplicated.
        public string ride_type { get; set; }
        //list of nearby drivers group by ride type sorted by eta
        public NearbyDriver drivers { get; set; }
    }
}
