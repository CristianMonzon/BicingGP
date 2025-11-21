using BicingGP.Application.Domain.CityBk.Rosario;
using BicingGP.Application.MediatR.CityBik.Station.Rosario;
using BicingGP.Application.MediatR.CityBik.Status.Rosario;

namespace BicingGP.Application.Providers.CityBik
{
    public class ProviderCityBikRosario : Provider, 
        IProviderGeneric<BicingGP.Application.MediatR.CityBik.Station.Rosario.StationOutputDtoRosario
            , BicingGP.Application.MediatR.CityBik.Status.Rosario.StatusOutputDtoRosario>
    {
        public IEnumerable<BicingGP.Application.MediatR.CityBik.Station.Rosario.StationOutputDtoRosario> ConvertToStationOutDtos(string response)
        {
            var root = GenericConvert<CityBikRootGeneric>(response);
            return root!.network!.stations!.Select(c => c.ToStationOutDto()).ToList();
        }

        public IEnumerable<BicingGP.Application.MediatR.CityBik.Status.Rosario.StatusOutputDtoRosario> ConvertToStatusOutDtos(string response)
        {
            var root = GenericConvert<CityBikRootGeneric>(response);
            return root!.network!.stations!.Select(c => c.ToStatusOutDto()).ToList();            
        }
    }
}