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

            var rideDetailList = AutoFaker.Generate<CostEstimate>(10);
            costEstimateResponse.CostEstimates = rideDetailList;

            return costEstimateResponse;
        }

        public EtaEstimateResponse GetRideEstimates(LatLng location, string rideType)
        {
            var etaEstimateResponse = new EtaEstimateResponse();

            var etaList = AutoFaker.Generate<Eta>(10);
            etaEstimateResponse.EtaEstimates = etaList;

            return etaEstimateResponse;
        }

        public RideTypesResponse GetRideTypes(LatLng location, string rideType)
        {
            var rideTypesResponse = new RideTypesResponse();

            var rideTypeList = AutoFaker.Generate<RideType>(10);
            rideTypesResponse.RideTypes = rideTypeList;

            return rideTypesResponse;
        }
    }
}
