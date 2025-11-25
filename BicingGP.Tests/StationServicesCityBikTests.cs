using BicingGP.Application.MediatR.CityBik.Station.Barcelona;
using BicingGP.Application.MediatR.CityBik.Station.Paris;
using BicingGP.Application.MediatR.CityBik.Station.Rosario;
using BicingGP.Application.MediatR.CityBik.Status.Barcelona;
using BicingGP.Application.MediatR.CityBik.Status.Paris;
using BicingGP.Application.MediatR.CityBik.Status.Rosario;
using BicingGP.Application.Providers.CityBik;
using BicingGP.Application.Providers.MiBiciTuBici;
using BicingGP.Application.Services;
using BicingGP.Application.Services.Station;
using BicingGP.DataProvider.Providers.CityBik;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace BicingGP.Tests
{
    public class StationServicesCityBikTests
    {
        private IHttpService httpService;
        private IHttpClientFactory httpClientFactory;

        [SetUp]
        public void Setup()
        {
            var serviceProvider = new ServiceCollection()
            .AddHttpClient()
            .BuildServiceProvider();

            httpClientFactory = serviceProvider.GetRequiredService<IHttpClientFactory>();
            httpService = new HttpService(httpClientFactory);
        }

        [Test]
        public void CityBikBarcelona_StationsService_MoreThanOne()
        {
            //Arrange
            Setup();
            var provider = new ProviderCityBikBarcelona()
            {
                UrlGetStation = "http://api.citybik.es/v2/networks/bicing"
            };
            
            var stationServices = new StationService<StationOutputDtoBarcelona,StatusOutputDtoBarcelona>(httpService, provider);

            //Act
            var stations = stationServices.Get();

            //Assert
            var expected = stations.Result.Count();
            var result = (expected > 1);

            result.Should().Be(result, $"Total number of stations {expected}");
        }

        [Test]
        public void CityBikRosario_StationsService_MoreThanOne()
        {
            //Arrange
            Setup();
            var provider = new ProviderCityBikRosario()
            {
                UrlGetStation= "http://api.citybik.es/v2/networks/mibicitubici"
            };

            var stationServices = new StationService<StationOutputDtoRosario, StatusOutputDtoRosario>(httpService, provider);

            //Act
            var stations = stationServices.Get();

            //Assert
            var expected = stations.Result.Count();
            var result = (expected > 1);

            result.Should().Be(result, $"Total number of stations {expected}");
        }


        [Test]
        public void CityBikParis_StationsService_MoreThanOne()
        {
            //Arrange
            Setup();
            var provider = new ProviderCityBikParis()
            {
                UrlGetStation = "http://api.citybik.es/v2/networks/velib"
            };

            var stationServices = new StationService<StationOutputDtoParis, StatusOutputDtoParis>(httpService, provider);

            //Act
            var stations = stationServices.Get();
            
            //Assert
            var expected = stations.Result.Count();
            var result = (expected > 1);

            result.Should().Be(result, $"Total number of stations {expected}");
        }



        [Test]
        public void CityBikMibiciTuBici_StationsService_MoreThanOne()
        {
            //Arrange
            Setup();
            var provider = new ProviderMiBiciTuBici()
            {
                UrlGetStation = "https://www.mibicitubici.gob.ar/opendata/station_information.json"
            };

            var stationServices = new StationService<BicingGP.Application.MediatR.MiBiciTuBici.Station.StationOutputDto,
                BicingGP.Application.MediatR.MiBiciTuBici.Status.StatusOutputDto>(httpService, provider);

            //Act
            var stations = stationServices.Get();

            //Assert
            var expected = stations.Result.Count();
            var result = (expected > 1);

            result.Should().Be(result, $"Total number of stations {expected}");
        }
    }
}