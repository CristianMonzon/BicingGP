using BicingGPApplication.Entities;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;

namespace BicingGPTests
{
    public class StatusSservicesCityBikTests
    {
        private IHttpClientFactory httpClientFactory;

        [SetUp]
        public void Setup()
        {
            var serviceProvider = new ServiceCollection()
            .AddHttpClient()
            .BuildServiceProvider();

            httpClientFactory = serviceProvider.GetRequiredService<IHttpClientFactory>();
        }

        [Test]
        public void CityBikBarcelona_StatusService_GetStatus_MoreThanOne()
        {
            //Arrange
            Setup();
            IProvider provider = new ProviderCityBikBarcelona()
            {
                UrlGetStatus = "http://api.citybik.es/v2/networks/bicing"
            };
            
            var statusServices = new StatusServices(httpClientFactory, provider);

            //Act
            var stations = statusServices.GetStatus();

            while (!stations.IsCompleted)
            {
            }

            //Assert
            var expected = stations.Result.Count();
            var result = (expected > 1);

            result.Should().Be(result, $"Total number of stations {expected}");
        }

        [Test]
        public void CityBikRosario_StatusService_GetStatus_MoreThanOne()
        {
            //Arrange
            Setup();
            IProvider provider = new ProviderCityBikRosario()
            {
                UrlGetStatus = "http://api.citybik.es/v2/networks/mibicitubici"
            };

            var statusServices = new StatusServices(httpClientFactory, provider);

            //Act
            var stations = statusServices.GetStatus();

            while (!stations.IsCompleted)
            {
            }

            //Assert
            var expected = stations.Result.Count();
            var result = (expected > 1);

            result.Should().Be(result, $"Total number of stations {expected}");
        }


        [Test]
        public void CityBikParis_StatusService_GetStatus_MoreThanOne()
        {
            //Arrange
            Setup();
            IProvider provider = new ProviderCityBikParisGenerico()
            {
                UrlGetStatus = "http://api.citybik.es/v2/networks/velib"
            };

            var statusServices = new StatusServices(httpClientFactory, provider);

            //Act
            var stations = statusServices.GetStatus();

            while (!stations.IsCompleted)
            {
            }

            //Assert
            var expected = stations.Result.Count();
            var result = (expected > 1);

            result.Should().Be(result, $"Total number of stations {expected}");
        }
    }
}