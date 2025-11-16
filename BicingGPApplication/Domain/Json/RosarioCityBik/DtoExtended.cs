using BicingGPApplication.MediatR.CityBik.Station.Rosario;
using BicingGPApplication.MediatR.CityBik.Status;

namespace BicingGPApplication.Domain.Json.RosarioCityBik
{
    internal static class DtoExtended
    {
        internal static List<StatusOutDTO> ToStatusOutDTOs(this Domain.Json.RosarioCityBik.RosarioCityBikeRootGeneric root)
        {
            return root!.network!.stations!.Select(c => c.ToStatusOutDTO()).ToList();
        }

        internal static StatusOutDTO ToStatusOutDTO(this Domain.Json.RosarioCityBik.Station station)
        {
            return new StatusOutDTO()
            {
                StationId = station.extra!.uid.ToString(),
                Latitude = station.latitude,
                Longitude = station.longitude,
                FreBikes = station.free_bikes,
                Name = station.name,
                Timestamp = station.timestamp,
                EmptySlots = station.empty_slots,
            };
        }

        internal static List<StationOutDTORosario> ToStationOutDTO(this Domain.Json.RosarioCityBik.RosarioCityBikeRootGeneric root)
        {
            return root!.network!.stations!.Select(c => c.ToStationOutDTORosario()).ToList();
        }

        internal static StationOutDTORosario ToStationOutDTORosario(this Domain.Json.RosarioCityBik.Station station)
        {
            return new StationOutDTORosario()
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