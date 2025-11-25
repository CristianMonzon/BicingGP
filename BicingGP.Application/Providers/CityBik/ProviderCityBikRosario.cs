using BicingGP.Application.Domain.CityBik.Rosario;
using BicingGP.Application.MediatR.CityBik.Station.Rosario;
using BicingGP.Application.MediatR.CityBik.Status.Rosario;

namespace BicingGP.DataProvider.Providers.CityBik
{
    public class ProviderCityBikRosario : Provider, IProviderGeneric<StationOutputDtoRosario, StatusOutputDtoRosario>
    {
        public IEnumerable<StationOutputDtoRosario> ConvertToStationOutDtos(string response)
        {
            var root = GenericConvert<CityBikRootGeneric>(response);
            return root!.network!.stations!.Select(c => c.ToStationOutDto()).ToList();
        }

        public IEnumerable<StatusOutputDtoRosario> ConvertToStatusOutDtos(string response)
        {
            var root = GenericConvert<CityBikRootGeneric>(response);
            return root!.network!.stations!.Select(c => c.ToStatusOutDto()).ToList();            
        }
    }
}