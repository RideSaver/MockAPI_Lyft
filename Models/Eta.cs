namespace LyftAPI.Model
{
    public class Eta
    {
        //Estimated time of arrival
        public RideTypeEnum ride_type { get; set; }
        //A human readable description of the ride type
        public string display_name { get; set; }
        //Estimated seconds for a driver to arrive
        public int eta_seconds { get; set; }
        //The validity of the ETA estimate returned
        public bool is_valid_estimate { get; set; }

    }
}
