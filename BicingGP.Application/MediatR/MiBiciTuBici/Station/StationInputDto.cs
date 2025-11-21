using BicingGP.Application.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.MiBiciTuBici.Station;


public class StationInputDto : IRequest<IEnumerable<StationOutputDto>>
{
    public IProviderGeneric<StationOutputDto, Status.StatusOutputDto> ProviderGeneric { get; set; }

    public StationInputDto(IProviderGeneric<StationOutputDto, Status.StatusOutputDto> provider)
    {
        ProviderGeneric = provider;
    }
}