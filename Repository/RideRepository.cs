using LyftAPI.Interface;
using LyftAPI.Models;

namespace LyftAPI.Repository
{
    public class RideRepository : IRideRepository
    {
        public List<RideType> GetRideTypes()
        {
            var rideTypes = new List<RideType>()
            {
                new RideType
                {
                     Ride_Type = RideType.RideTypes.Lyft,
                     DisplayName = "Lyft",
                     Seats = 4,
                     ImageUrl = "",
                     PriceDetails = new PricingDetails
                     {
                            BaseCharge = 2,
                            CancelPenaltyAmount = 5,
                            CostMinimum = 2,
                            CostPerMile = 1,
                            CostPerMinute = 1,
                            Currency = "USD",
                            TrustAndServices = 1
                     },
                     ScheduledPricingDetails= new PricingDetails
                     {
                            BaseCharge = 2,
                            CancelPenaltyAmount = 5,
                            CostMinimum = 2,
                            CostPerMile = 1,
                            CostPerMinute = 1,
                            Currency = "USD",
                            TrustAndServices = 1
                     },
                },
                new RideType
                {
                     Ride_Type = RideType.RideTypes.LyftLine,
                     DisplayName = "Lyft",
                     Seats = 4,
                     ImageUrl = "",
                     PriceDetails = new PricingDetails
                     {
                            BaseCharge = 2,
                            CancelPenaltyAmount = 5,
                            CostMinimum = 2,
                            CostPerMile = 1,
                            CostPerMinute = 1,
                            Currency = "USD",
                            TrustAndServices = 1
                     },
                     ScheduledPricingDetails= new PricingDetails
                     {
                            BaseCharge = 2,
                            CancelPenaltyAmount = 5,
                            CostMinimum = 2,
                            CostPerMile = 1,
                            CostPerMinute = 1,
                            Currency = "USD",
                            TrustAndServices = 1
                     },
                },
                new RideType
                {
                     Ride_Type = RideType.RideTypes.LyftPlus,
                     DisplayName = "Lyft",
                     Seats = 4,
                     ImageUrl = "",
                     PriceDetails = new PricingDetails
                     {
                            BaseCharge = 2,
                            CancelPenaltyAmount = 5,
                            CostMinimum = 2,
                            CostPerMile = 1,
                            CostPerMinute = 1,
                            Currency = "USD",
                            TrustAndServices = 1
                     },
                     ScheduledPricingDetails= new PricingDetails
                     {
                            BaseCharge = 2,
                            CancelPenaltyAmount = 5,
                            CostMinimum = 2,
                            CostPerMile = 1,
                            CostPerMinute = 1,
                            Currency = "USD",
                            TrustAndServices = 1
                     },
                },
                new RideType
                {
                     Ride_Type = RideType.RideTypes.LyftSuv,
                     DisplayName = "Lyft",
                     Seats = 4,
                     ImageUrl = "",
                     PriceDetails = new PricingDetails
                     {
                            BaseCharge = 2,
                            CancelPenaltyAmount = 5,
                            CostMinimum = 2,
                            CostPerMile = 1,
                            CostPerMinute = 1,
                            Currency = "USD",
                            TrustAndServices = 1
                     },
                     ScheduledPricingDetails= new PricingDetails
                     {
                            BaseCharge = 2,
                            CancelPenaltyAmount = 5,
                            CostMinimum = 2,
                            CostPerMile = 1,
                            CostPerMinute = 1,
                            Currency = "USD",
                            TrustAndServices = 1
                     },
                }
            };

            return rideTypes;
        }
    }
}
