using BicingGP.Application.MediatR.CityBik.Station.Paris;
using BicingGP.Application.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Status.Paris
{
    public class StatusInputDtoParis : IRequest<IEnumerable<StatusOutputDtoParis>>
    {
        public IProviderGeneric<StationOutDtoParis, StatusOutputDtoParis> ProviderGeneric { get; set; }

        public StatusInputDtoParis(IProviderGeneric<StationOutDtoParis, StatusOutputDtoParis> provider)
        {
            ProviderGeneric = provider;
        }
    }
}
