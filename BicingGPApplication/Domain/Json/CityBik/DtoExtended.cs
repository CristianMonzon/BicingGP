using BicingGPApplication.MediatR.CityBik.Station;
using BicingGPApplication.MediatR.CityBik.Status;

namespace BicingGPApplication.Domain.Json.CityBik
{
    internal static class GenericDtoExtended
    {
        internal static List<StatusOutDTO> ToStatusOutDTOs(this Root root)
        {
            return root.network.stations.Select(c => c.ToStatusOutDTO()).ToList();
        }

        internal static StatusOutDTO ToStatusOutDTO(this Domain.Json.CityBik.Station station)
        {
            return new StatusOutDTO()
            {
                StationId = station.extra.uid.ToString(),
                Latitude = station.latitude,
                Longitude = station.longitude,
                FreBikes = station.free_bikes,
                NormalBikes = station.extra.normal_bikes,
                ElectricBikes = station.extra.ebikes,
                Name = station.name,
                Timestamp = station.timestamp,
                EmptySlots = station.empty_slots,
            };
        }

        internal static List<StationOutDTO> ToStationOutDTOs(this Root root)
        {
            return root.network.stations.Select(c => c.ToStationOutDTO()).ToList();            
        }

        internal static StationOutDTO ToStationOutDTO(this Domain.Json.CityBik.Station station)
        {
            return new StationOutDTO()
            {
                StationId = station.extra.uid.ToString(),
                Latitude = station.latitude,
                Longitude = station.longitude,
                FreBikes = station.free_bikes,
                NormalBikes = station.extra.normal_bikes,
                ElectricBikes = station.extra.ebikes,
                Name = station.name,
                 Address=station.name,                  

                Timestamp = station.timestamp,
                EmptySlots = station.empty_slots,
            };
        }
    }
}