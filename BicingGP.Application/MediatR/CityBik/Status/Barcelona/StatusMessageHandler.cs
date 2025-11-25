using BicingGP.Application.MediatR.CityBik.Station.Barcelona;
using BicingGP.Application.Services;
using BicingGP.Application.Services.Status;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Status.Barcelona
{
    public class StatusMessageHandler : IRequestHandler<StatusInputDtoBarcelona, IEnumerable<StatusOutputDtoBarcelona>>
    {
        private readonly IHttpService _httpService;
        public StatusMessageHandler(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<StatusOutputDtoBarcelona>> Handle(StatusInputDtoBarcelona request, CancellationToken cancellationToken)
        {
            var statusServices = new StatusService<StationOutputDtoBarcelona, StatusOutputDtoBarcelona>(_httpService, request.ProviderGeneric);
            return await statusServices.Get();
        }
    }
}
