namespace LyftAPI.Model
{
    public class CostEstimate
    {
        //Estimated time of arrival
        public RideTypeEnum ride_type { get; set; }
        //A human readable description of the ride type
        public string display_name { get; set; }
        //The ISO 4217 currency code for the amount (e.g. 'USD')
        public string currency { get; set; }
        //Estimated lower bound for trip cost
        public int estimated_cost_cents_min { get; set; }
        //Estimated upper bound for trip cost
        public int estimated_cost_cents_max { get; set; }
        //Estimated distance for this trip
        public double estimated_distance_miles { get; set; }
        //Estimated time to get from the start location to the end.
        public int estimated_duration_seconds { get; set; }
        //The validity of the cost estimate returned
        public bool is_valid_estimate { get; set; }
        //Current Prime Time Percentage.
        public string primetime_percentage { get; set; }
        //This token is needed when requesting rides. See 'Request a Lyft' for more details
        public string primetime_confirmation_token { get; set; }



    }
}
