using BicingGP.Application.MediatR.CityBik.Station.Rosario;
using BicingGP.Application.MediatR.CityBik.Status.Rosario;
using BicingGP.Application.Providers.CityBik;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApiBicingGP.Domain;
using WebApiBicingGP.Manager;

namespace WebApiBicingGP.Controllers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class CityBikRosarioController : ControllerBaseGeneric<StationOutDtoRosario, StatusOutputDtoRosario>
    {
        public CityBikRosarioController(IMediator mediator, DataProvidersSettings providerSettings)
        {
            _mediator = mediator;
            _providerGeneric = providerSettings.ProviderCityBikRosarioGenerico;            
        }

        /// <summary>
        /// Get Status information of all stations
        /// </summary>
        [HttpGet("Status")]
        public async Task<ActionResult<IEnumerable<StatusOutputDtoRosario>>> GetStatus()
        {
            try
            {
                var response = await _mediator.Send(new StatusInputDtoRosario(_providerGeneric));
                var statusResult = new Result<IEnumerable<StatusOutputDtoRosario>>(response);
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
        public async Task<ActionResult<IEnumerable<StationOutDtoRosario>>> GetStation()
        {
            try
            {
                var response = await _mediator.Send(new StationInputDtoRosario(_providerGeneric));
                var stationResult = new Result<IEnumerable<StationOutDtoRosario>>(response);
                return Ok(stationResult.ResultData);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error getting status {ex.Message}");
            }
        }
    }
}