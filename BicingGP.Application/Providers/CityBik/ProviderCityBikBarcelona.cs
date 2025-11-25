using BicingGP.Application.Domain.CityBik.Barcelona;
using BicingGP.Application.MediatR.CityBik.Station.Barcelona;
using BicingGP.Application.MediatR.CityBik.Status.Barcelona;
using BicingGP.DataProvider.CityBik.Barcelona;
using BicingGP.DataProvider.Providers;

namespace BicingGP.Application.Providers.CityBik
{
    public class ProviderCityBikBarcelona : Provider, IProviderGeneric<StationOutputDtoBarcelona, StatusOutputDtoBarcelona>
    {
        public IEnumerable<StationOutputDtoBarcelona> ConvertToStationOutDtos(string response)
        {
            var root = GenericConvert<CityBikRootGeneric>(response);
            return root!.network!.stations.Select(c => c.ToStationOutDto()).ToList();
        }

        public IEnumerable<StatusOutputDtoBarcelona> ConvertToStatusOutDtos(string response)
        {
            var root = GenericConvert<CityBikRootGeneric>(response);
            return root!.network!.stations!.Select(c => c.ToStatusOutDto()).ToList();            
        }
        
    }
}
