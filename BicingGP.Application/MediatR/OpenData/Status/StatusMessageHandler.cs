using BicingGP.Application.Services.Status;
using MediatR;

namespace BicingGP.Application.MediatR.OpenData.Status
{
    public class StatusMessageHandler : IRequestHandler<OpenDataStatusInputDto, IEnumerable<OpenDataStatusOutDto>>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public StatusMessageHandler(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<OpenDataStatusOutDto>> Handle(OpenDataStatusInputDto request, CancellationToken cancellationToken)
        {
            var statusServices = new OpenDataStatusService(_httpClientFactory, request.Provider);
            return await statusServices.Get();
        }
    }
}
