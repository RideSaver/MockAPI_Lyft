using LyftAPI.Interface;
using LyftAPI.Models;

namespace LyftAPI.Repository
{
    public class EstimateRepository : IEstimateRepository
    {
        public List<Estimate> GetEstimates()
        {
            var rideEstimates = new List<Estimate>()
            {
                new Estimate()
                {
                    DisplayName = "LyftEstimate",
                    EstimateSeconds = 120,
                    IsValidEstimate = true,
                    RideType = Estimate.RideTypes.Lyft
                },
                new Estimate()
                {
                    DisplayName = "LyftLineEstimate",
                    EstimateSeconds = 320,
                    IsValidEstimate = true,
                    RideType = Estimate.RideTypes.LyftLine
                },
                new Estimate()
                {
                    DisplayName = "LyftPlusEstimate",
                    EstimateSeconds = 220,
                    IsValidEstimate = true,
                    RideType = Estimate.RideTypes.LyftPlus
                },
                new Estimate()
                {
                    DisplayName = "LyftSUVEstimate",
                    EstimateSeconds = 320,
                    IsValidEstimate = true,
                    RideType = Estimate.RideTypes.LyftSuv
                },
            };

            return rideEstimates;
        }
    }
}
