using BicingGPApplication.Domain.StationJson;
using MediatR;

namespace BicingGPApplication.MediatR
{
    public class StationMessage : IRequest<StationRoot>
    {
        public readonly string? Url;
        public readonly string? Token;

        public StationMessage(string? _url, string? token)
        {
            Url = _url;
            Token = token;
        }
    }
}
