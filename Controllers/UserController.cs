using LyftAPI.Interface;
using LyftAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger<UserController> _logger;
        public UserController(IUserRepository userRepository, ILogger<UserController> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        [HttpGet]
        [Route("/rides/{id}")]
        public async Task<ActionResult<RideDetail>> GetUserRide([FromRoute] string id)
        {
            _logger.LogInformation($"[LyftAPI::UserController::GetUserRide] Method invoked with RideID: {id}");

            var rideId = id.ToString();
            if(rideId is null) { return BadRequest("Invalid Ride ID"); }

            var rideDetail = await _userRepository.GetUserRide(rideId);
            rideDetail.RideId = id;

            _logger.LogInformation($"[LyftAPI::UserController::GetUserRide] Returning (RideDetail) to the caller... \n{rideDetail}");

            return Content(rideDetail.ToJson(), "application/json");
        }

        [HttpPost]
        [Route("/rides")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public async Task<ActionResult<Ride>> PostUserRides([FromBody] CreateRideRequest body)
        {
            _logger.LogInformation($"[LyftAPI::UserController::PostUserRides] Method invoked with request body: \n{body}");

            var RideRequest = new CreateRideRequest
            {
                RideType = body.RideType,
                Origin = body.Origin,
                Destination = body.Destination,
                Passenger= body.Passenger,
            };

            if(body is null) { return BadRequest("Invalid data receieved!"); }

            var ride = await _userRepository.PostUserRide(RideRequest);
            ride.RideId = Guid.NewGuid().ToString();

            _logger.LogInformation($"[LyftAPI::UserController::PostUserRides] Returning (Ride) to the caller... \n{ride}");

            return Content(ride.ToJson(), "application/json");
        }

        [HttpGet]
        [Route("/rides")]
        public async Task<ActionResult<InlineResponse200>> GetUserRides([FromQuery][Required()] DateTime? startTime, [FromQuery] DateTime? endTime, [FromQuery][Range(0, 50)] int? limit)
        {
            _logger.LogInformation($"[LyftAPI::UserController::GetUserRides] Method invoked with query data: \n{startTime}, {endTime}, {limit}");

            var userRides = await _userRepository.GetUserRides();

            _logger.LogInformation($"[LyftAPI::UserController::PostUserRides] Returning (InlineResponse200) to the caller... \n{userRides.RideHistory}");

            return Content(userRides.ToJson(), "application/json");
        }

        [HttpPost]
        [Route("/rides/{id}/cancel")]
        public IActionResult CancelUserRide([FromRoute][Required] string id, [FromBody] CancellationRequest body)
        {
            return new NoContentResult(); // Validation
        }

    }
}
