using BicingGPApplication.Domain.StationJson;
using BicingGPApplication.Domain.StatusJson;
using BicingGPApplication.MediatR;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApiBicingGP.Domain;
using WebApiBicingGP.Manager;

namespace WebApiBicingGP.Controllers
{
    [ApiController]
    [Route("api/v1/")]
    public class BicingController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IMediator _mediator;
        private readonly AppSettings _appSettings;

        private string? ApiUrlStatus
        {
            get
            {
                return _appSettings?.StatusInformation;
            }
        }
        private string? ApiUrlStation
        {
            get
            {
                return _appSettings?.StationInformation;
            }
        }

        /// <summary>
        /// Bicing Controller
        /// </summary>
        /// <param name="mediator"></param>
        /// <param name="appSettings"></param>
        public BicingController(IMediator mediator, AppSettings appSettings)
        {
            _mediator = mediator;
            _appSettings = appSettings;
        }

        /// <summary>
        /// Get Status information of all stations
        /// </summary>
        [HttpGet("Status")]
        public async Task<ActionResult<StatusRoot>> GetStatus()
        {
            try
            {
                var response = _mediator.Send(new StatusMessage(ApiUrlStatus));
                var statusResult = new Result<StatusRoot>(response.Result);
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
        public async Task<ActionResult<StationRoot>> GetStation()
        {
            try
            {
                var response = _mediator.Send(new StationMessage(ApiUrlStation));
                var statusResult = new Result<StationRoot>(response.Result);
                return Ok(statusResult.ResultData);                
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error getting status {ex.Message}");
            }
        }
    }
}