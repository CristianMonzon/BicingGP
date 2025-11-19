using BicingGP.Application.Providers.OpenData;
using BicingGP.Application.MediatR.OpenData.Station;
using System.Net.Http.Headers;

namespace BicingGP.Application.Services.Station
{

    public class OpenDataStationService 
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ProviderOpenData _providerOpenData;
        
        public OpenDataStationService(IHttpClientFactory httpClientFactory, ProviderOpenData provider)
        {
            _httpClientFactory = httpClientFactory;
            _providerOpenData = provider;
        }

        public async Task<IEnumerable<OpenDataStationOutDto>> Get()
        {
            var httpcient = _httpClientFactory.CreateClient();
            if (_providerOpenData.Token != null) httpcient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_providerOpenData.Token);

            var response = await httpcient.GetStringAsync(_providerOpenData.UrlGetStation);
            var result = _providerOpenData.ConvertToStationOutDto(response);
            return result;
        }
    }
}