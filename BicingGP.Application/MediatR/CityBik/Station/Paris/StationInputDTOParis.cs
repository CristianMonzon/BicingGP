using BicingGP.Application.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Station.Paris
{
        
    public class StationInputDTOParis : IRequest<List<StationOutDTOParis>>
    {       
        public IProviderGeneric<StationOutDTOParis> ProviderGeneric{ get; set; }

        public StationInputDTOParis(IProviderGeneric<StationOutDTOParis> provider)
        {
            ProviderGeneric = provider;
        }
    }
}