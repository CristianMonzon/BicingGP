using BicingGP.Application.Providers.CityBik;
using BicingGP.Application.MediatR.CityBik.Station.Paris;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApiBicingGP.Domain;
using WebApiBicingGP.Manager;
using BicingGP.Application.MediatR.CityBik.Status.Paris;

namespace WebApiBicingGP.Controllers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class CityBikParisController : ControllerBaseGeneric<StationOutDtoParis, StatusOutputDtoParis>
    {
        public CityBikParisController(IMediator mediator, DataProvidersSettings providerSettings)
        {
            _mediator = mediator;
            _providerGeneric = providerSettings.ProviderCityBikParis;            
        }

        /// <summary>
        /// Get Status information of all stations
        /// </summary>
        [HttpGet("Status")]
        public async Task<ActionResult<IEnumerable<StatusOutputDtoParis>>> GetStatus()
        {
            try
            {
                var response = await _mediator.Send(new StatusInputDtoParis(_providerGeneric));
                var statusResult = new Result<IEnumerable<StatusOutputDtoParis>>(response);
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
        public async Task<ActionResult<IEnumerable<StationOutDtoParis>>> GetStation()
        {
            try
            {
                var response = await _mediator.Send(new StationInputDtoParis(_providerGeneric));
                var stationResult = new Result<IEnumerable<StationOutDtoParis>>(response);
                return Ok(stationResult.ResultData);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error getting status {ex.Message}");
            }
        }
    }
}