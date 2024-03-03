using BicingGPApplication.Entities;

namespace WebApiBicingGP.Manager
{
    public class AppSettings
    {
        private readonly IConfiguration _configuration;
        
        public ProviderOpenData ProviderOpenDataBarcelona
        {
            get
            {
                var provider = new ProviderOpenData()
                {
                    UrlGetStatus = _configuration?["OpenDataBarcelona:StatusInformation"],
                    UrlGetStation = _configuration?["OpenDataBarcelona:StationInformation"],
                    Token = _configuration?["OpenDataBarcelona:Token"],

                };
                return provider;
            }
        }

        public IProvider ProviderCityBarcelona
        {
            get
            {
                return new ProviderCityBikBarcelona()
                {
                    UrlGetStatus = _configuration?["CityBikBarcelona:StatusInformation"],
                    UrlGetStation = _configuration?["CityBikBarcelona:StationInformation"],                    
                };

            }
        }

        public IProvider ProviderCityBikRosario
        {
            get
            {
                return new ProviderCityBikRosario()
                {
                    UrlGetStatus = _configuration?["CityBikRosario:StatusInformation"],
                    UrlGetStation = _configuration?["CityBikRosario:StationInformation"],                    
                };
            }
        }

        public IProvider ProviderCityBikParis
        {
            get
            {
                return new ProviderCityBikParis()
                {
                    UrlGetStatus = _configuration?["CityBikVelib:StatusInformation"],
                    UrlGetStation = _configuration?["CityBikVelib:StationInformation"],                    
                };
            }
        }



        public AppSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}

