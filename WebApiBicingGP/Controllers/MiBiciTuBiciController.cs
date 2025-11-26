using BicingGP.Application.MediatR.MiBiciTuBici.Station;
using BicingGP.Application.MediatR.MiBiciTuBici.Status;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApiBicingGP.Domain;
using WebApiBicingGP.Manager;

namespace WebApiBicingGP.Controllers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class MiBiciTuBiciController : ControllerBaseGeneric<StationOutputDtoMiBiciTuBici, StatusOutputDtoMiBiciTuBici>
    {
        public MiBiciTuBiciController(IMediator mediator, DataProvidersSettings providerSettings)
        {
            _mediator = mediator;
            _providerGeneric = providerSettings.ProviderMiBiciTuBici;
        }

        /// <summary>
        /// Get Status information of all stations
        /// </summary>
        [HttpGet("Status")]
        public async Task<ActionResult<IEnumerable<StatusOutputDtoMiBiciTuBici>>> GetStatus()
        {
            try
            {
                var response = await _mediator.Send(new StatusInputDtoMiBiciTuBici(_providerGeneric));
                var statusResult = new Result<IEnumerable<StatusOutputDtoMiBiciTuBici>>(response);
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
        public async Task<ActionResult<IEnumerable<StationOutputDtoMiBiciTuBici>>> GetStation()
        {
            try
            {
                var response = await _mediator.Send(new StationInputDtoMiBiciTuBici(_providerGeneric));
                var stationResult = new Result<IEnumerable<StationOutputDtoMiBiciTuBici>>(response);
                return Ok(stationResult.ResultData);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error getting status {ex.Message}");
            }
        }
    }
}