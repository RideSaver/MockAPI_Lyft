using AutoBogus;
using Bogus;
using LyftAPI.Interface;
using LyftAPI.Models;
using LyftAPI.Registry;

namespace LyftAPI.Repository
{
    public class PublicRepository : IPublicRepository
    {
        public async Task<CostEstimateResponse> GetCostEstimates(LatLng start, LatLng end, string serviceName)
        {
            CostEstimateResponse costEstimateResponse = new CostEstimateResponse();
            var rideType = GetRideTypeFromServiceName(serviceName);
            costEstimateResponse.CostEstimates = await Task.FromResult(CostEstimateGenerator.GenerateCostEstimate(serviceName, rideType)!);

            return costEstimateResponse;
        }

        public RideTypeEnum GetRideTypeFromServiceName(string serviceName)
        {
            switch (serviceName)
            {
                case "lyft": return RideTypeEnum.LyftEnum;
                case "lyft_shared": return RideTypeEnum.LyftLineEnum;
                case "lyft_lux": return RideTypeEnum.LyftPlusEnum;
                case "lyft_suv": return RideTypeEnum.LyftSuvEnum;
                default: return RideTypeEnum.LyftEnum; 
            }
        }

        public async Task<EtaEstimateResponse> GetRideEstimates(LatLng location, string rideType) // UNUSED
        {
            EtaEstimateResponse etaEstimateResponse = new EtaEstimateResponse();
            etaEstimateResponse.EtaEstimates = await Task.FromResult(ETAGenerator.GenerateETA(10)!);

            return etaEstimateResponse;
        }
        public async Task<RideTypesResponse> GetRideTypes(LatLng location, string rideType) // UNUSED
        {
            RideTypesResponse rideTypesResponse = new RideTypesResponse();
            rideTypesResponse.RideTypes = await Task.FromResult(RideTypeGenerator.GenerateRideTypes(10)!);

            return rideTypesResponse;
        }
    }
}
