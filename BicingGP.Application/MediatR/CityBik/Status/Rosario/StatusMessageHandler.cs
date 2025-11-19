using BicingGP.Application.MediatR.CityBik.Station.Rosario;
using BicingGP.Application.Services.Status;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Status.Rosario
{
    public class StatusMessageHandler : IRequestHandler<StatusInputDtoRosario, IEnumerable<StatusOutputDtoRosario>>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public StatusMessageHandler(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<StatusOutputDtoRosario>> Handle(StatusInputDtoRosario request, CancellationToken cancellationToken)
        {
            var statusServices = new StatusServices<StationOutDtoRosario,StatusOutputDtoRosario>(_httpClientFactory, request.ProviderGeneric);
            return await statusServices.GetStatus();
        }
    }
}
