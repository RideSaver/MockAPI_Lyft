using AutoBogus;
using Bogus;
using LyftAPI.Interface;
using LyftAPI.Models;

namespace LyftAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        public RideDetail GetUserRide(string id)
        {
            var rideDetailResponse = new RideDetail();
            rideDetailResponse = AutoFaker.Generate<RideDetail>();

            return rideDetailResponse;
        }

        public InlineResponse200 GetUserRides()
        {
            var inlineResponse = new InlineResponse200();
            inlineResponse.RideHistory = AutoFaker.Generate<RideDetail>(10);

            return inlineResponse;
        }

        public Ride PostUserRide(CreateRideRequest rideRequest)
        {
            var rideResponse = new Ride();
            rideResponse = AutoFaker.Generate<Ride>();

            return rideResponse;
        }
    }
}
