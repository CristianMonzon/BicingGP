using BicingGP.Application.MediatR.CityBik.Station.Barcelona;
using BicingGP.Application.MediatR.CityBik.Status.Barcelona;
using BicingGP.DataProvider.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Summary
{
    public class StationBarcelonaRequest : IRequest<IEnumerable<StationBarcelonaResponse>>
    {
        public IProviderGeneric<StationOutputDtoBarcelona, StatusOutputDtoBarcelona> ProviderGeneric { get; set; }

        public StationBarcelonaRequest(IProviderGeneric<StationOutputDtoBarcelona, StatusOutputDtoBarcelona> provider)
        {
            ProviderGeneric = provider;
        }
    }
}