using AutoBogus;
using Bogus;
using LyftAPI.Helper;
using LyftAPI.Models;

namespace LyftAPI.Registry
{
    public class RideTypeGenerator
    {
        public static string ImagePool = "";

        public static Faker<PricingDetails> PD_FAKER_CONFIG = new AutoFaker<PricingDetails>()
                .RuleFor(o => o.BaseCharge, fake => fake.Random.Int(1, 5))
                .RuleFor(o => o.CancelPenaltyAmount, () => 5)
                .RuleFor(o => o.CostMinimum, () => 3)
                .RuleFor(o => o.CostMinimum, fake => fake.Random.Int(1, 4))
                .RuleFor(o => o.CostPerMile, fake => fake.Random.Int(1, 3))
                .RuleFor(o => o.CostPerMinute, fake => fake.Random.Int(1, 4))
                .RuleFor(o => o.Currency, () => "USD")
                .RuleFor(o => o.TrustAndService, () => 3);

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
                    DisplayName = DataPool.NamePool.Random(),
                    Seats = 4,
                    ImageUrl = ImagePool,
                    PricingDetails = PD_FAKER_CONFIG.Generate(),
                    ScheduledPricingDetails = PD_FAKER_CONFIG.Generate()
                };

                rideTypes.Add(rideType);
            }

            return rideTypes;
        }
    }
}
