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
        public UserController(IUserRepository userRepository) => _userRepository = userRepository;

        [HttpPost]
        [Route("/rides/{id}/cancel")]
        public IActionResult CancelUserRide([FromRoute][Required] string id, [FromBody] CancellationRequest body)
        {
            return new NoContentResult(); // Validation
        }

        [HttpGet]
        [Route("/rides/{id}")]
        public IActionResult GetUserRide([FromRoute] string id)
        {
            return new OkObjectResult(_userRepository.GetUserRide(id));
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
