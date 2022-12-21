using LyftAPI.Interface;
using LyftAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LyftAPI.Controllers
{
    [ApiController]
    public class RidesController
    {
        private readonly IRideRepository _rideRepository;

        public RidesController(IRideRepository rideRepository)
        {
            _rideRepository = rideRepository;
        }

        [HttpGet]
        [Route("/ridetypes")]
        [Produces("application/json")]
        public async Task<IActionResult> GetRideType([FromQuery] Location startLocation, [FromQuery]Location endLocation, [FromQuery] string rideType)
        {
            var rideTypes = _rideRepository.GetRideTypes();
            await Task.Delay(1000);

            return new OkObjectResult(rideTypes);
        }

        [HttpGet]
        [Route("/rides")]
        [Produces("application/json")]
        public async Task<IActionResult> GetRide([FromQuery] string startTime, [FromQuery] string endTime)
        {
            var rides = new List<RideDetail>()
            {
                new RideDetail()
                {
                    RideId = 100,
                    Passenger = new PassengerDetail()
                    {
                        FirstName = "Elias",
                        ImageUrl = "",
                        Rating = "5.0"
                    },
                    Driver = new DriverDetail()
                    {
                        FirstName = "John",
                        PhoneNumber = "555-555-555",
                        Rating = "10.0",
                        ImageUrl = ""
                    },
                    Vehicle = new VehicleDetail()
                    {
                        Make = "Toyota",
                        Model = "Camry",
                        Year = 2019,
                        LicensePlate = "why god",
                        LicensePlateState = "misery",
                        Color = "black",
                        ImageUrl = "",
                    },
                    Origin = new RideLocation()
                    {
                        Lat = 50.0f,
                        Long = 25.0f,
                        Address = "Sadness Street",
                        EstimateSeconds = 100
                    },
                    Destination = new RideLocation()
                    {
                        Lat = 80.0f,
                        Long = 90.0f,
                        Address = "Sadness Street",
                        EstimateSeconds = 100
                    },
                    PickUp = new PickUpDropoffLocation()
                    {
                        Latitude = 50.0f,
                        Longitude = 25.0f,
                        Address = "This fucking sucks",
                        Time = "who knows"
                    },
                    DropOff = new PickUpDropoffLocation()
                    {
                        Latitude = 50.0f,
                        Longitude = 25.0f,
                        Address = "This fucking sucks",
                        Time = "who knows"
                    },
                    RideLocation = new RideLocation()
                    {
                        Lat = 80.0f,
                        Long = 90.0f,
                        Address = "Sadness Street",
                        EstimateSeconds = 100
                    },
                    PrimeTimePercentage = "1000x",
                    Price = new Cost()
                    {
                        Amount = 50,
                        Currency = "USD",
                        Description = "Very expensive"
                    },
                    LineItem= null,
                    CanCancel = null,
                    CanceledBy = "Life",
                    CancellationCost = null,
                    Rating = 5,
                    FeedBack = "Terrible",
                    RouteUrl = null,
                    RequestedAt= null,
                    RideType = RideDetail.RideTypes.Lyft,
                },
            };

            await Task.Delay(100);
            return new OkObjectResult(rides);
        }

        [HttpPost]
        [Route("/rides")]
        [Produces("application/json")]
        public async Task<IActionResult> PostRide([FromBody] CreateRideRequest rideRequest)
        {
            var ride = new Ride()
            {
                RideId = 500,
                Origin = new Location()
                {
                    Longitude = 25f,
                    Latitude = 30f
                },
                Destination = new Location()
                {
                    Longitude = 50f,
                    Latitude = 60f
                },
                PrimeTimeConfirmationToken = null,
                RideType = Ride.RideTypes.Lyft
            };

            await Task.Delay(100);
            return new OkObjectResult(ride);
        }

        [HttpPost]
        [Route("/rides/{id}/cancel")]
        [Produces("application/json")]
        public async Task<IActionResult> PostRideCancellation([FromQuery] string rideId, [FromBody] CancellationRequest cancellationRequest)
        {
            return new NoContentResult(); // 204 status code -> success
        }

    }
}
