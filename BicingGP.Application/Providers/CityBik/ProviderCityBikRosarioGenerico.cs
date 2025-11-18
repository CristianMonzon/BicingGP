using BicingGP.Application.Domain.CityBk.Rosario;
using BicingGP.Application.MediatR.CityBik.Station.Rosario;
using BicingGP.Application.MediatR.CityBik.Status;

namespace BicingGP.Application.Providers.CityBik
{
    public class ProviderCityBikRosarioGenerico : Provider, IProviderGeneric<StationOutDTORosario>
    {
        public List<StationOutDTORosario> ConvertToStationOutDTOGeneric(string response)
        {
            var root = GenericConvert<CityBikeRootGeneric>(response);
            return root!.network!.stations!.Select(c => c.ToStationOutDTORosario()).ToList();
        }
        
        public List<StatusOutDTO> ConvertToStatusOutDTO(string response)
        {
            var root = GenericConvert<CityBikeRootGeneric>(response);
            return root!.network!.stations!.Select(c => c.ToStatusOutDTO()).ToList();
        }            
       
    }
}
