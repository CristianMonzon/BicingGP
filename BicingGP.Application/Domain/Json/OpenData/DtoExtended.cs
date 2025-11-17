namespace BicingGP.Application.Domain.Json.OpenData
{
    public static class DtoExtended
    {
        public static List<MediatR.OpenData.Status.OpenDataStatusOutDTO> ToStatusOutDTOs(this Status.OpenDataStatus openDataStatus)
        {            
            return openDataStatus!.data!.stations!.Select(c => c.ToStatusOutDTO()).ToList();
        }

        public static MediatR.OpenData.Status.OpenDataStatusOutDTO ToStatusOutDTO(this Status.Station station)
        {
            return new MediatR.OpenData.Status.OpenDataStatusOutDTO()
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

        public static List<MediatR.OpenData.Station.OpenDataStationOutDTO> ToStationOutDTOs(this Station.Data openData)
        {
            return openData!.stations!.Select(c => c.ToStationOutDTO()).ToList();
        }

        private static MediatR.OpenData.Station.OpenDataStationOutDTO ToStationOutDTO(this Station.Station station)
        {
            return new MediatR.OpenData.Station.OpenDataStationOutDTO()
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
