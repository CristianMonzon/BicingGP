using BicingGPApplication.Domain.Json.BarcelonaCityBik;
using BicingGPApplication.MediatR.CityBik.Station.Barcelona;
using BicingGPApplication.MediatR.CityBik.Status;

namespace BicingGPApplication.Entities
{
    public class ProviderCityBikBarcelona : GenericProvider, IProvider
    {
    }

    public class ProviderCityBikBarcelonaGenerico : Provider, IProviderGeneric<BicingGPApplication.MediatR.CityBik.Station.Barcelona.StationOutDTOBarcelona>
    {
        public List<StationOutDTOBarcelona> ConvertToStationOutDTOGeneric(string response)
        {
            var root = GenericConvert<BicingGPApplication.Domain.Json.BarcelonaCityBik.BarcelonaCityBikeRootGeneric>(response);
            return root!.network.stations.Select(c => c.ToStationOutDTOBarcelona()).ToList();
        }

        public List<StatusOutDTO> ConvertToStatusOutDTO(string response)
        {
            var root = GenericConvert<BicingGPApplication.Domain.Json.BarcelonaCityBik.BarcelonaCityBikeRootGeneric>(response);
            return root!.network.stations.Select(c => c.ToStatusOutDTO()).ToList();
        }
    }
}
