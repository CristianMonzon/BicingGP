namespace BicingGP.Application.MediatR.CityBik.Status.Barcelona
{
    public class StatusOutputDtoBarcelona
    {
        public string? StationId { get; set; }
        public string? Name { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public int? EmptySlots { get; set; }
        public int? FreBikes { get; set; }
        public int? ElectronicBikes { get; set; }
        public int? NormalBikes { get; set; }
        public bool? HasElectronicBikes { get; set; }
        public string? Timestamp { get; set; }
        
    }
}