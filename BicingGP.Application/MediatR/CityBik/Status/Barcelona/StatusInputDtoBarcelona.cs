using BicingGP.Application.MediatR.CityBik.Station.Barcelona;
using BicingGP.DataProvider.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Status.Barcelona
{
    public class StatusInputDtoBarcelona : IRequest<IEnumerable<StatusOutputDtoBarcelona>>
    {
        public IProviderGeneric<StationOutputDtoBarcelona, StatusOutputDtoBarcelona> ProviderGeneric { get; set; }

        public StatusInputDtoBarcelona(IProviderGeneric<StationOutputDtoBarcelona, StatusOutputDtoBarcelona> provider)
        {
            ProviderGeneric = provider;
        }
    }
}
