using BicingGP.Application.MediatR.CityBik.Station.Paris;
using BicingGP.Application.Services.Status;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Status.Paris
{
    public class StatusMessageHandler : IRequestHandler<StatusInputDtoParis, IEnumerable<StatusOutputDtoParis>>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public StatusMessageHandler(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<StatusOutputDtoParis>> Handle(StatusInputDtoParis request, CancellationToken cancellationToken)
        {
            var statusServices = new StatusService<StationOutputDtoParis, StatusOutputDtoParis>(_httpClientFactory, request.ProviderGeneric);
            return await statusServices.Get();
        }
    }
}
