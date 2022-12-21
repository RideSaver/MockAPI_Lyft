namespace LyftAPI.Models
{
    public class RideReceipt
    {
        public string? RideId { get; set; }
        public Cost? Price { get; set; }
        public LineItem? LineItem { get; set; }
        public Charge? Charges { get; set; }
        public string? RequestedAt { get; set; }
    }
}
