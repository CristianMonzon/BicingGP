using BicingGPApplication.Services;
using MediatR;

namespace BicingGPApplication.MediatR.CityBik.Status
{
    public class StatusMessageHandler : IRequestHandler<StatusInputDTO, List<StatusOutDTO>>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public StatusMessageHandler(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<StatusOutDTO>> Handle(StatusInputDTO request, CancellationToken cancellationToken)
        {
            var statusServices = new StatusServices(_httpClientFactory, request.Provider);
            return await statusServices.GetStatus();
        }
    }
}
