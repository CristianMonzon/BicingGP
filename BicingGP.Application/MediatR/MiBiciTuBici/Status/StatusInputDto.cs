using BicingGP.DataProvider.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.MiBiciTuBici.Status;

public class StatusInputDto : IRequest<IEnumerable<StatusOutputDto>>
{
    public IProviderGeneric<Station.StationOutputDto, StatusOutputDto> ProviderGeneric { get; set; }

    public StatusInputDto(IProviderGeneric<Station.StationOutputDto, StatusOutputDto> provider)
    {
        ProviderGeneric = provider;
    }
}