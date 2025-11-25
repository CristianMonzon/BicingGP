namespace BicingGP.DataProvider.CityBik.Barcelona
{
    public class CityBikRootGeneric
    {
        public Network? network { get; set; }
    }

    public class Extra
    {
        public string? uid { get; set; }
        public bool? online { get; set; }
        public int? normal_bikes { get; set; }
        public bool? has_ebikes { get; set; }
        public int? ebikes { get; set; }
    }

    public class Location
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string city { get; set; }
        public string country { get; set; }
    }

    public class Network
    {
        public string id { get; set; }
        public string name { get; set; }
        public Location location { get; set; }
        public string href { get; set; }
        public List<string> company { get; set; }
        public bool ebikes { get; set; }
        public List<Station> stations { get; set; }
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

}
