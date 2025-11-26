using BicingGP.DataProvider.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.Velib.Station
{
    public class StationInputDtoVelib : IRequest<IEnumerable<StationOutputDtoVelib>>
    {
        public IProviderGeneric<StationOutputDtoVelib, Status.StatusOutputDtoVelib> ProviderGeneric { get; set; }

        public StationInputDtoVelib(IProviderGeneric<StationOutputDtoVelib, Status.StatusOutputDtoVelib> provider)
        {
            ProviderGeneric = provider;
        }
    }
}