using Microsoft.AspNetCore.Mvc;

namespace LyftAPI.Controllers
{
    [ApiController]
    public class DriverController
    {
        [HttpGet]
        [Route("/drivers")]
        [Produces("application/json")]
        public Task<IActionResult> GetDrivers([FromQuery] double latitude, [FromQuery] double longitude)
        {
            throw new NotImplementedException();
        }

    }
}
