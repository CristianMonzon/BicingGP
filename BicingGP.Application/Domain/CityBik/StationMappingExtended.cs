using BicingGP.Application.MediatR.CityBik.Station.Barcelona;
using BicingGP.Application.MediatR.CityBik.Station.Paris;
using BicingGP.Application.MediatR.CityBik.Station.Rosario;
using BicingGP.Application.MediatR.CityBik.Summary;

namespace BicingGP.Application.Domain.CityBik
{
    public static class StationMappingExtended
    {
        public static StationRosarioResponse FromStationDtoRosarioToStationResponse(this StationOutputDtoRosario dto)
        {
            return new StationRosarioResponse
            {
                Name = dto.Name,
                StationId = dto.StationId,
                Slots = dto.Slots,
                FreeBikes = dto.FreeBikes
            };
        }

        public static StationParisResponse FromStationDtoParisToStationResponse(this StationOutputDtoParis dto)
        {
            return new StationParisResponse
            {
                Name = dto.Name,
                StationId = dto.Id,
                Slots = dto.Slots,
                FreeBikes = dto.FreeBikes                
            };
        }

        public static StationBarcelonaResponse FromStationDtoBarcelonaToStationResponse(this StationOutputDtoBarcelona dto)
        {
            return new StationBarcelonaResponse
            {
                Name = dto.Name,
                StationId = dto.StationId,
                ElectricBikes = dto.ElectricBikes,
                NormalBikes = dto.NormalBikes
            };
        }
    }
}
