using Newtonsoft.Json;

namespace BicingGP.Application.Domain.CityBik.Rosario
{
    public class CityBikRootGeneric
    {
        public Network? network { get; set; }
    }

    public class Network
    {
        public string? id { get; set; }
        public string? name { get; set; }
        public Location? location { get; set; }
        public string? href { get; set; }
        public List<string>? company { get; set; }
        public string? gbfs_href { get; set; }
        public List<Station>? stations { get; set; }
    }

    public class Location
    {
        public string? latitude { get; set; }
        public string? longitude { get; set; }
        public string? city { get; set; }
        public string? country { get; set; }
    }

    public class Station
    {
        public string? id { get; set; }
        public string? name { get; set; }
        public string? latitude { get; set; }
        public string? longitude { get; set; }
        public string? timestamp { get; set; }
        public int? free_bikes { get; set; }
        public int? empty_slots { get; set; }
        public Extra? extra { get; set; }
    }

    public class Extra
    {
        public int? uid { get; set; }
        public int? renting { get; set; }
        public int? returning { get; set; }
        public int? last_updated { get; set; }
        public string? address { get; set; }
        public List<string>? payment { get; set; }

        [JsonProperty("payment-terminal")]
        public bool? paymentterminal { get; set; }
        public int? slots { get; set; }
        public bool? @virtual { get; set; }
    }
}