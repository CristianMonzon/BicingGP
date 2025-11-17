using BicingGPApplication.Providers;
using BicingGPApplication.MediatR.CityBik.Status;
using System.Net.Http.Headers;

namespace BicingGPApplication.Services.Status
{

    public class StatusServices
    {
        protected IHttpClientFactory _httpClientFactory;
        protected IProvider _provider;

        public StatusServices(IHttpClientFactory httpClientFactory, IProvider provider)
        {
            _httpClientFactory = httpClientFactory;
            _provider= provider;
        }

        public async Task<List<StatusOutDTO>> GetStatus()
        {
            var httpcient = _httpClientFactory.CreateClient();
            if (_provider.HasToken) httpcient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_provider.Token);

            var response = await httpcient.GetStringAsync(_provider.UrlGetStatus);

            return _provider.ConvertToStatusOutDTO(response);
        }
    }
}