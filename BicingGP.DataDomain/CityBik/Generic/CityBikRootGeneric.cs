namespace BicingGP.DataDomain.CityBik.Generic
{
    public class CityBikRootGeneric
    {
        public Network network { get; set; }
    }

    public class Extra
    {
        public int ebikes { get; set; }
        public bool has_ebikes { get; set; }
        public int? normal_bikes { get; set; }
        public bool? online { get; set; }
        public string? uid { get; set; }
    }

    public class Location
    {
        public string? city { get; set; }
        public string? country { get; set; }
        public string? latitude { get; set; }
        public string? longitude { get; set; }
    }

    public class Network
    {
        public List<string>? company { get; set; }
        public bool ebikes { get; set; }
        public string? href { get; set; }
        public string? id { get; set; }
        public Location? location { get; set; }
        public string? name { get; set; }
        public List<Station>? stations { get; set; }
    }

   
    public class Station
    {
        public int empty_slots { get; set; }        
        public Extra? extra { get; set; }
        public int free_bikes { get; set; }
        public string? id { get; set; }
        public string? latitude { get; set; }
        public string? longitude { get; set; }
        public string? name { get; set; }
        public string? timestamp { get; set; }
    }
}
