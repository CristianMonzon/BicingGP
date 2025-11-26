using BicingGP.Application.MediatR.MiBiciTuBici.Status;
using BicingGP.Application.Services;
using BicingGP.Application.Services.Station;
using MediatR;

namespace BicingGP.Application.MediatR.MiBiciTuBici.Station;


public class StationMessageMiBiciTuBiciHandler : IRequestHandler<StationInputDtoMiBiciTuBici, IEnumerable<StationOutputDtoMiBiciTuBici>>
{
    private readonly IHttpService _httpService;

    public StationMessageMiBiciTuBiciHandler(IHttpService httpService)
    {
        _httpService = httpService;
    }

    public async Task<IEnumerable<StationOutputDtoMiBiciTuBici>> Handle(StationInputDtoMiBiciTuBici request, CancellationToken cancellationToken)
    {
        var stationServices = new StationService<StationOutputDtoMiBiciTuBici, StatusOutputDtoMiBiciTuBici>(_httpService, request.ProviderGeneric);
        return await stationServices.Get();
    }
}