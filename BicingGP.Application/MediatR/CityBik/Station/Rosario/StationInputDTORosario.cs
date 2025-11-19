using BicingGP.Application.MediatR.CityBik.Status.Rosario;
using BicingGP.Application.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Station.Rosario
{

    public class StationInputDtoRosario : IRequest<IEnumerable<StationOutDtoRosario>>
    {
        public IProviderGeneric<StationOutDtoRosario, StatusOutputDtoRosario> ProviderGeneric { get; set; }

        public StationInputDtoRosario(IProviderGeneric<StationOutDtoRosario, StatusOutputDtoRosario> provider)
        {
            ProviderGeneric = provider;
        }
    }
}