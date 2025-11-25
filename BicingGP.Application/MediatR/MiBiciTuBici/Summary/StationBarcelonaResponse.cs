namespace BicingGP.Application.MediatR.MiBiciTuBici.Summary
{
    public class StationBarcelonaResponse
    {
        public string? Name { get; set; }
        public string? StationId { get; set; }
        public int? ElectricBikes { get; set; }
        public int? NormalBikes { get; set; }
    }
}
