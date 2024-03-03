namespace BicingGPApplication.MediatR.CityBik.Status
{
    public class StatusOutDTO
    {
        public int? EmptySlots { get; set; }
        public int? MecanicalBikes { get; set; }
        public int? ElectricBikes { get; set; }
        public int? FreBikes { get; set; }

        public int? NormalBikes { get; set; }

        public string? StationId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public string? Name { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}