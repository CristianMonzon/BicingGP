
using BicingGP.Application.MediatR.CityBik.Status.Paris;
using BicingGP.Application.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Station.Paris
{
        
    public class StationInputDtoParis : IRequest<IEnumerable<StationOutputDtoParis>>
    {       
        public IProviderGeneric<StationOutputDtoParis, StatusOutputDtoParis> ProviderGeneric{ get; set; }

        public StationInputDtoParis(IProviderGeneric<StationOutputDtoParis, StatusOutputDtoParis> provider)
        {
            ProviderGeneric = provider;
        }
    }
}