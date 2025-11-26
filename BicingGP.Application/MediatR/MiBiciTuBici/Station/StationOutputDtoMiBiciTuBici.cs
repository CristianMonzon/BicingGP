namespace BicingGP.Application.MediatR.MiBiciTuBici.Station;

public class StationOutputDtoMiBiciTuBici
{
    public string? StationId { get; set; }
    public string? Latitude { get; set; }
    public string? Longitude { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public int? Capacity { get; set; }
    public List<string>? RentalMethods { get; set; }
    public int? StationCode { get; set; }
    
}
