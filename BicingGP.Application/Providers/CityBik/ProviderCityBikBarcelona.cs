using BicingGP.Application.Domain.CityBk.Barcelona;
using BicingGP.Application.MediatR.CityBik.Station.Barcelona;
using BicingGP.Application.MediatR.CityBik.Status.Barcelona;
using BicingGP.DataDomain.CityBik.Barcelona;

namespace BicingGP.Application.Providers.CityBik
{
    public class ProviderCityBikBarcelona : Provider, IProviderGeneric<StationOutDtoBarcelona, StatusOutputDtoBarcelona>
    {
        public IEnumerable<StationOutDtoBarcelona> ConvertToStationOutDtos(string response)
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
