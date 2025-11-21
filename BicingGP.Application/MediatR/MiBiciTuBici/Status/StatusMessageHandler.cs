using BicingGP.Application.MediatR.MiBiciTuBici.Station;

using BicingGP.Application.Services.Station;
using BicingGP.Application.Services.Status;
using MediatR;




namespace BicingGP.Application.MediatR.MiBiciTuBici.Status
{
    public class StatusMessageHandler : IRequestHandler<StatusInputDto, IEnumerable<StatusOutputDto>>
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatusMessageHandler(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<StatusOutputDto>> Handle(StatusInputDto request, CancellationToken cancellationToken)
        {
            var statusService = new StatusService<StationOutputDto, StatusOutputDto>(_httpClientFactory, request.ProviderGeneric);
            return await statusService.Get();
        }
    }
}
