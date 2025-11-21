using BicingGP.Application.MediatR.CityBik.Status.Rosario;
using BicingGP.Application.Services.Station;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Station.Rosario
{

    public class StationMessageRosarioHandler : IRequestHandler<StationInputDtoRosario, IEnumerable<StationOutputDtoRosario>>
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StationMessageRosarioHandler(IHttpClientFactory httpClientFactory)
        {            
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<StationOutputDtoRosario>> Handle(StationInputDtoRosario request, CancellationToken cancellationToken)
        {            
            var stationServices = new StationService<StationOutputDtoRosario, StatusOutputDtoRosario>(_httpClientFactory, request.ProviderGeneric);            
            return await stationServices.Get();
        }
    }
}