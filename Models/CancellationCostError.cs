using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Model
{
    public class CancellationCostError
    {
        [Required]
        //Total price of the ride
        public int amount { get; set; }
        [Required]
        //The ISO 4217 currency code for the amount (e.g. USD)
        public string currency { get; set; }
        [Required]
        //The description for the cost
        public string description { get; set; }
        //Token used to confirm the fee when cancelling a request
        public string token { get; set; }
        //How long, in seconds, before the token expires
        public int token_duration { get; set; }
        //A "slug" that serves as the error code (eg. "bad_parameter")
        public string error { get; set; }

        public ErrorDetail error_detail { get; set; }

        //A user-friendly description of the error (appropriate to show to an end-user)
        public string error_description { get; set; }

    }
}
