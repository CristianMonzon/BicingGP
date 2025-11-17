using BicingGPApplication.Entities.OpenData;
using BicingGPApplication.MediatR.OpenData.Station;
using BicingGPApplication.MediatR.OpenData.Status;
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
        public OpenDataBarcelonaController(IMediator mediator, ProvidersSettings bikingProviderSettings)
        {
            _mediator = mediator;
            _provider = bikingProviderSettings.ProviderFactoryOpenDataBarcelona;
        }

        /// <summary>
        /// Get Status information of all stations
        /// </summary>
        [HttpGet("Status")]
        public async Task<ActionResult<List<OpenDataStatusOutDTO>>> GetStatus()
        {
            try
            {
                var response = await _mediator.Send(new OpenDataStatusInputDTO(_provider));
                var statusResult = new Result<List<OpenDataStatusOutDTO>>(response);
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
        public async Task<ActionResult<List<OpenDataStationOutDTO>>> GetStation()
        {
            try
            {                
                var response = await _mediator.Send(new OpenDataStationInputDTO(_provider));                
                var stationResult = new Result<List<OpenDataStationOutDTO>>(response);
                return Ok(stationResult.ResultData);                
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error getting status {ex.Message}");
            }
        }
    }
}