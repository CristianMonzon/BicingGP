using BicingGP.Application.MediatR.CityBik.Station.Rosario;
using BicingGP.Application.MediatR.CityBik.Status.Rosario;
using BicingGP.DataProvider.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Summary
{
    public class StationRosarioRequest : IRequest<IEnumerable<StationRosarioResponse>>
    {
        public IProviderGeneric<StationOutputDtoRosario, StatusOutputDtoRosario> ProviderGeneric { get; set; }

        public StationRosarioRequest(IProviderGeneric<StationOutputDtoRosario, StatusOutputDtoRosario> provider)
        {
            ProviderGeneric = provider;
        }
    }
}