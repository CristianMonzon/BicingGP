using BicingGPApplication.Domain.Json.ParisCityBik;
using BicingGPApplication.MediatR.CityBik.Station.Paris;
using BicingGPApplication.MediatR.CityBik.Status;

namespace BicingGPApplication.Entities
{

    public class ProviderCityBikParis : GenericProvider, IProvider
    {
    }


    public class ProviderCityBikParisGenerico : Provider, IProviderGeneric<BicingGPApplication.MediatR.CityBik.Station.Paris.StationOutDTOParis>
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
