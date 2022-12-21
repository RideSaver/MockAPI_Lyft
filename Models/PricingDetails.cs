namespace LyftAPI.Models
{
    public class PricingDetails
    {
        public int BaseCharge { get; set; }
        public int CancelPenaltyAmount { get; set; }
        public int CostMinimum { get; set; }
        public int CostPerMile { get; set; }
        public int CostPerMinute { get; set; }
        public string? Currency { get; set; }
        public int TrustAndServices { get; set; }
    }
}
