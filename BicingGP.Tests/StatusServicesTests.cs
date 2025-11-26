using BicingGP.Application.MediatR.CityBik.Station.Barcelona;
using BicingGP.Application.MediatR.CityBik.Station.Paris;
using BicingGP.Application.MediatR.CityBik.Station.Rosario;
using BicingGP.Application.MediatR.CityBik.Status.Barcelona;
using BicingGP.Application.MediatR.CityBik.Status.Paris;
using BicingGP.Application.MediatR.CityBik.Status.Rosario;
using BicingGP.Application.Providers.CityBik;
using BicingGP.Application.Providers.MiBiciTuBici;
using BicingGP.Application.Providers.Velib;
using BicingGP.Application.Services;
using BicingGP.Application.Services.Status;
using BicingGP.DataProvider.Providers.CityBik;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace BicingGP.Tests
{
    public class StatusServicesTests
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
        public void CityBikBarcelona_StatusService_GetStatus_MoreThanOne()
        {
            //Arrange
            Setup();
            var provider = new ProviderCityBikBarcelona()
            {
                UrlGetStatus = "http://api.citybik.es/v2/networks/bicing"
            };
            
            var statusServices = new StatusService<StationOutputDtoBarcelona,StatusOutputDtoBarcelona>(httpService, provider);

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

            var statusServices = new StatusService<StationOutputDtoRosario, StatusOutputDtoRosario>(httpService, provider);

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

            var statusServices = new StatusService<StationOutputDtoParis, StatusOutputDtoParis>(httpService, provider);

            //Act
            var stations = statusServices.Get();
            
            //Assert
            var expected = stations.Result.Count();
            var result = (expected > 1);

            result.Should().Be(result, $"Total number of stations {expected}");
        }

        [Test]
        public void MiBiciTuBici_StatusService_GetStatus_MoreThanOne()
        {
            //Arrange
            Setup();
            var provider = new ProviderMiBiciTuBici()
            {
                UrlGetStatus = "https://www.mibicitubici.gob.ar/opendata/station_status.json"
            };
                
            var statusServices = new StatusService<BicingGP.Application.MediatR.MiBiciTuBici.Station.StationOutputDtoMiBiciTuBici
                , BicingGP.Application.MediatR.MiBiciTuBici.Status.StatusOutputDtoMiBiciTuBici>(httpService, provider);

            //Act
            var stations = statusServices.Get();

            //Assert
            var expected = stations.Result.Count();
            var result = (expected > 1);

            result.Should().Be(result, $"Total number of stations {expected}");
        }

        [Test]
        public void Velib_StatusService_GetStatus_MoreThanOne()
        {
            //Arrange
            Setup();
            var provider = new ProviderVelib()
            {
                UrlGetStatus = "https://velib-metropole-opendata.smovengo.cloud/opendata/Velib_Metropole/station_status.json"
            };

            var statusServices = new StatusService<BicingGP.Application.MediatR.Velib.Station.StationOutputDtoVelib
                , BicingGP.Application.MediatR.Velib.Status.StatusOutputDtoVelib>(httpService, provider);

            //Act
            var stations = statusServices.Get();

            //Assert
            var expected = stations.Result.Count();
            var result = (expected > 1);

            result.Should().Be(result, $"Total number of stations {expected}");
        }
    }
}