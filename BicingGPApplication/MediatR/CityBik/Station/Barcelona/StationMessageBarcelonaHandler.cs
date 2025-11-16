using BicingGPApplication.Services.Station;
using MediatR;

namespace BicingGPApplication.MediatR.CityBik.Station.Barcelona
{

    public class StationMessageBarcelonaHandler : IRequestHandler<StationInputDTOBarcelona, List<StationOutDTOBarcelona>>
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StationMessageBarcelonaHandler(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<StationOutDTOBarcelona>> Handle(StationInputDTOBarcelona request, CancellationToken cancellationToken)
        {         
            var stationServices = new StationServices<StationOutDTOBarcelona>(_httpClientFactory, request.ProviderGeneric);
            return await stationServices.GetStations();
        }
    }
}