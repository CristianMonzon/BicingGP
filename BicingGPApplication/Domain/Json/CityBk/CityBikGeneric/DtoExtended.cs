using BicingGPApplication.MediatR.CityBik.Status;
using BicingGPDataDomain.CityBik.Generic;

namespace BicingGPApplication.Domain.Json.CityBk.CityBikGeneric
{
    internal static class GenericDtoExtended
    {
        internal static List<StatusOutDTO> ToStatusOutDTOs(this CityBikRootGeneric root)
        {
            return root!.network!.stations!.Select(c => c.ToStatusOutDTO()).ToList();
        }

        internal static StatusOutDTO ToStatusOutDTO(this Station station)
        {
            return new StatusOutDTO()
            {
                StationId = station.extra?.uid,
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