using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Model
{
    public class RideRequestError
    {
        [Required]
        //A "slug" that serves as the error code (eg. "bad_parameter")
        public string error { get; set; }
        public ErrorDetail error_detail { get; set; }
        //A user-friendly description of the error (appropriate to show to an end-user)
        public string error_description { get; set; }
        //Current Prime Time percentage
        public string primetime_percentage { get; set; }
        //A token that confirms the user has accepted current Prime Time charges
        public string primetime_confirmation_token { get; set; }
        //Validity of the token in seconds
        public string token_duration { get; set; }
    }
}
