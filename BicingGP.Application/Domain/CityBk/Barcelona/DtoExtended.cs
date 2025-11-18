using BicingGP.Application.MediatR.CityBik.Station.Barcelona;
using BicingGP.Application.MediatR.CityBik.Status;
using BicingGP.DataDomain.CityBik.Barcelona;

namespace BicingGP.Application.Domain.CityBk.Barcelona
{
    internal static class DtoExtended
    {
        internal static List<StatusOutDTO> ToStatusOutDTOs(this CityBikRootGeneric root)
        {
            return root!.network!.stations!.Select(c => c.ToStatusOutDTO()).ToList();
        }

        internal static StatusOutDTO ToStatusOutDTO(this Station station)
        {
            return new StatusOutDTO()
            {
                StationId = station!.extra!.uid,
                Latitude = station.latitude,
                Longitude = station.longitude,
                FreBikes = station.free_bikes,
                Name = station.name,
                Timestamp = station.timestamp,
                EmptySlots = station.empty_slots,
            };
        }

        internal static List<StationOutDTOBarcelona> ToStationOutDTO(this CityBikRootGeneric root)
        {
            return root!.network!.stations!.Select(c => c.ToStationOutDTOBarcelona()).ToList();
        }

        internal static StationOutDTOBarcelona ToStationOutDTOBarcelona(this Station station)
        {
            return new StationOutDTOBarcelona()
            {
                StationId = station!.extra!.uid,
                Name = station.name,
                Latitude = station.latitude,
                Longitude = station.longitude,
                Timestamp = station.timestamp,
                FreeBikes = station.free_bikes,
                EmptySlots = station.empty_slots,
                Online = station!.extra!.online,
                NormalBikes = station!.extra!.normal_bikes,
                ElectricBikes = station!.extra!.ebikes,
                HasEbikes = station!.extra!.has_ebikes,
            };
        }
    }
}