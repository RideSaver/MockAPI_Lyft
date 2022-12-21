using LyftAPI.Helper;
using LyftAPI.Models;
using System;
using System.Runtime.Serialization;

namespace LyftAPI.Registry
{
    public static class CostEstimateGenerator
    {
        public static readonly IEnumerable<string> NamePool = new List<string>() // Display Name Pool
        {
            "John",
            "Luke",
            "Elias",
            "Rick",
            "Luis",
            "Richard",
            "Aaron",
            "Robert",
            "Ben",
            "Micheal",
            "Mark",
            "Nathan",
            "Kimberly",
            "Cecilia",
            "Eydie",
            "Jordan",
            "Emily",
            "Kylie",
            "Tania",
            "Dylan",
            "Aina",
            "Morgan",
            "Olivia",
            "Reena",
            "Jeremy",
            "Oliver",
            "Reda",
            "Neven",
            "Matthew",
            "Ryan",
            "Amith",
            "Luke",
            "Zahira",
            "Juan",
            "Ahmed",
            "Carlos",
            "Ming",
            "Allen",
            "Anthony"
        };

        public static IEnumerable<int> EstimatedCostMinimumPool = Enumerable.Range(100, 10000); // Estimated Cost (minimum)
        public static IEnumerable<int> EstimatedCostMaximumPool = Enumerable.Range(500, 50000); // Estimated Cost (maximum)
        public static IEnumerable<double> EstimatedDistnaceMilePool = (IEnumerable<double>)Enumerable.Range(10, 50); // Estimated Distance
        public static IEnumerable<double> EstimatedDurationSecondsPool = (IEnumerable<double>)Enumerable.Range(500, 1000); // Estimated Duration

        public static bool isValid = true; // Valid Estimate (always true)
        public static string CurrencyPool = "USD"; // Currency (always USD)
        public static string PrimeTimePercentage = "Exempt"; // 
        public static string PrimeTimeConfirmationToken = "Exempt"; // 

        public static List<CostEstimate>? GenerateCostEstimate(int repeat)
        {
            var costEstimates = new List<CostEstimate>();
            if (repeat <= 0) return null;

            var rideTypeValues = Enum.GetValues(typeof(RideTypeEnum));
            Random random = new Random();

            for (int i = 0; i <= repeat; i++)
            {
                var costEstimate = new CostEstimate()
                {
                    RideType = (Models.RideTypeEnum)rideTypeValues.GetValue(random.Next(rideTypeValues.Length))!,
                    DisplayName = NamePool.Random(),
                    Currency = CurrencyPool,
                    EstimatedCostCentsMin = EstimatedCostMinimumPool.Random(),
                    EstimatedCostCentsMax = EstimatedCostMaximumPool.Random(),
                    EstimatedDistanceMiles = EstimatedDistnaceMilePool.Random(),
                    EstimatedDurationSeconds = (int?)EstimatedDurationSecondsPool.Random(),
                    IsValidEstimate = isValid,
                    PrimetimePercentage = PrimeTimePercentage,
                    PrimetimeConfirmationToken = PrimeTimeConfirmationToken
                };

                costEstimates.Add(costEstimate);
            }

            return costEstimates;
        }
    }
}
