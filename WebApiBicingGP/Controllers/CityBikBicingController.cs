using BicingGPApplication.Entities;
using BicingGPApplication.MediatR.CityBik.Station;
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

    public class CityBikBicingController : ControllerBase
    {                
        public CityBikBicingController(IMediator mediator, AppSettings appSettings)
        {
            _mediator = mediator;
            _provider = appSettings.ProviderCityBarcelona;
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
        public async Task<ActionResult<List<StationOutDTO>>> GetStation()
        {
            try
            {            
                var response = await _mediator.Send(new StationInputDTO(_provider));                
                var stationResult = new Result<List<StationOutDTO>>(response);
                return Ok(stationResult.ResultData);                
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error getting status {ex.Message}");
            }
        }
    }
}
