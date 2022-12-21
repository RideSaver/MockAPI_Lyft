using AutoBogus;
using Bogus;
using LyftAPI.Interface;
using LyftAPI.Models;

namespace LyftAPI.Repository
{
    public class PublicRepository : IPublicRepository
    {
        public CostEstimateResponse GetCostEstimates(LatLng start, LatLng end, string rideType)
        {
            var costEstimateResponse = new CostEstimateResponse();
            costEstimateResponse.CostEstimates = AutoFaker.Generate<CostEstimate>(10);

            return costEstimateResponse;
        }

        public EtaEstimateResponse GetRideEstimates(LatLng location, string rideType)
        {
            var etaEstimateResponse = new EtaEstimateResponse();
            etaEstimateResponse.EtaEstimates = AutoFaker.Generate<Eta>(10);

            return etaEstimateResponse;
        }

        public RideTypesResponse GetRideTypes(LatLng location, string rideType)
        {
            var rideTypesResponse = new RideTypesResponse();
            rideTypesResponse.RideTypes = AutoFaker.Generate<RideType>(10);

            return rideTypesResponse;
        }
    }
}
