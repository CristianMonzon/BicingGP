namespace BicingGP.DataProvider.Velib.Station
{
    /// <summary>
    /// Represents the root object containing information about a Vélib station, including metadata and station data.
    /// </summary>
    /// <remarks>Last update 26.11.2025</remarks>
    public class VelibRootStation
    {
        public int? lastUpdatedOther { get; set; }
        public int? ttl { get; set; }
        public Data? data { get; set; }
    }

    public class Data
    {
        public List<Station>? stations { get; set; }
    }

    public class Station
    {
        public string? station_id { get; set; }
        public string? stationCode { get; set; }
        public string? name { get; set; }
        public string? lat { get; set; }
        public string? lon { get; set; }
        public int? capacity { get; set; }

        /// <summary>
        /// TODO. Not implemented yet.
        /// </summary>
        //public object station_opening_hours { get; set; }
        public List<string>? rental_methods { get; set; }
    }
}