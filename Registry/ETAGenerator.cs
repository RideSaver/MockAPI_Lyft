using LyftAPI.Helper;
using LyftAPI.Models;

namespace LyftAPI.Registry
{
    public static class ETAGenerator
    {
        public static IEnumerable<int> ETASecondsPool = Enumerable.Range(60, 560); // ETA Seconds
        public static List<Eta>? GenerateETA(int repeat)
        {
            var estimateList = new List<Eta>();
            if (repeat <= 0) return null;

            var rideTypeValues = Enum.GetValues(typeof(RideTypeEnum));
            Random random = new Random();

            for (int i = 0; i <= repeat; i++)
            {
                var eta = new Eta()
                {
                    RideType = (Models.RideTypeEnum)rideTypeValues.GetValue(random.Next(rideTypeValues.Length))!,
                    DisplayName = DataPool.NamePool.Random(),
                    EtaSeconds = ETASecondsPool.Random(),
                    IsValidEstimate = true
                };

                estimateList.Add(eta);
            }
            return estimateList;
        }
    }
}
