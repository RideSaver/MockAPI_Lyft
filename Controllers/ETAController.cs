using LyftAPI.Interface;
using LyftAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LyftAPI.Controllers
{
    [ApiController]
    public class EtaController
    {
        private readonly IEstimateRepository _estimateRepository;

        public EtaController(IEstimateRepository estimateRepository)
        {
            _estimateRepository = estimateRepository;
        }

        [HttpGet]
        [Route("/eta")]
        [Produces("application/json")]
        public async Task<IActionResult> GetETA([FromQuery]Location startLocation,[FromQuery]Location endLocation,[FromQuery] string rideType)
        {
            var rideEstimates = _estimateRepository.GetEstimates();

            await Task.Delay(100);

            return new OkObjectResult(rideEstimates);
        }
    }
}
