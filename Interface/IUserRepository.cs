using LyftAPI.Models;

namespace LyftAPI.Interface
{
    public interface IUserRepository
    {
        Task<RideDetail> GetUserRide(string id);
        Task<Ride> PostUserRide(CreateRideRequest rideRequest);
        Task<InlineResponse200>GetUserRides(); // UNUSED
       
    }
}
