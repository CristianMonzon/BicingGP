namespace BicingGP.Application.MediatR.CityBik.Status
{
    public class StatusOutDTO
    {
        public int? EmptySlots { get; set; }
        public int? MecanicalBikes { get; set; }
        public int? ElectricBikes { get; set; }
        public int? FreBikes { get; set; }

        public int? NormalBikes { get; set; }

        public string? StationId { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }

        public string? Name { get; set; }
        public string? Timestamp { get; set; }
    }
}