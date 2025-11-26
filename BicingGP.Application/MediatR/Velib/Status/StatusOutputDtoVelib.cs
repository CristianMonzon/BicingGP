namespace BicingGP.Application.MediatR.Velib.Status;

public class StatusOutputDtoVelib
{
    public string? StationId { get; set; }
    public int? NumBikesAvailable { get; set; }
    public int? NumDocksAvailable { get; set; }
    public int? IsInstalled { get; set; }
    public int? IsRenting { get; set; }
    public int? IsReturning { get; set; }
    public int? LastReported { get; set; }
    public string? StationCode { get; set; }
    public List<string>? RentalMethods { get; set; }
    public List<BikeTypesDto>? NumBikesAvailableTypes { get; set; }
}

public class BikeTypesDto
{
    public int? Mechanical { get; set; }
    public int? Electrical { get; set; }
}

