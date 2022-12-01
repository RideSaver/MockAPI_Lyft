using Microsoft.AspNetCore.Mvc;

namespace LyftAPI.Controllers
{
    public class ETAController
    {
        public Task<IActionResult> GetETA([FromQuery] double lat, [FromQuery] double lng, [FromQuery] double destination_lat, [FromQuery] double destination_lng, [FromQuery] string ride_id)
        {
            {
                throw new NotImplementedException();
            }
        }
    }
}
