using BicingGPApplication.Domain.StationJson;
using MediatR;
using Newtonsoft.Json;

namespace BicingGPApplication.MediatR
{
    public class StationMessageHandler : IRequestHandler<StationMessage, StationRoot>
    {
        private readonly IHttpClientFactory _httpClientFactory;
            
        public StationMessageHandler(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public Task<StationRoot> Handle(StationMessage request, CancellationToken cancellationToken)
        {
            var httpcient = _httpClientFactory.CreateClient();
            var response = httpcient.GetStringAsync(request.Url);
            var station = JsonConvert.DeserializeObject<StationRoot>(response.Result);
            return Task.FromResult(station);
        }
    }
}