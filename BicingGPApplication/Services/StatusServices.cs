using BicingGPApplication.Entities;
using BicingGPApplication.MediatR.CityBik.Status;
using BicingGPApplication.MediatR.OpenData.Station;
using BicingGPApplication.MediatR.OpenData.Status;
using System.Net.Http.Headers;

namespace BicingGPApplication.Services
{

    public class OpenDataStatusServices : StatusServices
    {
        public ProviderOpenData ProviderOpenData { get; set; }

        public OpenDataStatusServices(IHttpClientFactory httpClientFactory, ProviderOpenData provider)
        {
            _httpClientFactory = httpClientFactory;
            ProviderOpenData = provider;
        }

        public async new Task<List<OpenDataStatusOutDTO>> GetStatus()
        {
            var httpcient = _httpClientFactory.CreateClient();
            httpcient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(ProviderOpenData.Token);

            var response = await httpcient.GetStringAsync(ProviderOpenData.UrlGetStatus);

            return ProviderOpenData.ConvertToStatusOutDTO(response);
        }

    }

    public class StatusServices
    {
        protected IHttpClientFactory _httpClientFactory;
        protected IProvider _provider;

        public StatusServices()
        {
            
        }
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