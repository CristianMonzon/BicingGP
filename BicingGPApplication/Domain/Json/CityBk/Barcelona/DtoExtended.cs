using BicingGPApplication.MediatR.CityBik.Station.Barcelona;
using BicingGPApplication.MediatR.CityBik.Status;

namespace BicingGPApplication.Domain.Json.CityBk.Barcelona
{
    internal static class DtoExtended
    {
        internal static List<StatusOutDTO> ToStatusOutDTOs(this BarcelonaCityBikeRootGeneric root)
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

        internal static List<StationOutDTOBarcelona> ToStationOutDTO(this BarcelonaCityBikeRootGeneric root)
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