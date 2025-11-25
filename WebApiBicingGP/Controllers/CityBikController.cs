using BicingGP.Application.MediatR.CityBik.Station.Barcelona;
using BicingGP.Application.MediatR.CityBik.Station.Paris;
using BicingGP.Application.MediatR.CityBik.Status.Barcelona;
using BicingGP.Application.MediatR.CityBik.Status.Paris;
using BicingGP.Application.MediatR.CityBik.Status.Rosario;
using BicingGP.Application.MediatR.CityBik.Station.Rosario;

using BicingGP.DataProvider.Providers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApiBicingGP.Domain;
using WebApiBicingGP.Manager;

namespace WebApiBicingGP.Controllers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class CityBikController : ControllerBase
    {
        IProviderGeneric<StationOutputDtoBarcelona, StatusOutputDtoBarcelona> _providerBarcelona;
        IProviderGeneric<StationOutputDtoParis, StatusOutputDtoParis> _providerParis;
        IProviderGeneric<StationOutputDtoRosario, StatusOutputDtoRosario> _providerRosario;
        
        public CityBikController(IMediator mediator, DataProvidersSettings providerSettings)
        {
            _providerBarcelona = providerSettings.ProviderCityBikBarcelona;
            _providerParis = providerSettings.ProviderCityBikParis;
            _providerRosario= providerSettings.ProviderCityBikRosario;
            _mediator = mediator;        
        }

        /// <summary>
        /// Get Status information of all stations in Barcelona CityBik
        /// </summary>
        [HttpGet("Barcelona/Status")]
        public async Task<ActionResult<IEnumerable<StatusOutputDtoBarcelona>>> GetStatusBarcelona()
        {
            try
            {
                var response = await _mediator.Send(new StatusInputDtoBarcelona(_providerBarcelona));
                var statusResult = new Result<IEnumerable<StatusOutputDtoBarcelona>>(response);
                return Ok(statusResult.ResultData);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error getting status {ex.Message}");
            }
        }


        /// <summary>
        /// Get Status information of all stations in Paris CityBik
        /// </summary>
        [HttpGet("Paris/Status")]
        public async Task<ActionResult<IEnumerable<StatusOutputDtoParis>>> GetStatusParis()
        {
            try
            {
                var response = await _mediator.Send(new StatusInputDtoParis(_providerParis));
                var statusResult = new Result<IEnumerable<StatusOutputDtoParis>>(response);
                return Ok(statusResult.ResultData);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error getting status {ex.Message}");
            }
        }

        /// <summary>
        /// Get Status information of all stations in Rosario CityBik
        /// </summary>
        [HttpGet("Rosario/Status")]
        public async Task<ActionResult<IEnumerable<StatusOutputDtoRosario>>> GetStatusRosario()
        {
            try
            {
                var response = await _mediator.Send(new StatusInputDtoRosario(_providerRosario));
                var statusResult = new Result<IEnumerable<StatusOutputDtoRosario>>(response);
                return Ok(statusResult.ResultData);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error getting status {ex.Message}");
            }
        }


        /// <summary>
        /// Get stations information of all stations in Barcelona
        /// </summary>
        /// <returns></returns>
        /// </summary>
        [HttpGet("Barcelona/Station")]
        public async Task<ActionResult<IEnumerable<StationOutputDtoBarcelona>>> GetStationBarcelona()
        {
            try
            {
                var response = await _mediator.Send(new StationInputDtoBarcelona(_providerBarcelona));
                var stationResult = new Result<IEnumerable<StationOutputDtoBarcelona>>(response);
                return Ok(stationResult.ResultData);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error getting status {ex.Message}");
            }
        }

        /// <summary>
        /// Get stations information of all stations in Paris
        /// </summary>
        /// <returns></returns>
        /// </summary>
        [HttpGet("Paris/Station")]
        public async Task<ActionResult<IEnumerable<StationOutputDtoParis>>> GetStationParis()
        {
            try
            {
                var response = await _mediator.Send(new StationInputDtoParis(_providerParis));
                var stationResult = new Result<IEnumerable<StationOutputDtoParis>>(response);
                return Ok(stationResult.ResultData);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error getting status {ex.Message}");
            }
        }

        /// <summary>
        /// Get stations information of all stations in Rosario
        /// </summary>
        /// <returns></returns>
        /// </summary>
        [HttpGet("Rosario/Station")]
        public async Task<ActionResult<IEnumerable<StationOutputDtoRosario>>> GetStationRosario()
        {
            try
            {
                var response = await _mediator.Send(new StationInputDtoRosario(_providerRosario));
                var stationResult = new Result<IEnumerable<StationOutputDtoRosario>>(response);
                return Ok(stationResult.ResultData);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error getting status {ex.Message}");
            }
        }

    }
}
