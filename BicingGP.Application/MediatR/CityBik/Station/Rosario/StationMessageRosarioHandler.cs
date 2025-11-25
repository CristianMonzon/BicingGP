using BicingGP.Application.MediatR.CityBik.Status.Rosario;
using BicingGP.Application.Services;
using BicingGP.Application.Services.Station;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Station.Rosario
{

    public class StationMessageRosarioHandler : IRequestHandler<StationInputDtoRosario, IEnumerable<StationOutputDtoRosario>>
    {
        private readonly IHttpService _httpService;

        public StationMessageRosarioHandler(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<StationOutputDtoRosario>> Handle(StationInputDtoRosario request, CancellationToken cancellationToken)
        {            
            var stationServices = new StationService<StationOutputDtoRosario, StatusOutputDtoRosario>(_httpService, request.ProviderGeneric);            
            return await stationServices.Get();
        }
    }
}