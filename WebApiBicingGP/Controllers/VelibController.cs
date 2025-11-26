using BicingGP.Application.MediatR.Velib.Station;
using BicingGP.Application.MediatR.Velib.Status;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApiBicingGP.Domain;
using WebApiBicingGP.Manager;

namespace WebApiBicingGP.Controllers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class VelibController : ControllerBaseGeneric<StationOutputDtoVelib, StatusOutputDtoVelib>
    {
        public VelibController(IMediator mediator, DataProvidersSettings providerSettings)
        {
            _mediator = mediator;
            _providerGeneric = providerSettings.ProviderVelib;
        }

        /// <summary>
        /// Get Status information of all stations
        /// </summary>
        [HttpGet("Status")]
        public async Task<ActionResult<IEnumerable<StatusOutputDtoVelib>>> GetStatus()
        {
            try
            {
                var response = await _mediator.Send(new StatusInputDtoVelib(_providerGeneric));
                var statusResult = new Result<IEnumerable<StatusOutputDtoVelib>>(response);
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
        public async Task<ActionResult<IEnumerable<StationOutputDtoVelib>>> GetStation()
        {
            try
            {
                var response = await _mediator.Send(new StationInputDtoVelib(_providerGeneric));
                var stationResult = new Result<IEnumerable<StationOutputDtoVelib>>(response);
                return Ok(stationResult.ResultData);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error getting status {ex.Message}");
            }
        }
    }
}