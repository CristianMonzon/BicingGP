namespace WebApiBicingGP.Manager
{
    public class DataProviderConfig 
    {
        public string StatusInformation { get; set; } =string.Empty;
        public string StationInformation { get; set; } = string.Empty;
        public string? Token { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }
}
