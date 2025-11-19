using BicingGP.Application.MediatR.CityBik.Station.Rosario;
using BicingGP.Application.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Status.Rosario
{
    public class StatusInputDtoRosario : IRequest<IEnumerable<StatusOutputDtoRosario>>
    {
        public IProviderGeneric<StationOutDtoRosario, StatusOutputDtoRosario> ProviderGeneric { get; set; }

        public StatusInputDtoRosario(IProviderGeneric<StationOutDtoRosario, StatusOutputDtoRosario> provider)
        {
            ProviderGeneric = provider;
        }
    }
}
