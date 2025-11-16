using BicingGPApplication.Entities;
using System.Net.Http.Headers;

namespace BicingGPApplication.Services.Station
{
    internal class StationServices<T>
    {
        private IHttpClientFactory _httpClientFactory;
        private IProviderGeneric<T> _provider;

        public StationServices(IHttpClientFactory httpClientFactory, IProviderGeneric<T> provider)
        {
            _httpClientFactory = httpClientFactory;
            _provider = provider;
        }

        public virtual async Task<List<T>> GetStations()
        {
            var httpcient = _httpClientFactory.CreateClient();
            if (_provider.HasToken) httpcient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_provider.Token);

            var response = await httpcient.GetStringAsync(_provider.UrlGetStation);
            var result = _provider.ConvertToStationOutDTOGeneric(response);
            
            return result;

        }
    }
}