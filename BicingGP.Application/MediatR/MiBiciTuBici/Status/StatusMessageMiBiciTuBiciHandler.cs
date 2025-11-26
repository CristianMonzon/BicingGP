using BicingGP.Application.MediatR.MiBiciTuBici.Station;
using BicingGP.Application.Services;
using BicingGP.Application.Services.Status;
using MediatR;

namespace BicingGP.Application.MediatR.MiBiciTuBici.Status
{
    public class StatusMessageMiBiciTuBiciHandler : IRequestHandler<StatusInputDtoMiBiciTuBici, IEnumerable<StatusOutputDtoMiBiciTuBici>>
    {
        private readonly IHttpService _httpService;

        public StatusMessageMiBiciTuBiciHandler(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<StatusOutputDtoMiBiciTuBici>> Handle(StatusInputDtoMiBiciTuBici request, CancellationToken cancellationToken)
        {
            var statusService = new StatusService<StationOutputDtoMiBiciTuBici, StatusOutputDtoMiBiciTuBici>(_httpService, request.ProviderGeneric);
            return await statusService.Get();
        }
    }
}
