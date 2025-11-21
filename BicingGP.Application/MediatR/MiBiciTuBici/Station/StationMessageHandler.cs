using BicingGP.Application.MediatR.MiBiciTuBici.Status;
using BicingGP.Application.Services.Station;
using MediatR;

namespace BicingGP.Application.MediatR.MiBiciTuBici.Station;


public class StationMessageHandler : IRequestHandler<StationInputDto, IEnumerable<StationOutputDto>>
{
    private readonly IHttpClientFactory _httpClientFactory;

    public StationMessageHandler(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IEnumerable<StationOutputDto>> Handle(StationInputDto request, CancellationToken cancellationToken)
    {
        var stationServices = new StationService<StationOutputDto, StatusOutputDto>(_httpClientFactory, request.ProviderGeneric);
        return await stationServices.Get();
    }
}