
using BicingGP.Application.MediatR.CityBik.Status.Paris;
using BicingGP.Application.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Station.Paris
{
        
    public class StationInputDtoParis : IRequest<IEnumerable<StationOutDtoParis>>
    {       
        public IProviderGeneric<StationOutDtoParis, StatusOutputDtoParis> ProviderGeneric{ get; set; }

        public StationInputDtoParis(IProviderGeneric<StationOutDtoParis, StatusOutputDtoParis> provider)
        {
            ProviderGeneric = provider;
        }
    }
}