using LyftAPI.Models;

namespace LyftAPI.Interface
{
    public interface IUserRepository
    {
        Task<RideDetail> GetUserRide(string id);
        InlineResponse200 GetUserRides();
        Ride PostUserRide(CreateRideRequest rideRequest);
        
    }
}
