using BicingGPApplication.Domain.Json.CityBk.Paris;
using BicingGPApplication.MediatR.CityBik.Station.Paris;
using BicingGPApplication.MediatR.CityBik.Status;

namespace BicingGPApplication.Entities.CityBik
{

    public class ProviderCityBikParisGenerico : Provider, IProviderGeneric<StationOutDTOParis>
    {
        public List<StationOutDTOParis> ConvertToStationOutDTOGeneric(string response)
        {
            var root = GenericConvert<ParisCityBikeRootGeneric>(response);
            return root!.network.stations.Select(c => c.ToStationOutDTOParis()).ToList();
        }
        
        public List<StatusOutDTO> ConvertToStatusOutDTO(string response)
        {
            var root = GenericConvert<ParisCityBikeRootGeneric>(response);
            return root!.network.stations.Select(c => c.ToStatusOutDTO()).ToList();
        }
    }
}
