using BicingGPApplication.MediatR.CityBik.Station.Paris;
using BicingGPApplication.MediatR.CityBik.Status;

namespace BicingGPApplication.Domain.Json.ParisCityBik
{
    internal static class DtoExtended
    {
        internal static List<StatusOutDTO> ToStatusOutDTOs(this Domain.Json.ParisCityBik.ParisCityBikeRootGeneric root)
        {
            return root.network.stations.Select(c => c.ToStatusOutDTO()).ToList();
        }

        internal static StatusOutDTO ToStatusOutDTO(this Domain.Json.ParisCityBik.Station station)
        {
            return new StatusOutDTO()
            {
                StationId = station.extra.uid,
                Latitude = station.latitude,
                Longitude = station.longitude,
                FreBikes = station.free_bikes,
                Name = station.name,
                Timestamp = station.timestamp,
                EmptySlots = station.empty_slots,
            };
        }

        internal static List<StationOutDTOParis> ToStationOutDTO(this Domain.Json.ParisCityBik.ParisCityBikeRootGeneric root)
        {
            return root.network.stations.Select(c => c.ToStationOutDTOParis()).ToList();
        }


        internal static StationOutDTOParis ToStationOutDTOParis(this Domain.Json.ParisCityBik.Station station)
        {
            return new StationOutDTOParis()
            {

                Id = station!.extra!.uid,
                Name = station.name,
                Latitude = station.latitude,
                Longitude = station.longitude,
                Timestamp = station.timestamp,

                EmptySlots = station.empty_slots,

                LastUpdate = station.extra.last_updated,
                Renting = station.extra.renting,
                Returning = station.extra.returning,
                PaymentTerminal = station.extra.paymentterminal,

                Banking = station.extra.banking,
                ElectricBikes = station.extra.ebikes,
                FreeBikes = station.free_bikes,
                NormalBikes = station.extra.normal_bikes,
                Slots = station.extra.slots,
                Virtual = station.extra.@virtual
            };
        }
    }
}