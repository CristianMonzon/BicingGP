using BicingGP.Application.Services.Station;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Station.Paris
{

    public class StationMessageParisHandler : IRequestHandler<StationInputDTOParis, List<StationOutDTOParis>>
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StationMessageParisHandler(IHttpClientFactory httpClientFactory)
        {            
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<StationOutDTOParis>> Handle(StationInputDTOParis request, CancellationToken cancellationToken)
        {            
            var stationServices = new StationServices<StationOutDTOParis>(_httpClientFactory, request.ProviderGeneric);            
            return await stationServices.GetStations();
        }
    }
}