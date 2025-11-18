using BicingGP.Application.Domain.CityBk.Barcelona;
using BicingGP.Application.MediatR.CityBik.Station.Barcelona;
using BicingGP.Application.MediatR.CityBik.Status;
using BicingGP.DataDomain.CityBik.Barcelona;

namespace BicingGP.Application.Providers.CityBik
{
    public class ProviderCityBikBarcelonaGenerico : Provider, IProviderGeneric<BicingGP.Application.MediatR.CityBik.Station.Barcelona.StationOutDTOBarcelona>
    {
        public List<StationOutDTOBarcelona> ConvertToStationOutDTOGeneric(string response)
        {
            var root = GenericConvert<CityBikRootGeneric>(response);
            return root!.network.stations.Select(c => c.ToStationOutDTOBarcelona()).ToList();
        }

        public List<StatusOutDTO> ConvertToStatusOutDTO(string response)
        {
            var root = GenericConvert<CityBikRootGeneric>(response);
            return root!.network.stations.Select(c => c.ToStatusOutDTO()).ToList();
        }
    }
}
