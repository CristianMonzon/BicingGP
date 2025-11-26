namespace BicingGP.Application.MediatR.CityBik.Summary
{
    public class StationBarcelonaResponse
    {
        public string? Name { get; set; }
        public string? StationId { get; set; }
        public int? ElectricBikes { get; set; }
        public int? NormalBikes { get; set; }
    }
}
