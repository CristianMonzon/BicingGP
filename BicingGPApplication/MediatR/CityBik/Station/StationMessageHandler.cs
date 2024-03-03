using BicingGPApplication.Services;
using MediatR;
using Newtonsoft.Json;

namespace BicingGPApplication.MediatR.CityBik.Station
{

    public class StationMessageHandler : IRequestHandler<StationInputDTO, List<StationOutDTO>>
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StationMessageHandler(IHttpClientFactory httpClientFactory)
        {            
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<StationOutDTO>> Handle(StationInputDTO request, CancellationToken cancellationToken)
        {
            var stationServices = new StationServices(_httpClientFactory, request.Provider);
            return await stationServices.GetStations();
        }
    }
}