using BicingGP.DataProvider.Providers;
using System.Net.Http.Headers;

namespace BicingGP.Application.Services.Status
{

    public class StatusService<TStationOutPut, TStatusOutPut>
    {
        protected IHttpClientFactory _httpClientFactory;
        protected IProviderGeneric<TStationOutPut, TStatusOutPut> _providerGeneric;

        public StatusService(IHttpClientFactory httpClientFactory, IProviderGeneric<TStationOutPut, TStatusOutPut> providerGeneric)
        {
            _httpClientFactory = httpClientFactory;
            _providerGeneric = providerGeneric;
        }

        public async Task<IEnumerable<TStatusOutPut>> Get()
        {
            var httpcient = _httpClientFactory.CreateClient();
            if (_providerGeneric.HasToken) httpcient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_providerGeneric.Token);

            var response = await httpcient.GetStringAsync(_providerGeneric.UrlGetStatus);
            return _providerGeneric.ConvertToStatusOutDtos(response);
        }
    }
}