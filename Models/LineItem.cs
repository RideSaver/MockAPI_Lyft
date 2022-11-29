using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Model
{
    public class LineItem
    {
        [Required]
        //The line item display name for a charge item
        public string type { get ; set;}
        [Required]
        //The line item amount
        public int amount { get; set; }
        [Required]
        //The currency for the amount
        public string currency { get; set; }
    }
}
