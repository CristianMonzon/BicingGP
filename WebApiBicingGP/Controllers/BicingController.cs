using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApiBicingGP.Domain;

namespace WebApiBicingGP.Controllers
{
    [ApiController]
    [Route("api/v2/[controller]")]
    public class BicingController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private const string APIURL = "http://api.citybik.es/v2/networks/bicing";

        public BicingController(IHttpClientFactory httpClientFactory, ILogger<BicingController> logger)
        {
            _httpClientFactory = httpClientFactory;
        }

        /// <summary>
        /// Get status
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetStatus()
        {
            try
            {
                var httpcient = _httpClientFactory.CreateClient();
                var response = await httpcient.GetStringAsync(APIURL);

                var myDeserializedClass = JsonConvert.DeserializeObject<Root>(response);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error getting status {ex.Message}");
            }

        }
    }
}