namespace BicingGPApplication.MediatR.OpenData.Status
{
    public class OpenDataStatusOutDTO
    {
        public int? EmptySlots { get; set; }
        public int? MecanicalBikes { get; set; }
        public int? ElectricBikes { get; set; }
        public int? FreBikes { get; set; }        

        public string? StationId { get; set; }
    }
}