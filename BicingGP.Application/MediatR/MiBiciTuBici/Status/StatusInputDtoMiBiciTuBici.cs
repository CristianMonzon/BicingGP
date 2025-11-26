using BicingGP.DataProvider.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.MiBiciTuBici.Status;

public class StatusInputDtoMiBiciTuBici : IRequest<IEnumerable<StatusOutputDtoMiBiciTuBici>>
{
    public IProviderGeneric<Station.StationOutputDtoMiBiciTuBici, StatusOutputDtoMiBiciTuBici> ProviderGeneric { get; set; }

    public StatusInputDtoMiBiciTuBici(IProviderGeneric<Station.StationOutputDtoMiBiciTuBici, StatusOutputDtoMiBiciTuBici> provider)
    {
        ProviderGeneric = provider;
    }
}