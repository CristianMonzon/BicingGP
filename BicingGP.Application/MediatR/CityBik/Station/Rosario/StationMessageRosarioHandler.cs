using BicingGP.Application.Services.Station;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Station.Rosario
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