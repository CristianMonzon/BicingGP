using BicingGPApplication.Domain.StatusJson;
using MediatR;
using Newtonsoft.Json;

namespace BicingGPApplication.MediatR
{
    public class StatusMessageHandler : IRequestHandler<StatusMessage, StatusRoot>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public StatusMessageHandler(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public Task<StatusRoot> Handle(StatusMessage request, CancellationToken cancellationToken)
        {
            var httpcient = _httpClientFactory.CreateClient();
            var response = httpcient.GetStringAsync(request.Url);
            var station = JsonConvert.DeserializeObject<StatusRoot>(response.Result);
            return Task.FromResult(station);
        }
    }
}
