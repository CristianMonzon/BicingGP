namespace BicingGP.DataProvider.MiBiciTuBici.Station
{
    public class Data
    {
        public List<Station>? stations { get; set; }
    }

    public class MiBiciTuBiciRootStation
    {
        public int last_updated { get; set; }
        public int ttl { get; set; }
        public Data? data { get; set; }
    }

    public class Station
    {
        public string? station_id { get; set; }
        public string? name { get; set; }
        public string? lat { get; set; }
        public string? lon { get; set; }
        public string? address { get; set; }
        public List<string>? rental_methods { get; set; }
        public int? capacity { get; set; }
        public int? station_code { get; set; }
    }


}
