using BicingGPApplication.Domain.Json.CityBk.Barcelona;
using BicingGPApplication.MediatR.CityBik.Station.Barcelona;
using BicingGPApplication.MediatR.CityBik.Status;
using BicingGPDataDomain.CityBik.Barcelona;

namespace BicingGPApplication.Providers.CityBik
{
    public class ProviderCityBikBarcelonaGenerico : Provider, IProviderGeneric<BicingGPApplication.MediatR.CityBik.Station.Barcelona.StationOutDTOBarcelona>
    {
        public List<StationOutDTOBarcelona> ConvertToStationOutDTOGeneric(string response)
        {
            var root = GenericConvert<CityBikeRootGeneric>(response);
            return root!.network.stations.Select(c => c.ToStationOutDTOBarcelona()).ToList();
        }

        public List<StatusOutDTO> ConvertToStatusOutDTO(string response)
        {
            var root = GenericConvert<CityBikeRootGeneric>(response);
            return root!.network.stations.Select(c => c.ToStatusOutDTO()).ToList();
        }
    }
}
