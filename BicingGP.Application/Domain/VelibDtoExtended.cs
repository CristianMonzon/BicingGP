using BicingGP.Application.MediatR.Velib.Status;
using BicingGP.Application.MediatR.Velib.Station;

namespace BicingGP.Application.Domain.Velib
{
    public static class VelibDtoExtended
    {
        public static List<StatusOutputDtoVelib> ToStatusOutDtos(this DataProvider.Velib.Status.VelibRootStatus status)
        {
            return status!.data!.stations!.Select(c => c.ToStatusOutDto()).ToList();
        }

        public static StatusOutputDtoVelib ToStatusOutDto(this DataProvider.Velib.Status.Station station)
        {
            return new StatusOutputDtoVelib()
            {
                StationId = station.station_id,
                NumBikesAvailable = station.num_bikes_available,
                NumDocksAvailable = station.num_docks_available,
                IsInstalled = station.is_installed,
                IsRenting = station.is_renting,
                IsReturning = station.is_returning,
                LastReported = station.last_reported,
                StationCode = station.stationCode,
                RentalMethods = station.rental_methods,
                NumBikesAvailableTypes = station.num_bikes_available_types != null ?
                station.num_bikes_available_types.Select(c => new BikeTypesDto()
                {
                    Electrical = c.ebike,
                    Mechanical = c.mechanical
                }).ToList() : null
            };
        }

        public static List<StationOutputDtoVelib> ToStationOutDtos(this DataProvider.Velib.Station.VelibRootStation station)
        {
            return station!.data!.stations!.Select(c => c.ToStationOutDto()).ToList();
        }

        private static StationOutputDtoVelib ToStationOutDto(this DataProvider.Velib.Station.Station station)
        {
            return new StationOutputDtoVelib()
            {
                StationId = station.station_id,
                Name = station.name,
                Longitude = station.lon,
                Latitude = station.lat,
                Capacity = station.capacity,
                RentalMethods = station.rental_methods,
                StationCode = station.stationCode
            };
        }
    }
}