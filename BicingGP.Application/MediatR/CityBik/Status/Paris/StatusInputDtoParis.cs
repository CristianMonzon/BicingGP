using BicingGP.Application.MediatR.CityBik.Station.Paris;
using BicingGP.Application.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Status.Paris
{
    public class StatusInputDtoParis : IRequest<IEnumerable<StatusOutputDtoParis>>
    {
        public IProviderGeneric<StationOutputDtoParis, StatusOutputDtoParis> ProviderGeneric { get; set; }

        public StatusInputDtoParis(IProviderGeneric<StationOutputDtoParis, StatusOutputDtoParis> provider)
        {
            ProviderGeneric = provider;
        }
    }
}
