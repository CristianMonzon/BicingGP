using BicingGP.Application.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Station.Rosario
{

    public class StationInputDTORosario : IRequest<List<StationOutDTORosario>>
    {
        public IProviderGeneric<StationOutDTORosario> ProviderGeneric { get; set; }

        public StationInputDTORosario(IProviderGeneric<StationOutDTORosario> provider)
        {
            ProviderGeneric = provider;
        }
    }
}