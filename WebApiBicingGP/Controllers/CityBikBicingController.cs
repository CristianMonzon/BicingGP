using BicingGPApplication.Providers.CityBik;
using BicingGPApplication.MediatR.CityBik.Station.Barcelona;
using BicingGPApplication.MediatR.CityBik.Status;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApiBicingGP.Domain;
using WebApiBicingGP.Manager;

namespace WebApiBicingGP.Controllers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class CityBikBicingController : ControllerBaseGeneric<ProviderCityBikBarcelona, StationOutDTOBarcelona>
    {
        public CityBikBicingController(IMediator mediator, DataProvidersSettings providerSettings)
        {
            _mediator = mediator;
            _providerGeneric = providerSettings.ProviderCityBikBarcelonaGenerico;
            _provider = providerSettings.ProviderCityBikBarcelona;
        }

        /// <summary>
        /// Get Status information of all stations
        /// </summary>
        [HttpGet("Status")]
        public async Task<ActionResult<List<StatusOutDTO>>> GetStatus()
        {
            try
            {
                var response = await _mediator.Send(new StatusInputDTO(_provider));
                var statusResult = new Result<List<StatusOutDTO>>(response);
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
        public async Task<ActionResult<List<StationOutDTOBarcelona>>> GetStation()
        {
            try
            {            
                var response = await _mediator.Send(new StationInputDTOBarcelona(_providerGeneric));                
                var stationResult = new Result<List<StationOutDTOBarcelona>>(response);
                return Ok(stationResult.ResultData);                
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error getting status {ex.Message}");
            }
        }
    }
}
