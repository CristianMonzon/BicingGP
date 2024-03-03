using BicingGPApplication.Entities;
using BicingGPApplication.MediatR.CityBik.Station;
using BicingGPApplication.MediatR.OpenData.Station;
using System.Net.Http;
using System.Net.Http.Headers;

namespace BicingGPApplication.Services
{

    public class OpenDataStationServices : StationServices
    {
        public ProviderOpenData ProviderOpenData{ get; set; }
        public OpenDataStationServices(IHttpClientFactory httpClientFactory, ProviderOpenData provider)
        {
            base._httpClientFactory = httpClientFactory;
            ProviderOpenData = provider;
        }

        public new async Task<List<OpenDataStationOutDTO>> GetStations()
        {
            var httpcient = _httpClientFactory.CreateClient();
            httpcient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(ProviderOpenData.Token);

            var response = await httpcient.GetStringAsync(ProviderOpenData.UrlGetStation);
            var result = ProviderOpenData.ConvertToStationOutDTO(response);
            return result;
        }

    }

    public class StationServices 
    {
        protected IHttpClientFactory _httpClientFactory;

        protected IProvider _provider;

        public StationServices()
        {

        }

        public StationServices(IHttpClientFactory httpClientFactory, IProvider provider)
        {
            _httpClientFactory = httpClientFactory;
            _provider = provider;
        }

        public virtual async Task<List<StationOutDTO>> GetStations()
        {
            var httpcient = _httpClientFactory.CreateClient();
            if (_provider.HasToken) httpcient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_provider.Token);

            var response = await httpcient.GetStringAsync(_provider.UrlGetStation);
            var result = _provider.ConvertToStationOutDTO(response);
            return result;
        }
    }
}