using BicingGPApplication.Domain.Json.CityBk.Paris;
using BicingGPApplication.MediatR.CityBik.Station.Paris;
using BicingGPApplication.MediatR.CityBik.Status;
using BicingGPDataDomain.CityBik.Paris;

namespace BicingGPApplication.Providers.CityBik
{

    public class ProviderCityBikParisGenerico : Provider, IProviderGeneric<StationOutDTOParis>
    {
        public List<StationOutDTOParis> ConvertToStationOutDTOGeneric(string response)
        {
            var root = GenericConvert<CityBikeRootGeneric>(response);
            return root!.network.stations.Select(c => c.ToStationOutDTOParis()).ToList();
        }
        
        public List<StatusOutDTO> ConvertToStatusOutDTO(string response)
        {
            var root = GenericConvert<CityBikeRootGeneric>(response);
            return root!.network.stations.Select(c => c.ToStatusOutDTO()).ToList();
        }
    }
}
