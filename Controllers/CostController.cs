using Microsoft.AspNetCore.Mvc;

namespace LyftAPI.Controllers
{
    public class CostController
    {
        public Task<IActionResult> GetCost([FromQuery] string ride_id, [FromQuery] double start_lat, [FromQuery] double start_lng, [FromQuery] double end_lat, [FromQuery] double end_lng)
        {
            {
                throw new NotImplementedException();
            }
        }
    }
}
