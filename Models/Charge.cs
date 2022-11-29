using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Model
{
    public class Charge
    {
        [Required]
        //The line item amount
        public int amount { get; set; }
        [Required]
        //The currency for the amount
        public string currency { get; set; }
        [Required]
        //The payment method display name
        public string payment_method { get; set; }
    }
}
