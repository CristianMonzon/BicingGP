namespace BicingGP.DataProvider.Velib.Status
{
    /// <summary>
    /// Represents the root object containing information about a Vélib station, including metadata and status data.
    /// </summary>
    /// <remarks>Last update 26.11.2025</remarks>
    public class VelibRootStatus
    {
        public int? lastUpdatedOther { get; set; }
        public int? ttl { get; set; }
        public Data? data { get; set; }
    }

    public class Data
    {
        public List<Station>? stations { get; set; }
    }

    public class NumBikesAvailableType
    {
        public int? mechanical { get; set; }
        public int? ebike { get; set; }
    }
    
    public class Station
    {
        public string? station_id { get; set; }
        public int? num_bikes_available { get; set; }
        public int? numBikesAvailable { get; set; }
        public List<NumBikesAvailableType>? num_bikes_available_types { get; set; }
        public int? num_docks_available { get; set; }
        public int? numDocksAvailable { get; set; }
        public int? is_installed { get; set; }
        public int? is_returning { get; set; }
        public int? is_renting { get; set; }
        public int? last_reported { get; set; }
        public string? stationCode { get; set; }
        public List<string>? rental_methods { get; set; }
        /// <summary>
        /// TODO. Not implemented yet.
        /// </summary>        
        //public object station_opening_hours { get; set; }
    }
}