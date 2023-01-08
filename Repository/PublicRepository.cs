using AutoBogus;
using Bogus;
using LyftAPI.Interface;
using LyftAPI.Models;
using LyftAPI.Registry;

namespace LyftAPI.Repository
{
    public class PublicRepository : IPublicRepository
    {
        public async Task<CostEstimateResponse> GetCostEstimates(LatLng start, LatLng end, string rideType)
        {
            CostEstimateResponse costEstimateResponse = new CostEstimateResponse();
            costEstimateResponse.CostEstimates = await Task.FromResult(CostEstimateGenerator.GenerateCostEstimate(10)!);

            return costEstimateResponse;
        }

        public async Task<EtaEstimateResponse> GetRideEstimates(LatLng location, string rideType)
        {
            EtaEstimateResponse etaEstimateResponse = new EtaEstimateResponse();
            etaEstimateResponse.EtaEstimates = await Task.FromResult(ETAGenerator.GenerateETA(10)!);

            return etaEstimateResponse;
        }

        public async Task<RideTypesResponse> GetRideTypes(LatLng location, string rideType)
        {
            RideTypesResponse rideTypesResponse = new RideTypesResponse();
            rideTypesResponse.RideTypes = await Task.FromResult(RideTypeGenerator.GenerateRideTypes(10)!);

            return rideTypesResponse;
        }
    }
}
