using BicingGP.Application.Domain.Json.CityBk.Paris;
using BicingGP.Application.MediatR.CityBik.Station.Paris;
using BicingGP.Application.MediatR.CityBik.Status;
using BicingGP.DataDomain.CityBik.Paris;

namespace BicingGP.Application.Providers.CityBik
{

    public class ProviderCityBikParisGenerico : Provider, IProviderGeneric<StationOutDTOParis>
    {
        public List<StationOutDTOParis> ConvertToStationOutDTOGeneric(string response)
        {
            var root = GenericConvert<CityBikRootGeneric>(response);
            return root!.network.stations.Select(c => c.ToStationOutDTOParis()).ToList();
        }
        
        public List<StatusOutDTO> ConvertToStatusOutDTO(string response)
        {
            var root = GenericConvert<CityBikRootGeneric>(response);
            return root!.network.stations.Select(c => c.ToStatusOutDTO()).ToList();
        }
    }
}
