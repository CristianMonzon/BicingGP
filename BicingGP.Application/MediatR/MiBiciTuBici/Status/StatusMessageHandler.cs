using BicingGP.Application.MediatR.MiBiciTuBici.Station;
using BicingGP.Application.Services;
using BicingGP.Application.Services.Status;
using MediatR;

namespace BicingGP.Application.MediatR.MiBiciTuBici.Status
{
    public class StatusMessageHandler : IRequestHandler<StatusInputDto, IEnumerable<StatusOutputDto>>
    {
        private readonly IHttpService _httpService;

        public StatusMessageHandler(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<StatusOutputDto>> Handle(StatusInputDto request, CancellationToken cancellationToken)
        {
            var statusService = new StatusService<StationOutputDto, StatusOutputDto>(_httpService, request.ProviderGeneric);
            return await statusService.Get();
        }
    }
}
