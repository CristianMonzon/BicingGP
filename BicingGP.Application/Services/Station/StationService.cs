using BicingGP.DataProvider.Providers;

namespace BicingGP.Application.Services.Station
{
    public class StationService<TStationOutPut, TStatusOutPut>
    {
        private readonly IHttpService _httpService;
        private readonly IProviderGeneric<TStationOutPut, TStatusOutPut> _providerGeneric;
        private readonly IStationConverter<TStationOutPut> _stationConvert;

        public StationService(IHttpService httpService, IProviderGeneric<TStationOutPut, TStatusOutPut> providerGeneric)
        {
            _httpService = httpService;
            _providerGeneric = providerGeneric;
        }

        public StationService(IHttpService httpService, IStationConverter<TStationOutPut> stationConvert)
        {
            _httpService = httpService;
            _stationConvert = stationConvert;
        }

        public virtual async Task<IEnumerable<TStationOutPut>> Get()
        {
            var response = await _httpService.GetStringAsync(_providerGeneric.UrlGetStation, _providerGeneric.Token);
            var result = _providerGeneric.ConvertToStationOutDtos(response);
            return result;

        }
    }
}