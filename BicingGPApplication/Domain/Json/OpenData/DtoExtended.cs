using BicingGPApplication.Domain.Json.OpenDataStatus;
using BicingGPApplication.MediatR.CityBik.Station;
using BicingGPApplication.MediatR.CityBik.Status;
using BicingGPApplication.MediatR.OpenData.Station;
using BicingGPApplication.MediatR.OpenData.Status;

namespace BicingGPApplication.Domain.Json
{
    public static class DtoExtended
    {
        public static List<OpenDataStatusOutDTO> ToStatusOutDTOs(this BicingGPApplication.Domain.Json.OpenDataStatus.Data openData)
        {
            return openData.stations.Select(c => c.ToStatusOutDTO()).ToList();
        }

        
        public static OpenDataStatusOutDTO ToStatusOutDTO(this BicingGPApplication.Domain.Json.OpenDataStatus.Station station)
        {
            return new OpenDataStatusOutDTO()
            {
                StationId = station.station_id.ToString(),
                FreBikes = station.num_bikes_available,
                ElectricBikes = station.num_bikes_available_types.ebike,
                MecanicalBikes = station.num_bikes_available_types.mechanical,
                EmptySlots = station.num_docks_available                
            };
        }

        
        public static List<OpenDataStationOutDTO> ToStationOutDTOs(this BicingGPApplication.Domain.Json.OpenDataStation.Data openData)
        {
            return openData.stations.Select(c => c.ToStationOutDTO()).ToList();            
        }

        private static OpenDataStationOutDTO ToStationOutDTO(this BicingGPApplication.Domain.Json.OpenDataStation.Station station)
        {
            return new OpenDataStationOutDTO()
            {
                StationId = station.station_id.ToString(),
                Name = station.name,
                Longitude = station.lon,
                Latitude = station.lat,
                Address = station.address,
                PostCode = station.post_code,
                Altitude = station.altitude,
                Capacity = station.capacity,
            };
        }
    }
}

