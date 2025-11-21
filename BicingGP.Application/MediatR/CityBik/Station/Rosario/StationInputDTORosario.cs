using BicingGP.Application.MediatR.CityBik.Status.Rosario;
using BicingGP.Application.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Station.Rosario
{

    public class StationInputDtoRosario : IRequest<IEnumerable<StationOutputDtoRosario>>
    {
        public IProviderGeneric<StationOutputDtoRosario, StatusOutputDtoRosario> ProviderGeneric { get; set; }

        public StationInputDtoRosario(IProviderGeneric<StationOutputDtoRosario, StatusOutputDtoRosario> provider)
        {
            ProviderGeneric = provider;
        }
    }
}