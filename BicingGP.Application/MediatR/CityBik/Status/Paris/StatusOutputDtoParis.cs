namespace BicingGP.Application.MediatR.CityBik.Status.Paris
{
    public class StatusOutputDtoParis
    {
        public string? StationId { get; set; }
        public string? Name { get; set; }
        
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }

        public int? Slots { get; set; }

        public int? EmptySlots { get; set; }
        public int? FreBikes { get; set; }
        
        public int? NormalBikes { get; set; }
        public int? ElectricalBikes { get; set; }
                
        public bool? PaymentTerminal { get; set; }
        public List<string>? PaymentMethods { get; set; }
        public bool? Banking { get; set; }

        public string? Timestamp { get; set; }
    }
}
