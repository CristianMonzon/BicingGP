using BicingGP.Application.MediatR.CityBik.Station.Rosario;
using BicingGP.Application.Services;
using BicingGP.Application.Services.Status;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Status.Rosario
{
    public class StatusMessageHandler : IRequestHandler<StatusInputDtoRosario, IEnumerable<StatusOutputDtoRosario>>
    {
        private readonly IHttpService _httpService;
        public StatusMessageHandler(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<StatusOutputDtoRosario>> Handle(StatusInputDtoRosario request, CancellationToken cancellationToken)
        {
            var statusServices = new StatusService<StationOutputDtoRosario,StatusOutputDtoRosario>(_httpService, request.ProviderGeneric);
            return await statusServices.Get();
        }
    }
}
