namespace BicingGP.Application.Domain.OpenData
{
    public static class OpenDataDtoExtended
    {
        public static List<MediatR.OpenData.Status.OpenDataStatusOutDto> ToStatusOutDtos(this DataProvider.OpenData.Status.OpenDataRootStatus openDataStatus)
        {            
            return openDataStatus!.data!.stations!.Select(c => c.ToStatusOutDto()).ToList();
        }

        public static MediatR.OpenData.Status.OpenDataStatusOutDto ToStatusOutDto(this DataProvider.OpenData.Status.Station station)
        {
            return new MediatR.OpenData.Status.OpenDataStatusOutDto()
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

        public static List<MediatR.OpenData.Station.OpenDataStationOutDto> ToStationOutDtos(this DataProvider.OpenData.Station.Data openData)
        {
            return openData!.stations!.Select(c => c.ToStationOutDto()).ToList();
        }

        private static MediatR.OpenData.Station.OpenDataStationOutDto ToStationOutDto(this DataProvider.OpenData.Station.Station station)
        {
            return new MediatR.OpenData.Station.OpenDataStationOutDto()
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
