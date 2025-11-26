using BicingGP.Application.MediatR.Velib.Station;
using BicingGP.Application.Services;
using BicingGP.Application.Services.Status;
using MediatR;

namespace BicingGP.Application.MediatR.Velib.Status
{
    public class StatusMessageVelibHandler : IRequestHandler<StatusInputDtoVelib, IEnumerable<StatusOutputDtoVelib>>
    {
        private readonly IHttpService _httpService;

        public StatusMessageVelibHandler(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<StatusOutputDtoVelib>> Handle(StatusInputDtoVelib request, CancellationToken cancellationToken)
        {
            var statusService = new StatusService<StationOutputDtoVelib, StatusOutputDtoVelib>(_httpService, request.ProviderGeneric);
            return await statusService.Get();
        }
    }
}
