namespace BicingGP.Application.MediatR.Velib.Station;

public class StationOutputDtoVelib
{
    public string? StationId { get; set; }
    public string? Latitude { get; set; }
    public string? Longitude { get; set; }
    public string? Name { get; set; }
    public int? Capacity { get; set; }
    public List<string>? RentalMethods { get; set; }
    public string? StationCode { get; set; }
    
}
