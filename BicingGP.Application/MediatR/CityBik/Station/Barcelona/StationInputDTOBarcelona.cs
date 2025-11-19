using BicingGP.Application.MediatR.CityBik.Status.Barcelona;
using BicingGP.Application.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Station.Barcelona
{

    public class StationInputDtoBarcelona : IRequest<IEnumerable<StationOutDtoBarcelona>>
    {
        public IProviderGeneric<StationOutDtoBarcelona, StatusOutputDtoBarcelona> ProviderGeneric { get; set; }

        public StationInputDtoBarcelona(IProviderGeneric<StationOutDtoBarcelona, StatusOutputDtoBarcelona> provider)
        {
            ProviderGeneric = provider;
        }
    }
}