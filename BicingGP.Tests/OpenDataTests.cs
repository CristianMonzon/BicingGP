using BicingGP.Application.Providers.OpenData;
using BicingGP.Application.Services.Station;
using BicingGP.Application.Services.Status;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace BicingGP.Tests
{

    public class OpenDataTests
    {
        private IHttpClientFactory httpClientFactory;
        private ProviderOpenData provider;

        [SetUp]
        public void Setup()
        {

            provider = new ProviderOpenData();
            provider.UrlGetStatus = "https://opendata-ajuntament.barcelona.cat/data/ca/dataset/estat-estacions-bicing/resource/1b215493-9e63-4a12-8980-2d7e0fa19f85/download/recurs.json";
            provider.UrlGetStation = "https://opendata-ajuntament.barcelona.cat/data/ca/dataset/estat-estacions-bicing/resource/f60e9291-5aaa-417d-9b91-612a9de800aa/download/recurs.json";
            provider.Token = "---Use your token here--";
            //Get your token in this page https://opendata-ajuntament.barcelona.cat/es/desenvolupadors

            var serviceProvider = new ServiceCollection()
            .AddHttpClient()
            .BuildServiceProvider();

            httpClientFactory = serviceProvider.GetRequiredService<IHttpClientFactory>();            
        }

        
        [Test]
        public void StatusService_GetStatus_MoreThanOne()
        {
            //Arrange
            Setup();            

            var statusServices = new OpenDataStatusServices(httpClientFactory, provider);

            //Act
            var stations = statusServices.GetStatus();

            while (!stations.IsCompleted) { 
            }

            //Assert
            var expected = stations.Result.Count();
            var result = (expected > 1);

            result.Should().Be(result, $"Total number of stations {expected}");
        }

        [Test]
        public void StatusService_GetStations_MoreThanOne()
        {
            //Arrange
            Setup();

            var stationServices = new OpenDataStationServices(httpClientFactory, provider);

            //Act
            var stations = stationServices.GetStations();

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