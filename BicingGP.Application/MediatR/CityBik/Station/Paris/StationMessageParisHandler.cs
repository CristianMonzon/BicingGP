using BicingGP.Application.MediatR.CityBik.Status.Paris;
using BicingGP.Application.Services.Station;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Station.Paris
{

    public class StationMessageParisHandler : IRequestHandler<StationInputDtoParis, IEnumerable<StationOutDtoParis>>
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StationMessageParisHandler(IHttpClientFactory httpClientFactory)
        {            
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<StationOutDtoParis>> Handle(StationInputDtoParis request, CancellationToken cancellationToken)
        {            
            var stationServices = new StationService<StationOutDtoParis, StatusOutputDtoParis>(_httpClientFactory, request.ProviderGeneric);
            return await stationServices.Get();
        }
    }
}