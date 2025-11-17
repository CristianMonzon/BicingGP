using BicingGP.Application.Services.Station;
using MediatR;

namespace BicingGP.Application.MediatR.OpenData.Station
{

    public class StationMessageHandler : IRequestHandler<OpenDataStationInputDTO, List<OpenDataStationOutDTO>>
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StationMessageHandler(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<OpenDataStationOutDTO>> Handle(OpenDataStationInputDTO request, CancellationToken cancellationToken)
        {        
            var stationServices = new OpenDataStationServices(_httpClientFactory, request.Provider);
            var stations= await stationServices.GetStations();
            return stations;
        }
        


    }
}