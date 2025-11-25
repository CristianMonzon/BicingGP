using BicingGP.Application.MediatR.MiBiciTuBici.Status;
using BicingGP.Application.Services;
using BicingGP.Application.Services.Station;
using MediatR;

namespace BicingGP.Application.MediatR.MiBiciTuBici.Station;


public class SummaryMessageHandler : IRequestHandler<StationInputDto, IEnumerable<StationOutputDto>>
{
    private readonly IHttpService _httpService;

    public SummaryMessageHandler(IHttpService httpService)
    {
        _httpService = httpService;
    }

    public async Task<IEnumerable<StationOutputDto>> Handle(StationInputDto request, CancellationToken cancellationToken)
    {
        var stationServices = new StationService<StationOutputDto, StatusOutputDto>(_httpService, request.ProviderGeneric);
        return await stationServices.Get();
    }
}