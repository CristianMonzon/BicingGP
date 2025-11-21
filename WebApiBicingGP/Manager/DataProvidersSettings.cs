using BicingGP.Application.MediatR.CityBik.Station.Barcelona;
using BicingGP.Application.MediatR.CityBik.Station.Paris;
using BicingGP.Application.MediatR.CityBik.Station.Rosario;
using BicingGP.Application.MediatR.CityBik.Status.Barcelona;
using BicingGP.Application.MediatR.CityBik.Status.Paris;
using BicingGP.Application.MediatR.CityBik.Status.Rosario;
using BicingGP.Application.MediatR.MiBiciTuBici.Station;
using BicingGP.Application.MediatR.MiBiciTuBici.Status;
using BicingGP.Application.Providers.CityBik;
using BicingGP.Application.Providers.MiBiciTuBici;
using BicingGP.Application.Providers.OpenData;
using BicingGP.DataProvider.Providers;
using BicingGP.DataProvider.Providers.CityBik;

namespace WebApiBicingGP.Manager
{
    public class DataProvidersSettings
    {
        private readonly IConfiguration _configuration;
        private readonly IDataProviderFactory _dataProviderFactory;

        public ProviderOpenData ProviderOpenDataBarcelona { get; private set; }

        public IProviderGeneric<StationOutputDtoBarcelona, StatusOutputDtoBarcelona> ProviderCityBikBarcelona { get; private set; }

        public IProviderGeneric<StationOutputDtoRosario, StatusOutputDtoRosario> ProviderCityBikRosario { get; private set; }

        public IProviderGeneric<StationOutputDtoParis, StatusOutputDtoParis> ProviderCityBikParis { get; private set; }

        public IProviderGeneric<StationOutputDto, StatusOutputDto> ProviderMiBiciTuBici { get; private set; }

        public DataProvidersSettings(IConfiguration configuration, IDataProviderFactory factory)
        {
            _configuration = configuration;
            _dataProviderFactory = factory;

            ProviderOpenDataBarcelona = CreateProvider<ProviderOpenData>("OpenDataBarcelona");
            ProviderCityBikBarcelona = CreateProvider<ProviderCityBikBarcelona>("CityBikBarcelona");
            ProviderCityBikRosario = CreateProvider<ProviderCityBikRosario>("CityBikRosario");
            ProviderCityBikParis = CreateProvider<ProviderCityBikParis>("CityBikVelib");
            ProviderMiBiciTuBici = CreateProvider<ProviderMiBiciTuBici>("MiBiciTuBici");

        }
        private T CreateProvider<T>(string sectionName) where T : class, new()
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

            if (_configuration[$"BikingProviders:{sectionName}:Token"] != null)
            {
                config.Token = _configuration[$"BikingProviders:{sectionName}:Token"];
            }
            return config;
        }
    }
}