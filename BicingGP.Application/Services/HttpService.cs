using System.Net.Http.Headers;

namespace BicingGP.Application.Services
{
    public class HttpService : IHttpService
    {
        private readonly IHttpClientFactory _httpService;

        public HttpService(IHttpClientFactory httpClientFactory)
        {
            _httpService = httpClientFactory;
        }

        public async Task<string> GetStringAsync(string url, string? token = null)
        {
            var client = _httpService.CreateClient();

            if (!string.IsNullOrEmpty(token)) client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);

            return await client.GetStringAsync(url);
        }
    }
}