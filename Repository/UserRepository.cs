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

        public async Task<Ride> PostUserRide(CreateRideRequest rideRequest)
        {
            var rideResponse = new Ride();
            rideResponse = await Task.FromResult(RideGenerator.GenerateRides(1)!.First());

            return rideResponse;
        }

        public async Task<InlineResponse200> GetUserRides() // UNUSED
        {
            var inlineResponse = new InlineResponse200();
            inlineResponse.RideHistory = await Task.FromResult(RideDetailGenerator.GenerateRideDetail(10)!);

            return inlineResponse;
        }
    }
}
