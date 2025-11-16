using BicingGPApplication.Entities;
using System.Security.Principal;
using static WebApiBicingGP.Manager.ProviderFactory;

namespace WebApiBicingGP.Manager
{
    public class ProviderConfig 
    {
        public string? StatusInformation { get; set; }
        public string? StationInformation { get; set; }
        public string? Token { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }

    public class AppProvidersConfiguration
    {
        public ProviderConfig OpenDataBarcelona { get; set; } = new();
        public ProviderConfig CityBikBarcelona { get; set; } = new();
        public ProviderConfig CityBikRosario { get; set; } = new();
        public ProviderConfig CityBikVelib { get; set; } = new();
    }
}
