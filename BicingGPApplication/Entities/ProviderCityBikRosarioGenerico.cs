using BicingGPApplication.Domain.Json.RosarioCityBik;
using BicingGPApplication.MediatR.CityBik.Station.Rosario;
using BicingGPApplication.MediatR.CityBik.Status;

namespace BicingGPApplication.Entities
{

    public class ProviderCityBikRosario : GenericProvider, IProvider
    {        
    }

    public class ProviderCityBikRosarioGenerico : Provider, IProviderGeneric<BicingGPApplication.MediatR.CityBik.Station.Rosario.StationOutDTORosario>
    {
        public List<StationOutDTORosario> ConvertToStationOutDTOGeneric(string response)
        {
            var root = GenericConvert<RosarioCityBikeRootGeneric>(response);
            return root!.network!.stations!.Select(c => c.ToStationOutDTORosario()).ToList();
        }
        
        public List<StatusOutDTO> ConvertToStatusOutDTO(string response)
        {
            var root = GenericConvert<RosarioCityBikeRootGeneric>(response);
            return root!.network!.stations!.Select(c => c.ToStatusOutDTO()).ToList();
        }
    }
}
