using BicingGPApplication.Domain.Json.CityBk.Rosario;
using BicingGPApplication.MediatR.CityBik.Station.Rosario;
using BicingGPApplication.MediatR.CityBik.Status;

namespace BicingGPApplication.Providers.CityBik
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
