namespace BicingGP.Application.MediatR.MiBiciTuBici.Status;

public class StatusOutputDtoMiBiciTuBici
{
    public string? StationId { get; set; }
    public int? NumBikesAvailable { get; set; }
    public int? NumBikesDisabled { get; set; }
    public int? NumDocksAvailable { get; set; }
    public int? NumDocksDisabled { get; set; }
    public int? IsInstalled { get; set; }
    public int? IsRenting { get; set; }
    public int? IsReturning { get; set; }
    public int? LastReported { get; set; }

}