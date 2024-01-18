using BicingGPApplication.Domain.StationJson;
using MediatR;

namespace BicingGPApplication.MediatR
{
    public class StationMessage : IRequest<StationRoot>
    {
        public readonly string? Url;

        public StationMessage(string? _url)
        {
            Url = _url;
        }
    }
}
