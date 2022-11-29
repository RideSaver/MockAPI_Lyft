using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace LyftAPI.Model
{
    public class CancellationCost
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
    }
}
