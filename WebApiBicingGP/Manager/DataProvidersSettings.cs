using BicingGP.Application.Providers.CityBik;
using BicingGP.Application.Providers.OpenData;

namespace WebApiBicingGP.Manager
{
    public class DataProvidersSettings
    {
        private readonly IConfiguration _configuration;
        private readonly IDataProviderFactory _dataProviderFactory;

        public ProviderOpenData ProviderOpenDataBarcelona { get; private set; } 

        //public ProviderCityBikBarcelona ProviderCityBikBarcelona { get; private set; } 
        //public ProviderCityBikParis ProviderCityBikParis { get; private set; } 
        //public ProviderCityBikRosario ProviderCityBikRosario { get; private set; } 

        public ProviderCityBikBarcelona ProviderCityBikBarcelonaGenerico { get; private set; } 
        public ProviderCityBikRosario ProviderCityBikRosarioGenerico { get; private set; } 
        public ProviderCityBikParis ProviderCityBikParisGenerico { get; private set; } 

        public DataProvidersSettings(IConfiguration configuration, IDataProviderFactory factory)
        {
            _configuration = configuration;
            _dataProviderFactory = factory;
            
            ProviderOpenDataBarcelona = CreateProvider<ProviderOpenData>("OpenDataBarcelona");
            
            //ProviderCityBikBarcelona = CreateProvider<ProviderCityBikBarcelona>("CityBikBarcelona");
            ProviderCityBikBarcelonaGenerico = CreateProvider<ProviderCityBikBarcelona>("CityBikBarcelona");
            
            ProviderCityBikRosarioGenerico = CreateProvider<ProviderCityBikRosario>("CityBikRosario");
            //ProviderCityBikRosario = CreateProvider<ProviderCityBikRosario>("CityBikRosario");
            
            //ProviderCityBikParis = CreateProvider<ProviderCityBikParis>("CityBikVelib");
            ProviderCityBikParisGenerico = CreateProvider<ProviderCityBikParis>("CityBikVelib");
        }

        private T CreateProvider<T>(string sectionName) where T : class, new ()
        {
            var dataProviderConfig = CreateConfig(sectionName);
            return _dataProviderFactory.CreateProvider<T>(dataProviderConfig);
        }

        private DataProviderConfig CreateConfig(string sectionName)
        {
            var config = new DataProviderConfig
            {
                StatusInformation = _configuration[$"BikingProviders:{sectionName}:StatusInformation"],
                StationInformation = _configuration[$"BikingProviders:{sectionName}:StationInformation"]
            };

            if (_configuration[$"BikingProviders:{sectionName}:Token"]!=null)
            {
                config.Token = _configuration[$"BikingProviders:{sectionName}:Token"];
            }
            return config;
        }
    }
}