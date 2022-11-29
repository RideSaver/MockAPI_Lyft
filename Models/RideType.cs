namespace LyftAPI.Model
{
    public class RideType
    {
        
        public RideTypeEnum? ride_type { get; set; }
        //A human readable description of the ride type
        public string display_name { get; set; }
        //The maximum number of seats available for rides requested with this ride type
        public int seats { get; set; }
        //The URL of an image representing this ride type
        public string image_url { get; set; }
        public PricingDetails? price_details { get; set; }
        public PricingDetails? scheduled_pricing_details { get; set; }

    }
}
