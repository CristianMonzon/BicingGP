using BicingGP.Application.MediatR.CityBik.Station.Barcelona;
using BicingGP.Application.MediatR.CityBik.Station.Paris;
using BicingGP.Application.MediatR.CityBik.Station.Rosario;
using BicingGP.Application.MediatR.CityBik.Status.Barcelona;
using BicingGP.Application.MediatR.CityBik.Status.Paris;
using BicingGP.Application.MediatR.CityBik.Status.Rosario;
using BicingGP.Application.Providers.CityBik;
using BicingGP.Application.Services.Station;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace BicingGP.Tests
{
    public class StationServicesCityBikTests
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
        public void CityBikBarcelona_StationsService_GetStatus_MoreThanOne()
        {
            //Arrange
            Setup();
            var provider = new ProviderCityBikBarcelona()
            {
                UrlGetStation = "http://api.citybik.es/v2/networks/bicing"
            };
            
            var stationServices = new StationService<StationOutDtoBarcelona,StatusOutputDtoBarcelona>(httpClientFactory, provider);

            //Act
            var stations = stationServices.Get();

            //Assert
            var expected = stations.Result.Count();
            var result = (expected > 1);

            result.Should().Be(result, $"Total number of stations {expected}");
        }

        [Test]
        public void CityBikRosario_StationsService_GetStatus_MoreThanOne()
        {
            //Arrange
            Setup();
            var provider = new ProviderCityBikRosario()
            {
                UrlGetStation= "http://api.citybik.es/v2/networks/mibicitubici"
            };

            var stationServices = new StationService<StationOutDtoRosario, StatusOutputDtoRosario>(httpClientFactory, provider);

            //Act
            var stations = stationServices.Get();

            //Assert
            var expected = stations.Result.Count();
            var result = (expected > 1);

            result.Should().Be(result, $"Total number of stations {expected}");
        }


        [Test]
        public void CityBikParis_StationsService_GetStatus_MoreThanOne()
        {
            //Arrange
            Setup();
            var provider = new ProviderCityBikParis()
            {
                UrlGetStation = "http://api.citybik.es/v2/networks/velib"
            };

            var stationServices = new StationService<StationOutDtoParis, StatusOutputDtoParis>(httpClientFactory, provider);

            //Act
            var stations = stationServices.Get();
            
            //Assert
            var expected = stations.Result.Count();
            var result = (expected > 1);

            result.Should().Be(result, $"Total number of stations {expected}");
        }
    }
}