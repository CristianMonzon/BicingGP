using BicingGPApplication.Providers;
using MediatR;

namespace BicingGPApplication.MediatR.CityBik.Station.Rosario
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