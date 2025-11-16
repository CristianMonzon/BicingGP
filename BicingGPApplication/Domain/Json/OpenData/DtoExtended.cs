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
                StationId = station.station_id,
                FreBikes = station.num_bikes_available,

                ElectricBikes = station.num_bikes_available_types?.ebike,
                MecanicalBikes = station.num_bikes_available_types?.mechanical,
                
                LastReported = station.last_reported,
                AvailableBikes = station.num_bikes_available,
                AvailableDock = station.num_docks_available,
                IsCharginStation = station.is_charging_station,
                Status = station.status,
                ÌsInstalled = station.is_installed,
                IsRenting = station.is_renting,
                IsReturning = station.is_returning
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
                IsCharginStation = station.is_charging_station,
                PhysicalConfiguration = station.physical_configuration,
                CrossStreet = station.cross_street
            };
        }
    }
}

