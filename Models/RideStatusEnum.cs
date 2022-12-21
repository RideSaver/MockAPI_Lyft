namespace LyftAPI.Models
{
    public class RideStatusEnum
    {
        public enum RideStatus
        {
            Pending,
            Accepted,
            Arrived,
            PickedUp,
            DroppedOff,
            Cancelled,
            Unknown
        }
    }
}
