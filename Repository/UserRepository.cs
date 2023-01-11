using AutoBogus;
using Bogus;
using LyftAPI.Interface;
using LyftAPI.Models;
using LyftAPI.Registry;

namespace LyftAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        public async Task<RideDetail> GetUserRide(string id)
        {
            var rideDetailResponse = new RideDetail();
            rideDetailResponse = await Task.FromResult(RideDetailGenerator.GenerateRideDetail(2)!.First());

            return rideDetailResponse;
        }

        public InlineResponse200 GetUserRides()
        {
            var inlineResponse = new InlineResponse200();
            inlineResponse.RideHistory = RideDetailGenerator.GenerateRideDetail(10)!;

            return inlineResponse;
        }

        public Ride PostUserRide(CreateRideRequest rideRequest)
        {
            var rideResponse = new Ride();
            rideResponse = RideGenerator.GenerateRides(1)!.First();

            return rideResponse;
        }
    }
}
