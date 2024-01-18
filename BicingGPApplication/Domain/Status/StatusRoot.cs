namespace BicingGPApplication.Domain.StatusJson
{

    public class StatusRoot
    {
        public int last_updated { get; set; }
        public int ttl { get; set; }
        public DataStatus data { get; set; }
    }


    public class DataStatus
    {
        public List<StatusStation> stations { get; set; }
    }

    public class NumBikesAvailableTypes
    {
        public int mechanical { get; set; }
        public int ebike { get; set; }
    }

        public class StatusStation
    {
        public int station_id { get; set; }
        public int num_bikes_available { get; set; }
        public NumBikesAvailableTypes num_bikes_available_types { get; set; }
        public int num_docks_available { get; set; }
        public int last_reported { get; set; }
        public bool is_charging_station { get; set; }
        public string status { get; set; }
        public int is_installed { get; set; }
        public int is_renting { get; set; }
        public int is_returning { get; set; }
        public object traffic { get; set; }
    }

}