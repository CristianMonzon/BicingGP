namespace BicingGP.DataProvider.MiBiciTuBici.Status
{

    public class Data
    {
        public List<Station>? stations { get; set; }
    }

    public class MiBiciTuBiciRootStatus
    {
        public int? last_updated { get; set; }
        public int? ttl { get; set; }
        public Data? data { get; set; }
    }

    public class Station
    {
        public string? station_id { get; set; }
        public int? num_bikes_available { get; set; }
        public int? num_bikes_disabled { get; set; }
        public int? num_docks_available { get; set; }
        public int? num_docks_disabled { get; set; }
        public int? is_installed { get; set; }
        public int? is_renting { get; set; }
        public int? is_returning { get; set; }
        public int? last_reported { get; set; }
    }
}
