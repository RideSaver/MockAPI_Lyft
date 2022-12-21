namespace LyftAPI.Models
{
    public class Error
    {
        public string? ErrorMessage { get; set; }
        public ErrorDetail? ErrorDetail { get; set; }
        public string? ErrorDescription { get; set; }
    }
}
