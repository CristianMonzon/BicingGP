using BicingGP.Application.MediatR.CityBik.Station.Barcelona;
using BicingGP.Application.MediatR.CityBik.Station.Paris;
using BicingGP.Application.MediatR.CityBik.Station.Rosario;
using BicingGP.Application.MediatR.CityBik.Status.Barcelona;
using BicingGP.Application.MediatR.CityBik.Status.Paris;
using BicingGP.Application.MediatR.CityBik.Status.Rosario;
using BicingGP.Application.Providers.CityBik;
using BicingGP.Application.Services.Status;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace BicingGP.Tests
{
    public class StatusServicesCityBikTests
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
            var provider = new ProviderCityBikBarcelona()
            {
                UrlGetStatus = "http://api.citybik.es/v2/networks/bicing"
            };
            
            var statusServices = new StatusService<StationOutDtoBarcelona,StatusOutputDtoBarcelona>(httpClientFactory, provider);

            //Act
            var stations = statusServices.Get();

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
            var provider = new ProviderCityBikRosario()
            {
                UrlGetStatus = "http://api.citybik.es/v2/networks/mibicitubici"
            };

            var statusServices = new StatusService<StationOutDtoRosario, StatusOutputDtoRosario>(httpClientFactory, provider);

            //Act
            var stations = statusServices.Get();

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
            var provider = new ProviderCityBikParis()
            {
                UrlGetStatus = "http://api.citybik.es/v2/networks/velib"
            };

            var statusServices = new StatusService<StationOutDtoParis, StatusOutputDtoParis>(httpClientFactory, provider);

            //Act
            var stations = statusServices.Get();
            
            //Assert
            var expected = stations.Result.Count();
            var result = (expected > 1);

            result.Should().Be(result, $"Total number of stations {expected}");
        }
    }
}