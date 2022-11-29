namespace LyftAPI.Model
{
    public class PricingDetails
    {
        //The base charge of the trip
        public int base_charge { get; set; }
        //The charge amount if cancel penalty is involved
        public int cancel_penalty_amount { get; set; }
        //The minimum charge for the trip
        public int cost_minimum { get; set; }
        //The cost per mile
        public int cost_per_mile { get; set; }
        //The cost per minute
        public int cost_per_minute { get; set; }
        //The ISO 4217 currency code for the amount (e.g. USD)
        public string currency { get; set; }
        //Trust and service fee
        public int trust_and_service { get; set; }
    }
}
