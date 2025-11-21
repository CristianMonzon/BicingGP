using BicingGP.Application.MediatR.MiBiciTuBici.Status;
using BicingGP.Application.MediatR.MiBiciTuBici.Station;

namespace BicingGP.Application.Domain.MiBiciTuBici
{
    public static class MiBiciTuBiciDtoExtended
    {
        public static List<StatusOutputDto> ToStatusOutDtos(this DataDomain.MiBiciTuBici.Status.MiBiciTuBiciRootStatus status)
        {
            return status!.data!.stations!.Select(c => c.ToStatusOutDto()).ToList();
        }

        public static StatusOutputDto ToStatusOutDto(this DataDomain.MiBiciTuBici.Status.Station station)
        {
            return new StatusOutputDto()
            {
                StationId = station.station_id,
                NumBikesAvailable = station.num_bikes_available,
                NumBikesDisabled = station.num_bikes_disabled,
                NumDocksAvailable = station.num_docks_available,
                NumDocksDisabled = station.num_docks_disabled,
                IsInstalled = station.is_installed,
                IsRenting = station.is_renting,
                IsReturning = station.is_returning,
                LastReported = station.last_reported
            };
        }

        public static List<StationOutputDto> ToStationOutDtos(this DataDomain.MiBiciTuBici.Station.MiBiciTuBiciRootStation station)
        {
            return station!.data!.stations!.Select(c => c.ToStationOutDto()).ToList();
        }

        private static StationOutputDto ToStationOutDto(this DataDomain.MiBiciTuBici.Station.Station station)
        {
            return new StationOutputDto()
            {
                StationId = station.station_id,
                Name = station.name,
                Longitude = station.lon,
                Latitude = station.lat,
                Address = station.address,
                Capacity = station.capacity,
                RentalMethods = station.rental_methods,
                StationCode = station.station_code
            };
        }
    }
}
