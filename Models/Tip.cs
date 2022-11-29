namespace LyftAPI.Model
{
    public class Tip
    {
        //A tip for the driver in cents. To be charged to the user's default charge account.
        public int amount { get; set; }
        //The currency in which you want to tip. e.g. USD
        public string currency { get; set; }
    }
}
