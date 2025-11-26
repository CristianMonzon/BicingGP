using BicingGP.Application.MediatR.Velib.Status;
using BicingGP.Application.Services;
using BicingGP.Application.Services.Station;
using MediatR;

namespace BicingGP.Application.MediatR.Velib.Station;


public class StationMessageVelibHandler : IRequestHandler<StationInputDtoVelib, IEnumerable<StationOutputDtoVelib>>
{
    private readonly IHttpService _httpService;

    public StationMessageVelibHandler(IHttpService httpService)
    {
        _httpService = httpService;
    }

    public async Task<IEnumerable<StationOutputDtoVelib>> Handle(StationInputDtoVelib request, CancellationToken cancellationToken)
    {
        var stationServices = new StationService<StationOutputDtoVelib, StatusOutputDtoVelib>(_httpService, request.ProviderGeneric);
        return await stationServices.Get();
    }
}