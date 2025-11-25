using BicingGP.DataProvider.Providers;

namespace BicingGP.Application.Services.Status
{
    public class StatusService<TStationOutPut, TStatusOutPut>
    {		
		protected IHttpService _httpService;
        protected IProviderGeneric<TStationOutPut, TStatusOutPut> _providerGeneric;

        public StatusService(IHttpService httpService, IProviderGeneric<TStationOutPut, TStatusOutPut> providerGeneric)
        {
            _httpService = httpService;
            _providerGeneric = providerGeneric;
        }

        public async Task<IEnumerable<TStatusOutPut>> Get()
        {
			var response = await _httpService.GetStringAsync(_providerGeneric.UrlGetStatus, _providerGeneric.Token);
            return _providerGeneric.ConvertToStatusOutDtos(response);
        }
    }
}