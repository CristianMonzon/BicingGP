using BicingGP.Application.MediatR.CityBik.Station.Barcelona;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApiBicingGP.Domain;
using WebApiBicingGP.Manager;
using BicingGP.Application.MediatR.CityBik.Status.Barcelona;

namespace WebApiBicingGP.Controllers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class CityBikBicingController : ControllerBaseGeneric<StationOutputDtoBarcelona,StatusOutputDtoBarcelona>
    {
        public CityBikBicingController(IMediator mediator, DataProvidersSettings providerSettings)
        {
            _mediator = mediator;
            _providerGeneric = providerSettings.ProviderCityBikBarcelona;            
        }

        /// <summary>
        /// Get Status information of all stations
        /// </summary>
        [HttpGet("Status")]
        public async Task<ActionResult<IEnumerable<StatusOutputDtoBarcelona>>> GetStatus()
        {
            try
            {
                var response = await _mediator.Send(new StatusInputDtoBarcelona(_providerGeneric));
                var statusResult = new Result<IEnumerable<StatusOutputDtoBarcelona>>(response);
                return Ok(statusResult.ResultData);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error getting status {ex.Message}");
            }
        }

        /// <summary>
        /// Get stations information of all stations
        /// </summary>
        /// <returns></returns>
        /// </summary>
        [HttpGet("Station")]
        public async Task<ActionResult<IEnumerable<StationOutputDtoBarcelona>>> GetStation()
        {
            try
            {            
                var response = await _mediator.Send(new StationInputDtoBarcelona(_providerGeneric));                
                var stationResult = new Result<IEnumerable<StationOutputDtoBarcelona>>(response);
                return Ok(stationResult.ResultData);                
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error getting status {ex.Message}");
            }
        }
    }
}
