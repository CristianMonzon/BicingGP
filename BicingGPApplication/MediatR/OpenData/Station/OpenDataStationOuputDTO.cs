namespace BicingGPApplication.MediatR.OpenData.Station
{
    public class OpenDataStationOutDTO
    {
        public string? StationId { get; set; }
        public string? Altitude { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? PostCode { get; set; }
        public int? Capacity { get; set; }
        public string? PhysicalConfiguration { get; set; }
        public string? CrossStreet { get; set; }
        public bool? IsCharginStation { get; set; }
    }
}

