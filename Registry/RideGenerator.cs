using AutoBogus;
using Bogus;
using LyftAPI.Helper;
using LyftAPI.Models;

namespace LyftAPI.Registry
{
    public class RideGenerator
    {
        public static Faker<Location> L_FAKER_CONFIG = new AutoFaker<Location>()
        .RuleFor(o => o.Address, f => f.Address.FullAddress());

        public static List<Ride>? GenerateRides(int repeat)
        {

            var rides = new List<Ride>();
            if (repeat <= 0) return null;

            for (int i = 0; i <= repeat; i++)
            {
                var ride = new Ride()
                {
                    RideId = "0000-0000-0000-0000",
                    Origin = L_FAKER_CONFIG.Generate(),
                    Destination = L_FAKER_CONFIG.Generate(),
                    PrimetimeConfirmationToken = "Exempt"
                };

                rides.Add(ride);
            }

            return rides;
        }
    }
}
