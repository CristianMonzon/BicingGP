using BicingGP.Application.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Station.Barcelona
{

    public class StationInputDTOBarcelona : IRequest<List<StationOutDTOBarcelona>>
    {
        public IProviderGeneric<StationOutDTOBarcelona> ProviderGeneric { get; set; }

        public StationInputDTOBarcelona(IProviderGeneric<StationOutDTOBarcelona> provider)
        {
            ProviderGeneric = provider;
        }
    }
}