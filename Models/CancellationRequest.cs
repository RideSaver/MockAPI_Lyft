namespace LyftAPI.Model
{
    public class CancellationRequest
    {
        //Token affirming the user accepts the cancellation fee. Required if a cancellation fee is in effect.
        public string cancel_confirmation_token { get; set; }
    }
}
