namespace LyftAPI.Model
{
    public class Error
    {
        //A "slug" that serves as the error code (eg. "bad_parameter")
        public string error{ get; set; }
        public ErrorDetail error_detail { get; set; }
        //A user-friendly description of the error (appropriate to show to an end-user)
        public string error_description { get; set; }

    }
}
