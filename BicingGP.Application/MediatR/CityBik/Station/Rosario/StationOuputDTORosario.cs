namespace BicingGP.Application.MediatR.CityBik.Station.Rosario
{
    
    public class StationOutDTORosario 
    {
        public string? StationId { get; set; }
        public string? Name { get; set; }

        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        
        public string? Timestamp { get; set; }
        
        public int? EmptySlots { get; set; }
        public int? FreeBikes { get; set; }

        public int? Renting { get; set; }
        public int? Returning { get; set; }
        public int? LastUpdate { get; set; }
        public string? Adress { get; set; }

        public List<String>? Payment { get; set; }

        public bool? PaymentTerminal { get; set; }

        public int? Slots { get; set; }
        public bool? Virtual { get; set; }
        

    }
}

