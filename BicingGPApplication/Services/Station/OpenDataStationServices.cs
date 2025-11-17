using BicingGPApplication.Entities.OpenData;
using BicingGPApplication.MediatR.OpenData.Station;
using System.Net.Http.Headers;

namespace BicingGPApplication.Services.Station
{

    public class OpenDataStationServices 
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ProviderOpenData _providerOpenData;
        
        public OpenDataStationServices(IHttpClientFactory httpClientFactory, ProviderOpenData provider)
        {
            _httpClientFactory = httpClientFactory;
            _providerOpenData = provider;
        }

        public async Task<List<OpenDataStationOutDTO>> GetStations()
        {
            var httpcient = _httpClientFactory.CreateClient();
            httpcient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_providerOpenData.Token);

            var response = await httpcient.GetStringAsync(_providerOpenData.UrlGetStation);
            var result = _providerOpenData.ConvertToStationOutDTO(response);
            return result;
        }
    }
}