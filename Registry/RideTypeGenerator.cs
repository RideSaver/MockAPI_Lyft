using AutoBogus;
using LyftAPI.Helper;
using LyftAPI.Models;

namespace LyftAPI.Registry
{
    public class RideTypeGenerator
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

        public static int seatsPool = 4;
        public static string ImagePool = "";

        public static List<RideType>? GenerateRideTypes(int repeat)
        {
            var rideTypes = new List<RideType>();
            if (repeat <= 0) return null;

            var rideTypeValues = Enum.GetValues(typeof(RideTypeEnum));
            Random random = new Random();

            for (int i = 0; i <= repeat; i++)
            {
                var rideType = new RideType()
                {
                    _RideType = (Models.RideTypeEnum)rideTypeValues.GetValue(random.Next(rideTypeValues.Length))!,
                    DisplayName = NamePool.Random(),
                    Seats = seatsPool,
                    ImageUrl = ImagePool,
                    PricingDetails = AutoFaker.Generate<PricingDetails>(),
                    ScheduledPricingDetails = AutoFaker.Generate<PricingDetails>()
                };

                rideTypes.Add(rideType);
            }

            return rideTypes;

        }
    }
}
