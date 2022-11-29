using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Model
{
    public class Cost
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
    }
}
