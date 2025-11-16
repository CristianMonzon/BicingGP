using BicingGPApplication.Entities;
using MediatR;

namespace BicingGPApplication.MediatR.CityBik.Station.Barcelona
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