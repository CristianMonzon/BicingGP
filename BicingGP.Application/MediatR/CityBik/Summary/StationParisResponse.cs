namespace BicingGP.Application.MediatR.CityBik.Summary
{
    public class StationParisResponse
    {
        public string? Name { get; set; }
        public string? StationId { get; set; }
        public int? Slots { get; set; }
        public int? FreeBikes { get; set; }       
    }
}
