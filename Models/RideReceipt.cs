namespace LyftAPI.Model
{
    public class RideReceipt
    {
        //The unique ID of this ride
        public string ride_id { get; set; }
        public Cost price { get; set; }
        //The break down of line items
        public LineItem line_items { get; set; }
        //he break down of charge method
        public Charge charges { get; set; }
        //The ride requested timestamp in date and time
        public string requested_at { get; set; }
    }
}
