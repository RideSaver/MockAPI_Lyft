using LyftAPI.Helper;
using LyftAPI.Models;

namespace LyftAPI.Registry
{
    public static class ETAGenerator
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

        public static IEnumerable<double> ETASecondsPool = (IEnumerable<double>)Enumerable.Range(60, 560); // ETA Seconds
        public static bool isValid = true;


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
                    DisplayName = NamePool.Random(),
                    EtaSeconds = (int?)ETASecondsPool.Random(),
                    IsValidEstimate = isValid
                };

                estimateList.Add(eta);
            }

            return estimateList;
        }
    }
}
