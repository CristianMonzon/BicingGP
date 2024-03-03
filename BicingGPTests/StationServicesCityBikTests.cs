using BicingGPApplication.Entities;
using BicingGPApplication.Services;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;

namespace BicingGPTests
{
    public class StationServicesCityBikTests
    {
        private IHttpClientFactory _httpClientFactory;

        [SetUp]
        public void Setup()
        {
            var serviceProvider = new ServiceCollection()
            .AddHttpClient()
            .BuildServiceProvider();

            _httpClientFactory = serviceProvider.GetRequiredService<IHttpClientFactory>();
        }

        [Test]
        public void CityBikBarcelona_GetStations_MoreThanOne()
        {
            //Arrange
            var provider = new ProviderCityBikBarcelona()
            {
                UrlGetStation = "http://api.citybik.es/v2/networks/bicing",
            };

            Setup();            
            var stationServices = new StationServices(_httpClientFactory, provider);

            //Act
            var stations = stationServices.GetStations();

            //Assert
            var expected = stations.Result.Count();
            var result = (expected > 1);

            result.Should().Be(result, $"Total number of stations {expected}");
        }

        [Test]
        public void CityBikRosario_GetStations_MoreThanOne()
        {
            //Arrange
            var provider = new ProviderCityBikRosario()
            {
                UrlGetStation = "http://api.citybik.es/v2/networks/mibicitubici",
            };

            Setup();
            var stationServices = new StationServices(_httpClientFactory, provider);

            //Act
            var stations = stationServices.GetStations();

            //Assert
            var expected = stations.Result.Count();
            var result = (expected > 1);

            result.Should().Be(result, $"Total number of stations {expected}");
        }

        [Test]
        public void CityBikParis_GetStations_MoreThanOne()
        {
            //Arrange
            var provider = new ProviderCityBikParis()
            {
                UrlGetStation = "http://api.citybik.es/v2/networks/velib",
            };

            Setup();
            var stationServices = new StationServices(_httpClientFactory, provider);

            //Act
            var stations = stationServices.GetStations();

            //Assert
            var expected = stations.Result.Count();
            var result = (expected > 1);

            result.Should().Be(result, $"Total number of stations {expected}");
        }
    }
}