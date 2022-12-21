using LyftAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LyftAPI.Controllers
{
    [ApiController]
    public class CostController
    {
        [HttpGet]
        [Route("/cost")]
        [Produces("application/json")]
        public Task<IActionResult> GetCost([FromQuery] string rideId, [FromQuery] Location startLocation, [FromQuery] Location endLocation)
        {
            throw new NotImplementedException();
        }
    }
}
