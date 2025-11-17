namespace BicingGPApplication.MediatR.CityBik.Station.Paris
{
    
    public class StationOutDTOParis
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        
        public string? Timestamp { get; set; }
        public int? FreeBikes { get; set; }
        public int? EmptySlots { get; set; }
                
        public int? Renting { get; set; }
        public int? Returning { get; set; }
        public int? LastUpdate { get; set; }

        public int? Slots { get; set; }
        public bool? Virtual { get; set; }

        public bool? Banking { get; set; }

        public bool? PaymentTerminal { get; set; }

        public int? NormalBikes{ get; set; }
        public int? ElectricBikes { get; set; }


    }
}

