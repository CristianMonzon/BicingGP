namespace BicingGPApplication.MediatR.OpenData.Status
{
    public class OpenDataStatusOutDTO
    {
        public string? StationId { get; set; }
        public int? AvailableBikes { get; set; }
        public int? MecanicalBikes { get; set; }
        public int? ElectricBikes { get; set; }
        public int? FreBikes { get; set; }

        public int? AvailableDock { get; set; }

        public int? LastReported { get; set; }

        public bool? IsCharginStation { get; set; }

        public string? Status { get; set; }

        public int? ÌsInstalled { get; set; }
        public int? IsRenting { get; set; }
        public int? IsReturning{ get; set; }
         
    }
}