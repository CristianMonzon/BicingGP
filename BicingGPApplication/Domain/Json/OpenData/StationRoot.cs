namespace BicingGPApplication.Domain.Json.OpenDataStation
{
    public class OpenData
    {
        public int last_updated { get; set; }
        public int ttl { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public List<Station> stations { get; set; }
    }

    public class Station
    {
        public int station_id { get; set; }
        public string name { get; set; }
        public string physical_configuration { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public double altitude { get; set; }
        public string address { get; set; }
        public string post_code { get; set; }
        public int capacity { get; set; }
        public bool is_charging_station { get; set; }
        public double nearby_distance { get; set; }
        public bool _ride_code_support { get; set; }
        public object rental_uris { get; set; }
    }

}