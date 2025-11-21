using BicingGP.Application.MediatR.CityBik.Station.Barcelona;
using BicingGP.Application.MediatR.CityBik.Status.Barcelona;

namespace BicingGP.Application.Domain.CityBk.Barcelona
{
    internal static class BarcelonaDtoExtended
    {
        internal static List<StatusOutputDtoBarcelona> ToStatusOutDtos(this BicingGP.DataDomain.CityBik.Barcelona.CityBikRootGeneric root)
        {
            return root!.network!.stations!.Select(c => c.ToStatusOutDto()).ToList();
        }

        internal static StatusOutputDtoBarcelona ToStatusOutDto(this BicingGP.DataDomain.CityBik.Barcelona.Station station)
        {
            return new StatusOutputDtoBarcelona()
            {
                StationId = station.extra?.uid,
                Name = station.name,
                Latitude = station.latitude,
                Longitude = station.longitude,

                FreBikes = station.free_bikes,
                EmptySlots = station.empty_slots,

                ElectronicBikes = station.extra?.ebikes,
                NormalBikes = station.extra?.normal_bikes,

                HasElectronicBikes = station.extra?.has_ebikes,

                Timestamp = station.timestamp
            };
        }

        internal static List<StationOutputDtoBarcelona> ToStationOutDtos(this BicingGP.DataDomain.CityBik.Barcelona.CityBikRootGeneric root)
        {
            return root!.network!.stations!.Select(c => c.ToStationOutDto()).ToList();
        }

        internal static StationOutputDtoBarcelona ToStationOutDto(this BicingGP.DataDomain.CityBik.Barcelona.Station station)
        {
            return new StationOutputDtoBarcelona()
            {
                StationId = station!.extra!.uid,
                Name = station.name,
                Latitude = station.latitude,
                Longitude = station.longitude,
                Timestamp = station.timestamp,
                FreeBikes = station.free_bikes,
                EmptySlots = station.empty_slots,
                Online = station!.extra!.online,
                NormalBikes = station!.extra!.normal_bikes,
                ElectricBikes = station!.extra!.ebikes,
                HasEbikes = station!.extra!.has_ebikes,
            };
        }
    }
}