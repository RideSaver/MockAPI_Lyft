using LyftAPI.Models;

namespace LyftAPI.Interface
{
    public interface IPublicRepository
    {
        CostEstimateResponse GetCostEstimates(LatLng start, LatLng end, string rideType);
        EtaEstimateResponse GetRideEstimates(LatLng location, string rideType);
        RideTypesResponse GetRideTypes(LatLng location, string rideType);
    }
}
