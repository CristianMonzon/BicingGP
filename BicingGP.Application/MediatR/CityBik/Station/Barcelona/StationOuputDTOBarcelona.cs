namespace BicingGP.Application.MediatR.CityBik.Station.Barcelona
{
    
    public class StationOutDtoBarcelona
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

