using BicingGPApplication.MediatR.CityBik.Status;

namespace BicingGPApplication.Domain.Json.CityBk.Generic
{
    internal static class GenericDtoExtended
    {
        internal static List<StatusOutDTO> ToStatusOutDTOs(this CityBikeRootGeneric root)
        {
            return root!.network!.stations!.Select(c => c.ToStatusOutDTO()).ToList();
        }

        internal static StatusOutDTO ToStatusOutDTO(this Station station)
        {
            return new StatusOutDTO()
            {
                StationId = station.extra?.uid.ToString(),
                Latitude = station.latitude,
                Longitude = station.longitude,
                FreBikes = station.free_bikes,
                
                NormalBikes = station.extra?.normal_bikes,
                ElectricBikes = station.extra?.ebikes,
                
                Name = station.name,
                Timestamp = station.timestamp,
                EmptySlots = station.empty_slots,
            };
        }
    }
}