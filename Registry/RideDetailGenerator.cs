using AutoBogus;
using Bogus;
using LyftAPI.Helper;
using LyftAPI.Models;
using static LyftAPI.Models.RideDetail;

namespace LyftAPI.Registry
{
    public class RideDetailGenerator
    {
        public static Faker<PassengerDetail> PD_FAKER_CONFIG = new AutoFaker<PassengerDetail>()
                .RuleFor(o => o.FirstName, f => f.Name.FirstName())
                .RuleFor(o => o.ImageUrl, () => "Exempt")
                .RuleFor(o => o.Rating, () => "Exempt");

        public static Faker<DriverDetail> DD_FAKER_CONFIG = new AutoFaker<DriverDetail>()
                .RuleFor(o => o.FirstName, f => f.Name.FirstName())
                .RuleFor(o => o.PhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(o => o.Rating, () => "Exempt")
                .RuleFor(o => o.ImageUrl, () => "Exempt");

        public static Faker<VehicleDetail> V_Faker_CONFIG = new AutoFaker<VehicleDetail>()
                .RuleFor(o => o.Make, f => f.Vehicle.Manufacturer())
                .RuleFor(o => o.Model, f => f.Vehicle.Model())
                .RuleFor(o => o.Year, f => f.Random.Int(2007, 2022))
                .RuleFor(o => o.LicensePlate, () => "XY54FCZ")
                .RuleFor(o => o.LicensePlateState, () => "CA")
                .RuleFor(o => o.Color, f => f.Commerce.Color())
                .RuleFor(o => o.ImageUrl, () => "Exempt");

        public static Faker<RideLocation> RL_Faker_CONFIG = new AutoFaker<RideLocation>()
                .RuleFor(o => o.Lat, f => f.Random.Double(0f, 1f))
                .RuleFor(o => o.Lng, f => f.Random.Double(0f, 1f))
                .RuleFor(o => o.Address, f => f.Address.StreetName())
                .RuleFor(o => o.EtaSeconds, f => f.Random.Int(60, 560));

        public static Faker<PickupDropoffLocation> PDOL_Faker_CONFIG = new AutoFaker<PickupDropoffLocation>()
                .RuleFor(o => o.Time, () => DateTime.Now)
                .RuleFor(o => o.Lat, f => f.Random.Double(0f, 1f))
                .RuleFor(o => o.Lng, f => f.Random.Double(0f, 1f))
                .RuleFor(o => o.Address, f => f.Address.StreetName());

        public static Faker<Cost> C_Faker_CONFIG = new AutoFaker<Cost>()
                .RuleFor(o => o.Amount, f => f.Random.Int(5, 25))
                .RuleFor(o => o.Currency, () => "USD")
                .RuleFor(o => o.Description, () => "Price breakddown");

        public static Faker<CancellationCost> CC_Faker_CONFIG = new AutoFaker<CancellationCost>()
                .RuleFor(o => o.Token, () => "CANCELLATION-TOKEN-XXXCC")
                .RuleFor(o => o.TokenDuration, () => 5)
                .RuleFor(o => o.Currency, () => "USD")
                .RuleFor(o => o.Amount, f => f.Random.Number(0, 1))
                .RuleFor(o => o.Description, () => "Cancellation Cost Breakdown");

        public static List<RideDetail> GenerateRideDetail(int repeat)
        {
            var ridesDetail = new List<RideDetail>();
            if (repeat <= 0) return null;

            var rideStatusValues = Enum.GetValues(typeof(RideStatusEnum));
            var rideStatusOtherValues = Enum.GetValues(typeof(RideTypeEnumWithOther));
            Random random = new Random();

            for (int i = 0; i <= repeat; i++)
            {
                var rideDetail = new RideDetail()
                {
                    RideId = Guid.NewGuid().ToString(),
                    Status = (Models.RideStatusEnum)rideStatusValues.GetValue(random.Next(rideStatusValues.Length))!,
                    RideType = RideTypeEnumWithOther.LyftEnum,
                    Passenger = PD_FAKER_CONFIG.Generate(),
                    Driver = DD_FAKER_CONFIG.Generate(),
                    Vehicle = V_Faker_CONFIG.Generate(),
                    Origin = RL_Faker_CONFIG.Generate(),
                    Destination = RL_Faker_CONFIG.Generate(),
                    Pickup = PDOL_Faker_CONFIG.Generate(),
                    Dropoff = PDOL_Faker_CONFIG.Generate(),
                    Location = RL_Faker_CONFIG.Generate(),
                    PrimetimePercentage = "Exempt",
                    Price = C_Faker_CONFIG.Generate(),
                    CanceledBy = "Exempt",
                    Feedback = "Exempt",
                    Rating = 5,
                    RequestedAt = DateTime.Now,
                    RouteUrl = "Exempt",
                    LineItems = new List<LineItem>(),
                    CanCancel = new List<CanCancelEnum>(),
                    CancellationPrice = new CancellationCost()
                    {
                        Token = "CancellationToken",
                        TokenDuration = 10,
                        Description = "Cancellation Price Breakdown"
                    }
                };

                ridesDetail.Add(rideDetail);
            }

            return ridesDetail;
        }
    }
}
