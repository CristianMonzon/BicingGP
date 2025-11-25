using BicingGP.Application.MediatR.CityBik.Status.Barcelona;
using BicingGP.Application.Services;
using BicingGP.Application.Services.Station;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Station.Barcelona
{

    public class StationMessageBarcelonaHandler : IRequestHandler<StationInputDtoBarcelona, IEnumerable<StationOutputDtoBarcelona>>
    {
        private readonly IHttpService _httpService;

        public StationMessageBarcelonaHandler(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<StationOutputDtoBarcelona>> Handle(StationInputDtoBarcelona request, CancellationToken cancellationToken)
        {         
            var stationServices = new StationService<StationOutputDtoBarcelona,StatusOutputDtoBarcelona>(_httpService, request.ProviderGeneric);
            return await stationServices.Get();
        }
    }
}