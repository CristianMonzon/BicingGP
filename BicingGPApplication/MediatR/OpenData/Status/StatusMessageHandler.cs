using BicingGPApplication.Services.Status;
using MediatR;

namespace BicingGPApplication.MediatR.OpenData.Status
{
    public class StatusMessageHandler : IRequestHandler<OpenDataStatusInputDTO, List<OpenDataStatusOutDTO>>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public StatusMessageHandler(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<OpenDataStatusOutDTO>> Handle(OpenDataStatusInputDTO request, CancellationToken cancellationToken)
        {
            var statusServices = new OpenDataStatusServices(_httpClientFactory, request.Provider);
            return await statusServices.GetStatus();
        }
    }
}
