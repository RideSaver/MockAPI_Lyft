using Microsoft.AspNetCore.Mvc;
using LyftAPI.Interface;


namespace LyftAPI.Controllers
{
    [ApiController]
    public class UserController
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository) => _userRepository = userRepository;

        [HttpGet]
        [Route("/lyft/api/user/profile")]
        public Task<IActionResult> GetProfile([FromQuery] string profile)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/lyft/api/user/rides")]
        public Task<IActionResult> GetRides([FromQuery] int limit)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("/lyft/api/user/rides")]
        public Task<IActionResult> NewRide([FromQuery] string? ride_info)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/lyft/api/user/rides/{id}")]
        public Task<IActionResult> GetRide([FromQuery] string ride_id)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        [Route("/lyft/api/user/rides/{id}/cancel")]
        public Task<IActionResult> CancelRide([FromQuery] string? cancel_ride)
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        [Route("/lyft/api/user/rides/{id}/receipt")]
        public Task<IActionResult> SetRideDestination([FromQuery] string coordinates, [FromQuery] string optional_address])
        {
            throw new NotImplementedException();

        [HttpPut]
        [Route("/lyft/api/user/rides/{id}/rating")]
        public Task<IActionResult> SetRideRating([FromQuery] string feedback)

        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("/lyft/api/user/rides/{id}/destination")]
        public Task<IActionResult> GetRideReceipt([FromQuery] string id)
        {
            throw new NotImplementedException();
        }



    }
    
}


