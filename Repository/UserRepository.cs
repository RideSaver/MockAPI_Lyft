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

            var rideDetail = AutoFaker.Generate<RideDetail>();

            rideDetailResponse = rideDetail;

            return rideDetailResponse;
        }

        public InlineResponse200 GetUserRides()
        {
            var rideHistoryList = AutoFaker.Generate<RideDetail>(10);
            var inlineResponse = new InlineResponse200();
            inlineResponse.RideHistory = rideHistoryList;
            return inlineResponse;
        }

        public Ride PostUserRide(CreateRideRequest rideRequest)
        {
            var rideResponse = new Ride();

            var ride = AutoFaker.Generate<Ride>();

            rideResponse = ride;
            return rideResponse;
        }
    }
}
