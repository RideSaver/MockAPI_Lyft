using LyftAPI.Helper;
using LyftAPI.Models;
using System;
using System.Runtime.Serialization;

namespace LyftAPI.Registry
{
    public static class CostEstimateGenerator
    {
       
        public static IEnumerable<int> EstimatedCostMinimumPool = Enumerable.Range(1000, 2000); // Estimated Cost (minimum)
        public static IEnumerable<int> EstimatedCostMaximumPool = Enumerable.Range(2000, 5000); // Estimated Cost (maximum)
        public static IEnumerable<int> EstimatedDistnaceMilePool = Enumerable.Range(10, 50); // Estimated Distance
        public static IEnumerable<int> EstimatedDurationSecondsPool = Enumerable.Range(500, 1000); // Estimated Duration

        public static string CurrencyPool = "USD"; // Currency (always USD)
        public static string PrimeTimePercentage = "Disabled"; // 
        public static string PrimeTimeConfirmationToken = Guid.NewGuid().ToString();

        public static List<CostEstimate>? GenerateCostEstimate(string serviceName, RideTypeEnum rideType)
        {
            var costEstimates = new List<CostEstimate>();
            var rideTypeValues = Enum.GetValues(typeof(RideTypeEnum));
            Random random = new Random();

            var costEstimate = new CostEstimate()
            {
                RideType = rideType,
                DisplayName = serviceName,
                Currency = CurrencyPool,
                IsValidEstimate = true,
                EstimatedCostCentsMin = EstimatedCostMinimumPool.Random(),
                EstimatedCostCentsMax = EstimatedCostMaximumPool.Random(),
                EstimatedDistanceMiles = (double)EstimatedDistnaceMilePool.Random(),
                EstimatedDurationSeconds = EstimatedDurationSecondsPool.Random(),
                PrimetimePercentage = PrimeTimePercentage,
                PrimetimeConfirmationToken = PrimeTimeConfirmationToken
            };

            costEstimates.Add(costEstimate);
            return costEstimates;
        }
    }
}
