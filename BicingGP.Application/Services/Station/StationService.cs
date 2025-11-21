using BicingGP.DataProvider.Providers;
using System.Net.Http.Headers;

namespace BicingGP.Application.Services.Station
{
    public class StationService<TStationOutPut, TStatusOutPut>
    {
        private IHttpClientFactory _httpClientFactory;
        private IProviderGeneric<TStationOutPut, TStatusOutPut> _provider;

        public StationService(IHttpClientFactory httpClientFactory, IProviderGeneric<TStationOutPut,TStatusOutPut> provider)
        {
            _httpClientFactory = httpClientFactory;
            _provider = provider;
        }

        public virtual async Task<IEnumerable<TStationOutPut>> Get()
        {
            var httpcient = _httpClientFactory.CreateClient();
            if (_provider.HasToken) httpcient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_provider.Token);

            var response = await httpcient.GetStringAsync(_provider.UrlGetStation);
            var result = _provider.ConvertToStationOutDtos(response);
            
            return result;

        }
    }
}