using Microsoft.AspNetCore.Mvc;

namespace LyftAPI.Controllers
{
    public class RidesController
    {
        public Task<IActionResult> GetRideID([FromQuery] double lat, [FromQuery] double lng, [FromQuery] string ride_id)
        {
            {
                throw new NotImplementedException();
            }
        }
    }
}
