using BicingGP.Application.MediatR.CityBik.Status.Barcelona;
using BicingGP.DataProvider.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Station.Barcelona
{

    public class StationInputDtoBarcelona : IRequest<IEnumerable<StationOutputDtoBarcelona>>
    {
        public IProviderGeneric<StationOutputDtoBarcelona, StatusOutputDtoBarcelona> ProviderGeneric { get; set; }

        public StationInputDtoBarcelona(IProviderGeneric<StationOutputDtoBarcelona, StatusOutputDtoBarcelona> provider)
        {
            ProviderGeneric = provider;
        }
    }
}