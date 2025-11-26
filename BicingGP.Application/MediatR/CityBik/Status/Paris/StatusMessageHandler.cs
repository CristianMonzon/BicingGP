using BicingGP.Application.MediatR.CityBik.Station.Paris;
using BicingGP.Application.Services;
using BicingGP.Application.Services.Status;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Status.Paris
{
    public class StatusMessageHandler : IRequestHandler<StatusInputDtoParis, IEnumerable<StatusOutputDtoParis>>
    {
        private readonly IHttpService _httpService;
        public StatusMessageHandler(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<StatusOutputDtoParis>> Handle(StatusInputDtoParis request, CancellationToken cancellationToken)
        {
            var statusServices = new StatusService<StationOutputDtoParis, StatusOutputDtoParis>(_httpService, request.ProviderGeneric);
            return await statusServices.Get();
        }
    }
}
