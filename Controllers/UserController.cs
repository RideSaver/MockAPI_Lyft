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
        public Task<IActionResult> GetUser([FromQuery] string profile)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/lyft/api/user/rides")]
        public Task<IActionResult>
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("/lyft/api/user/rides")]
        public Task<IActionResult> Get
        {
        throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/lyft/api/user/rides/{id}")]
        public Task<IActionResult> 
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        [Route("/lyft/api/user/rides/{id}/cancel")]
        public Task<IActionResult> 
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        [Route("/lyft/api/user/rides/{id}/receipt")]
        public Task<IActionResult> 
        {
            throw new NotImplementedException();
        }
        [HttpPut]
        [Route("/lyft/api/user/rides/{id}/rating")]
        public Task<IActionResult> 
        {
            throw new NotImplementedException();
        }
        [HttpPut]
        [Route("/lyft/api/user/rides/{id}/destination")]
        public Task<IActionResult> 
        {
            throw new NotImplementedException();
        }
    }
}
