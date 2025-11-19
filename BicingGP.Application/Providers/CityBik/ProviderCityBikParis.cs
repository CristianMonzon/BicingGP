using BicingGP.Application.Domain.CityBk.Paris;
using BicingGP.Application.MediatR.CityBik.Station.Paris;
using BicingGP.Application.MediatR.CityBik.Status.Paris;
using BicingGP.DataDomain.CityBik.Paris;

namespace BicingGP.Application.Providers.CityBik
{

    public class ProviderCityBikParis : Provider, IProviderGeneric<StationOutDtoParis, StatusOutputDtoParis>
    {
        public IEnumerable<StationOutDtoParis> ConvertToStationOutDtos(string response)
        {
            var root = GenericConvert<CityBikRootGeneric>(response);
            return root!.network!.stations!.Select(c => c.ToStationOutDto()).ToList();
        }

        public IEnumerable<StatusOutputDtoParis> ConvertToStatusOutDtos(string response)
        {
            var root = GenericConvert<CityBikRootGeneric>(response);
            return root!.network!.stations!.Select(c => c.ToStatusOutDto()).ToList();
        }
    }
}
