using AutoBogus;
using Bogus;
using LyftAPI.Interface;
using LyftAPI.Models;
using LyftAPI.Registry;

namespace LyftAPI.Repository
{
    public class PublicRepository : IPublicRepository
    {
        public CostEstimateResponse GetCostEstimates(LatLng start, LatLng end, string rideType)
        {
            CostEstimateResponse costEstimateResponse = new CostEstimateResponse();
            costEstimateResponse.CostEstimates = CostEstimateGenerator.GenerateCostEstimate(10)!;

            return costEstimateResponse;
        }

        public EtaEstimateResponse GetRideEstimates(LatLng location, string rideType)
        {
            EtaEstimateResponse etaEstimateResponse = new EtaEstimateResponse();
            etaEstimateResponse.EtaEstimates = ETAGenerator.GenerateETA(10)!;

            return etaEstimateResponse;
        }

        public RideTypesResponse GetRideTypes(LatLng location, string rideType)
        {
            RideTypesResponse rideTypesResponse = new RideTypesResponse();
            rideTypesResponse.RideTypes = RideTypeGenerator.GenerateRideTypes(10)!;

            return rideTypesResponse;
        }
    }
}
