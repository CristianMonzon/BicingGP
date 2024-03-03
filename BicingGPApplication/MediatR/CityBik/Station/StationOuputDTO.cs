using BicingGPApplication.Entities;

namespace BicingGPApplication.MediatR.CityBik.Station
{
    
    public class StationOutDTO 
    {
        public string? StationId { get; set; }
        public double? Altitude { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? PostCode { get; set; }
        public int? Capacity { get; set; }
        public DateTime? Timestamp { get; set; }

        //Generic
        public int? EmptySlots { get; set; }
        public int? NormalBikes { get; set; }
        public int? ElectricBikes { get; set; }
        public int? FreBikes { get; set; }
        
    }
}

