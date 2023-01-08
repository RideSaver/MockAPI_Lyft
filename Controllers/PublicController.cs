using LyftAPI.Interface;
using LyftAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PublicController : ControllerBase
    {
        private readonly IPublicRepository _publicRepository;
        private readonly ILogger<PublicController> _logger;
        public PublicController(IPublicRepository publicRepository, ILogger<PublicController> logger)
        {
            _publicRepository = publicRepository;
            _logger = logger;
        }

        [HttpGet]
        [Route("/cost")]
        [Produces("application/json")]
        public async Task<ActionResult<CostEstimateResponse>> GetCostEstimates([FromQuery][Required()] double? start_lat, [FromQuery][Required()] double? start_lng, [FromQuery] string ride_type, [FromQuery] double? end_lat, [FromQuery] double? end_lng)
        {
            _logger.LogInformation("[LyftAPI:PublicController:GetCostEstimates] Controller endpoint invoked..");

            var startLocation = new LatLng() {  Lat = start_lat, Lng = start_lng };
            var endLocation  = new LatLng() { Lat = end_lat, Lng = end_lng };

            var estimate = await _publicRepository.GetCostEstimates(startLocation, endLocation, ride_type);

            return Content(estimate.ToJson(), "application/json");
        }

        [HttpGet]
        [Route("/eta")]
        [Produces("application/json")]
        public async Task<ActionResult<EtaEstimateResponse>> GetRideEstimate([FromQuery][Required()] double? lat, [FromQuery][Required()] double? lng, [FromQuery] string rideType)
        {
            _logger.LogInformation("[LyftAPI:PublicController:GetRideEstimate] Controller endpoint invoked..");

            var location = new LatLng() { Lat = lat, Lng = lng };

            var estimate = await _publicRepository.GetRideEstimates(location, rideType);

            return Content(estimate.ToJson(), "application/json");
        }

        [HttpGet]
        [Route("/ridetypes")]
        [Produces("application/json")]
        public async Task<ActionResult<RideTypesResponse>> GetRideTypes([FromQuery][Required()] double? lat, [FromQuery][Required()] double? lng, [FromQuery] string rideType)
        {
            _logger.LogInformation("[LyftAPI:PublicController:GetRideTypes] Controller endpoint invoked..");

            var location = new LatLng() { Lat = lat, Lng = lng };

            var ride = await _publicRepository.GetRideTypes(location, rideType);

            return Content(ride.ToJson(), "application/json");
        }
    }
}
