using BicingGPApplication.Domain.Json.BarcelonaCityBik;
using BicingGPApplication.Entities;

namespace BicingGPApplication.MediatR.CityBik.Station.Barcelona
{
    
    public class StationOutDTOBarcelona
    {
        public string? StationId { get; set; }
        public string? Name { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        
        public string? Timestamp { get; set; }

        public int? FreeBikes { get; set; }
        public int? EmptySlots { get; set; }

        
        public bool? Online { get; set; }
        public int? NormalBikes { get; set; }
        public bool? HasEbikes { get; set; }
        public int? ElectricBikes { get; set; }

        
    }
}

