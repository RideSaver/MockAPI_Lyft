using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Model
{
    public class Profile
    {
        //The unique ID of this user
        [Required]
        public string id { get; set; }
    }
}
