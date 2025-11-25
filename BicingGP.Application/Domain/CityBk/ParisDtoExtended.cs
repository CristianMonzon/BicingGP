using BicingGP.Application.MediatR.CityBik.Station.Paris;
using BicingGP.Application.MediatR.CityBik.Status.Paris;

namespace BicingGP.Application.Domain.CityBk.Paris
{
    internal static class ParisDtoExtended
    {
        internal static List<StatusOutputDtoParis> ToStatusOutDtos(this BicingGP.DataProvider.CityBik.Paris.CityBikRootGeneric root)
        {
            return root!.network!.stations!.Select(c => c.ToStatusOutDto()).ToList();
        }

        internal static StatusOutputDtoParis ToStatusOutDto(this BicingGP.DataProvider.CityBik.Paris.Station station)
        {
            return new StatusOutputDtoParis()
            {
                StationId = station.extra?.uid,
                Latitude = station.latitude,
                Longitude = station.longitude,
                
                Slots = station.extra?.slots,
                FreBikes = station.free_bikes,
                Name = station.name,

                EmptySlots = station.empty_slots,

                ElectricalBikes = station.free_bikes,
                NormalBikes = station.free_bikes,

                PaymentMethods = station.extra?.payment,
                PaymentTerminal = station.extra?.paymentterminal,

                Banking = station.extra?.banking,
                Timestamp = station.timestamp,
            };
        }

        internal static List<StationOutputDtoParis> ToStationOutDtos(this BicingGP.DataProvider.CityBik.Paris.CityBikRootGeneric root)
        {
            return root!.network!.stations!.Select(c => c.ToStationOutDto()).ToList();
        }

        internal static StationOutputDtoParis ToStationOutDto(this BicingGP.DataProvider.CityBik.Paris.Station station)
        {
            return new StationOutputDtoParis()
            {

                Id = station!.extra!.uid,
                Name = station.name,
                Latitude = station.latitude,
                Longitude = station.longitude,
                Timestamp = station.timestamp,

                EmptySlots = station.empty_slots,

                LastUpdate = station.extra?.last_updated,
                Renting = station.extra?.renting,
                Returning = station.extra?.returning,
                PaymentTerminal = station.extra?.paymentterminal,

                Banking = station.extra?.banking,
                ElectricBikes = station.extra?.ebikes,
                FreeBikes = station.free_bikes,
                NormalBikes = station.extra?.normal_bikes,
                Slots = station.extra?.slots,
                Virtual = station.extra?.@virtual
            };
        }
    }
}