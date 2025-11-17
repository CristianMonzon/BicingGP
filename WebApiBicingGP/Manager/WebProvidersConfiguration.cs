using BicingGPApplication.Entities;
using System.Security.Principal;
using static WebApiBicingGP.Manager.WebProviderFactory;

namespace WebApiBicingGP.Manager
{
    public class WebProviderConfig 
    {
        public string StatusInformation { get; set; } =string.Empty;
        public string StationInformation { get; set; } = string.Empty;
        public string? Token { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }

    public class WebProvidersConfiguration
    {
        public WebProviderConfig OpenDataBarcelona { get; set; } = new();
        public WebProviderConfig CityBikBarcelona { get; set; } = new();
        public WebProviderConfig CityBikRosario { get; set; } = new();
        public WebProviderConfig CityBikVelib { get; set; } = new();
    }
}
