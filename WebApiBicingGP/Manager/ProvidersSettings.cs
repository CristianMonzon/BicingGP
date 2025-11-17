using BicingGPApplication.Entities.CityBik;
using BicingGPApplication.Entities.OpenData;

namespace WebApiBicingGP.Manager
{
    public class ProvidersSettings
    {
        private readonly IConfiguration _configuration;
        private readonly IWebProviderFactory _factory;

        public ProviderOpenData ProviderFactoryOpenDataBarcelona { get; set; } = new ProviderOpenData();

        public ProviderCityBikBarcelona ProviderCityBikBarcelona { get; set; } = new ProviderCityBikBarcelona();
        public ProviderCityBikParis ProviderCityBikParis { get; set; } = new ProviderCityBikParis();
        public ProviderCityBikRosario ProviderCityBikRosario { get; set; } = new ProviderCityBikRosario();

        public ProviderCityBikBarcelonaGenerico ProviderCityBikBarcelonaGenerico { get; set; } = new ProviderCityBikBarcelonaGenerico();
        public ProviderCityBikRosarioGenerico ProviderCityBikRosarioGenerico { get; set; } = new ProviderCityBikRosarioGenerico();
        public ProviderCityBikParisGenerico ProviderCityBikParisGenerico { get; set; } = new ProviderCityBikParisGenerico();

        public ProvidersSettings(IConfiguration configuration, IWebProviderFactory factory)
        {
            _configuration = configuration;
            _factory = factory;

            var openDataConfig = new WebProviderConfig
            {
                StatusInformation = _configuration["OpenDataBarcelona:StatusInformation"],
                StationInformation = _configuration["OpenDataBarcelona:StationInformation"],
                Token = _configuration["OpenDataBarcelona:Token"]
            };

            var cityBikBarcelonaConfig = new WebProviderConfig
            {
                StatusInformation = _configuration["CityBikBarcelona:StatusInformation"],
                StationInformation = _configuration["CityBikBarcelona:StationInformation"]
            };

            var cityBikRosarioConfig = new WebProviderConfig
            {
                StatusInformation = _configuration["CityBikRosario:StatusInformation"],
                StationInformation = _configuration["CityBikRosario:StationInformation"]
            };

            var cityBikVelibConfig = new WebProviderConfig
            {
                StatusInformation = _configuration["CityBikVelib:StatusInformation"],
                StationInformation = _configuration["CityBikVelib:StationInformation"]
            };

            ProviderFactoryOpenDataBarcelona = _factory.CreateProvider<ProviderOpenData>(openDataConfig);
            
            ProviderCityBikBarcelona = _factory.CreateProvider<ProviderCityBikBarcelona>(cityBikBarcelonaConfig);
            ProviderCityBikParis = _factory.CreateProvider<ProviderCityBikParis>(cityBikVelibConfig);
            ProviderCityBikRosario = _factory.CreateProvider<ProviderCityBikRosario>(cityBikRosarioConfig);
            
            ProviderCityBikBarcelonaGenerico = _factory.CreateProvider<ProviderCityBikBarcelonaGenerico>(cityBikBarcelonaConfig);
            ProviderCityBikParisGenerico = _factory.CreateProvider<ProviderCityBikParisGenerico>(cityBikVelibConfig);
            ProviderCityBikRosarioGenerico = _factory.CreateProvider<ProviderCityBikRosarioGenerico>(cityBikRosarioConfig);
        }
    }
}