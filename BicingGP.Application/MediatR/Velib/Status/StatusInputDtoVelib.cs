using BicingGP.DataProvider.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.Velib.Status;

public class StatusInputDtoVelib : IRequest<IEnumerable<StatusOutputDtoVelib>>
{
    public IProviderGeneric<Station.StationOutputDtoVelib, StatusOutputDtoVelib> ProviderGeneric { get; set; }

    public StatusInputDtoVelib(IProviderGeneric<Station.StationOutputDtoVelib, StatusOutputDtoVelib> provider)
    {
        ProviderGeneric = provider;
    }
}