using LyftAPI.Models;

namespace LyftAPI.Interface
{
    public interface IPublicRepository
    {
        Task<CostEstimateResponse> GetCostEstimates(LatLng start, LatLng end, string serviceName);
        Task<EtaEstimateResponse> GetRideEstimates(LatLng location, string rideType); // UNUSED
        Task<RideTypesResponse> GetRideTypes(LatLng location, string rideType); // UNUSED
    }
}
