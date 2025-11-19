namespace BicingGP.Application.MediatR.CityBik.Status.Rosario
{
    public class StatusOutputDtoRosario
    {
        public string? StationId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int? Slots { get; set; }
        public int? EmptySlots { get; set; }
        public int? FreBikes { get; set; }
        public bool? PaymentTerminal { get; set; }
        public List<string>? PaymentMethods { get; set; }
        public string? Timestamp { get; set; }
    }
}