using BicingGPApplication.Entities.CityBik;
using BicingGPApplication.MediatR.CityBik.Station.Paris;
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
    public class CityBikParisController : ControllerBaseGeneric<ProviderCityBikParisGenerico, ProviderCityBikParis, StationOutDTOParis>
    {
        public CityBikParisController(IMediator mediator, ProvidersSettings bikingProviderSettings)
        {
            _mediator = mediator;
            _providerGeneric = bikingProviderSettings.ProviderCityBikParisGenerico;
            _provider = bikingProviderSettings.ProviderCityBikParis;
        }

        /// <summary>
        /// Get Status information of all stations
        /// </summary>
        [HttpGet("Status")]
        public async Task<ActionResult<List<StationInputDTOParis>>> GetStatus()
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
        public async Task<ActionResult<List<StationOutDTOParis>>> GetStation()
        {
            try
            {
                var response = await _mediator.Send(new StationInputDTOParis(_providerGeneric));
                var stationResult = new Result<List<StationOutDTOParis>>(response);
                return Ok(stationResult.ResultData);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error getting status {ex.Message}");
            }
        }
    }
}