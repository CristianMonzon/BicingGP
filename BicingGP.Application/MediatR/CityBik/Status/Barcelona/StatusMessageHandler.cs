using BicingGP.Application.MediatR.CityBik.Station.Barcelona;
using BicingGP.Application.Services.Status;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Status.Barcelona
{
    public class StatusMessageHandler : IRequestHandler<StatusInputDtoBarcelona, IEnumerable<StatusOutputDtoBarcelona>>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public StatusMessageHandler(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<StatusOutputDtoBarcelona>> Handle(StatusInputDtoBarcelona request, CancellationToken cancellationToken)
        {
            var statusServices = new StatusServices<StationOutDtoBarcelona, StatusOutputDtoBarcelona>(_httpClientFactory, request.ProviderGeneric);
            return await statusServices.GetStatus();
        }
    }
}
