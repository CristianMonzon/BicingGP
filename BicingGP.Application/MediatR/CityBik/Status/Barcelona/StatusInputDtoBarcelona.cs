using BicingGP.Application.MediatR.CityBik.Station.Barcelona;
using BicingGP.Application.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Status.Barcelona
{
    public class StatusInputDtoBarcelona : IRequest<IEnumerable<StatusOutputDtoBarcelona>>
    {
        public IProviderGeneric<StationOutDtoBarcelona, StatusOutputDtoBarcelona> ProviderGeneric { get; set; }

        public StatusInputDtoBarcelona(IProviderGeneric<StationOutDtoBarcelona, StatusOutputDtoBarcelona> provider)
        {
            ProviderGeneric = provider;
        }
    }
}
