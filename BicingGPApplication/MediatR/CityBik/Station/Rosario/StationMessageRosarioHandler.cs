using BicingGPApplication.Services.Station;
using MediatR;

namespace BicingGPApplication.MediatR.CityBik.Station.Rosario
{

    public class StationMessageRosarioHandler : IRequestHandler<StationInputDTORosario, List<StationOutDTORosario>>
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StationMessageRosarioHandler(IHttpClientFactory httpClientFactory)
        {            
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<StationOutDTORosario>> Handle(StationInputDTORosario request, CancellationToken cancellationToken)
        {            
            var stationServices = new StationServices<StationOutDTORosario>(_httpClientFactory, request.ProviderGeneric);            
            return await stationServices.GetStations();
        }
    }
}