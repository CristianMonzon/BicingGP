using BicingGP.Application.MediatR.CityBik.Station.Rosario;
using BicingGP.DataProvider.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Status.Rosario
{
    public class StatusInputDtoRosario : IRequest<IEnumerable<StatusOutputDtoRosario>>
    {
        public IProviderGeneric<StationOutputDtoRosario, StatusOutputDtoRosario> ProviderGeneric { get; set; }

        public StatusInputDtoRosario(IProviderGeneric<StationOutputDtoRosario, StatusOutputDtoRosario> provider)
        {
            ProviderGeneric = provider;
        }
    }
}
