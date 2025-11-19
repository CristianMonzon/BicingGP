using BicingGP.Application.MediatR.CityBik.Status.Rosario;
using BicingGP.Application.Services.Station;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Station.Rosario
{

    public class StationMessageRosarioHandler : IRequestHandler<StationInputDtoRosario, IEnumerable<StationOutDtoRosario>>
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StationMessageRosarioHandler(IHttpClientFactory httpClientFactory)
        {            
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<StationOutDtoRosario>> Handle(StationInputDtoRosario request, CancellationToken cancellationToken)
        {            
            var stationServices = new StationServices<StationOutDtoRosario, StatusOutputDtoRosario>(_httpClientFactory, request.ProviderGeneric);            
            return await stationServices.GetStations();
        }
    }
}