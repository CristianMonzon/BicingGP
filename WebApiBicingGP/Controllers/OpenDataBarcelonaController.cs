using BicingGP.Application.Providers.OpenData;
using BicingGP.Application.MediatR.OpenData.Station;
using BicingGP.Application.MediatR.OpenData.Status;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApiBicingGP.Domain;
using WebApiBicingGP.Manager;

namespace WebApiBicingGP.Controllers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class OpenDataBarcelonaController : ControllerBase
    {
        private readonly new ProviderOpenData _provider;

        /// <summary>
        /// Bicing Controller
        /// </summary>
        /// <param name="mediator"></param>
        /// <param name="appSettings"></param>
        public OpenDataBarcelonaController(IMediator mediator, DataProvidersSettings providerSettings)
        {
            _mediator = mediator;
            _provider = providerSettings.ProviderOpenDataBarcelona;
        }

        /// <summary>
        /// Get Status information of all stations
        /// </summary>
        [HttpGet("Status")]
        public async Task<ActionResult<List<OpenDataStatusOutDto>>> GetStatus()
        {
            try
            {
                var response = await _mediator.Send(new OpenDataStatusInputDto(_provider));
                var statusResult = new Result<IEnumerable<OpenDataStatusOutDto>>(response);
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
        public async Task<ActionResult<IEnumerable<OpenDataStationOutDto>>> GetStation()
        {
            try
            {
                var response = await _mediator.Send(new OpenDataStationInputDto(_provider));                
                var stationResult = new Result<IEnumerable<OpenDataStationOutDto>>(response);
                return Ok(stationResult.ResultData);                
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error getting status {ex.Message}");
            }
        }
    }
}