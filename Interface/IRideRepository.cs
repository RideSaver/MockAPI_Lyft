using LyftAPI.Models;

namespace LyftAPI.Interface
{
    public interface IRideRepository
    {
        List<RideType> GetRideTypes();
    }
}
