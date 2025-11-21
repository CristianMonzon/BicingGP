using BicingGP.Application.MediatR.CityBik.Status.Barcelona;
using BicingGP.Application.Services.Station;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Station.Barcelona
{

    public class StationMessageBarcelonaHandler : IRequestHandler<StationInputDtoBarcelona, IEnumerable<StationOutputDtoBarcelona>>
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StationMessageBarcelonaHandler(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<StationOutputDtoBarcelona>> Handle(StationInputDtoBarcelona request, CancellationToken cancellationToken)
        {         
            var stationServices = new StationService<StationOutputDtoBarcelona,StatusOutputDtoBarcelona>(_httpClientFactory, request.ProviderGeneric);
            return await stationServices.Get();
        }
    }
}