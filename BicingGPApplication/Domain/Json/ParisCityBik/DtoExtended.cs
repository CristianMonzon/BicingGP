using BicingGPApplication.MediatR.CityBik.Station;
using BicingGPApplication.MediatR.CityBik.Status;

namespace BicingGPApplication.Domain.Json.ParisCityBik
{
    internal static class DtoExtended
    {
        internal static List<StatusOutDTO> ToStatusOutDTOs(this Domain.Json.ParisCityBik.Root root)
        {
            return root.network.stations.Select(c => c.ToStatusOutDTO()).ToList();
        }

        internal static StatusOutDTO ToStatusOutDTO(this Domain.Json.ParisCityBik.Station station)
        {
            return new StatusOutDTO()
            {
                StationId = station.extra.uid.ToString(),
                Latitude = station.latitude,
                Longitude = station.longitude,
                FreBikes = station.free_bikes,
                Name = station.name,
                Timestamp = station.timestamp,
                EmptySlots = station.empty_slots,
            };
        }
        
        internal static List<StationOutDTO> ToStationOutDTOs(this Domain.Json.ParisCityBik.Root root)
        {
            return root.network.stations.Select(c => c.ToStationOutDTO()).ToList();            
        }

        internal static StationOutDTO ToStationOutDTO(this Domain.Json.ParisCityBik.Station station)
        {
            return new StationOutDTO()
            {
                StationId = station.extra.uid.ToString(),
                Latitude = station.latitude,
                Longitude = station.longitude,
                FreBikes = station.free_bikes,                 
                Name = station.name,
                Timestamp = station.timestamp,
                EmptySlots = station.empty_slots,                
            };
        }
    }
}