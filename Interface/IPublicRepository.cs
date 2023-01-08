using LyftAPI.Models;

namespace LyftAPI.Interface
{
    public interface IPublicRepository
    {
        Task<CostEstimateResponse> GetCostEstimates(LatLng start, LatLng end, string rideType);
        Task<EtaEstimateResponse> GetRideEstimates(LatLng location, string rideType);
        Task<RideTypesResponse> GetRideTypes(LatLng location, string rideType);
    }
}
