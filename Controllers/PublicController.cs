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
    public class PublicController : ControllerBase
    {
        private readonly IPublicRepository _publicRepository;
        public PublicController(IPublicRepository publicRepository) => _publicRepository = publicRepository;

        [HttpGet]
        [Route("/cost")]
        public IActionResult GetCostEstimates([FromQuery][Required()] double? startLat, [FromQuery][Required()] double? startLng, [FromQuery] string rideType, [FromQuery] double? endLat, [FromQuery] double? endLng)
        {
            var startLocation = new LatLng() {  Lat = startLat, Lng = startLng };
            var endLocation  = new LatLng() { Lat = endLat, Lng = endLng };

            return new OkObjectResult(_publicRepository.GetCostEstimates(startLocation, endLocation, rideType));
        }

        [HttpGet]
        [Route("/eta")]
        public IActionResult GetRideEstimate([FromQuery][Required()] double? lat, [FromQuery][Required()] double? lng, [FromQuery] string rideType)
        {
            var location = new LatLng() { Lat = lat, Lng = lng };

            return new OkObjectResult(_publicRepository.GetRideEstimates(location, rideType));
        }

        [HttpGet]
        [Route("/ridetypes")]
        public IActionResult GetRideTypes([FromQuery][Required()] double? lat, [FromQuery][Required()] double? lng, [FromQuery] string rideType)
        {
            var location = new LatLng() { Lat = lat, Lng = lng };

            return new OkObjectResult(_publicRepository.GetRideTypes(location, rideType));
        }
    }
}
