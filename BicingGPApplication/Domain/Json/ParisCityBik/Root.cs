using Newtonsoft.Json;

namespace BicingGPApplication.Domain.Json.ParisCityBik
{
    public class Extra
    {
        public bool banking { get; set; }
        public int ebikes { get; set; }
        public int last_updated { get; set; }

        [JsonProperty("payment-terminal")]
        public bool paymentterminal { get; set; }
        public int renting { get; set; }
        public int returning { get; set; }
        public int slots { get; set; }
        public string station_id { get; set; }
        public string uid { get; set; }
        public List<string> payment { get; set; }
    }

    public class License
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Location
    {
        public string city { get; set; }
        public string country { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class Network
    {
        public List<string> company { get; set; }
        public bool ebikes { get; set; }
        public string gbfs_href { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public License license { get; set; }
        public Location location { get; set; }
        public string name { get; set; }
        public List<Station> stations { get; set; }
    }

    public class Root
    {
        public Network network { get; set; }
    }

    public class Station
    {
        public int empty_slots { get; set; }
        public Extra extra { get; set; }
        public int free_bikes { get; set; }
        public string id { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string name { get; set; }
        public DateTime timestamp { get; set; }
    }
}
