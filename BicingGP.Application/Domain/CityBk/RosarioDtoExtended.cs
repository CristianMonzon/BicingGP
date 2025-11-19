using BicingGP.Application.MediatR.CityBik.Station.Rosario;
using BicingGP.Application.MediatR.CityBik.Status.Rosario;

namespace BicingGP.Application.Domain.CityBk.Rosario
{
    internal static class DtoExtended
    {
        internal static List<StatusOutputDtoRosario> ToStatusOutDtos(this CityBikRootGeneric root)
        {
            return root!.network!.stations!.Select(c => c.ToStatusOutDto()).ToList();
        }

        internal static StatusOutputDtoRosario ToStatusOutDto(this Station station)
        {
            return new StatusOutputDtoRosario()
            {
                StationId = station.extra!.uid.ToString(),
                Name = station.name,

                FreBikes = station.free_bikes,
                EmptySlots = station.empty_slots,

                Slots = station.empty_slots,
                Timestamp = station.timestamp,

                Address = station.extra.address,
                PaymentMethods = station.extra.payment,
                PaymentTerminal = station.extra.paymentterminal
            };
        }

        internal static List<StationOutDtoRosario> ToStationOutDtos(this CityBikRootGeneric root)
        {
            return root!.network!.stations!.Select(c => c.ToStationOutDto()).ToList();
        }

        internal static StationOutDtoRosario ToStationOutDto(this Station station)
        {
            return new StationOutDtoRosario()
            {
                StationId = station.extra!.uid.ToString(),
                Name = station.name,
                Latitude = station.latitude,
                Longitude = station.longitude,
                Timestamp = station.timestamp,

                EmptySlots = station.empty_slots,
                FreeBikes = station.free_bikes,
                Adress = station.extra.address,
                LastUpdate = station.extra.last_updated,
                Renting = station.extra.renting,
                Returning = station.extra.returning,
                Payment = station.extra.payment,
                PaymentTerminal = station.extra.paymentterminal,
                Slots = station.extra.slots,
                Virtual = station.extra.@virtual
            };
        }
    }
}