using LyftAPI.Interface;
using LyftAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
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
        [Produces("application/json")]
        public async Task<ActionResult<RideDetail>> GetUserRide([FromRoute] string id)
        {
            _logger.LogInformation($"[LyftAPI::UserController::GetUserRide] Method invoked with RideID: {id}");

            var rideId = id.ToString();
            if(rideId is null) { return BadRequest("Invalid Ride ID"); }

            var rideDetail = await _userRepository.GetUserRide(rideId);

            _logger.LogInformation($"[LyftAPI::UserController::GetUserRide] Returnnig (RideDetail) to the caller... \n{rideDetail}");

            return Content(rideDetail.ToJson(), "application/json");
        }

        [HttpPost]
        [Route("/rides/{id}/cancel")]
        public IActionResult CancelUserRide([FromRoute][Required] string id, [FromBody] CancellationRequest body)
        {
            return new NoContentResult(); // Validation
        }

        [HttpGet]
        [Route("/rides")]
        public IActionResult GetUserRides([FromQuery][Required()] DateTime? startTime, [FromQuery] DateTime? endTime, [FromQuery][Range(0, 50)] int? limit)
        {
            return new OkObjectResult(_userRepository.GetUserRides());
        }

        [HttpPost]
        [Route("/rides")]
        public IActionResult PostUserRides([FromBody] CreateRideRequest body)
        {
            return new OkObjectResult(_userRepository.PostUserRide(body));
        }
    }
}
