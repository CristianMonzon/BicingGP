using BicingGPApplication.Domain.StatusJson;
using MediatR;

namespace BicingGPApplication.MediatR
{
    public class StatusMessage : IRequest<StatusRoot>
    {
        public readonly string? Url;
        public readonly string? Token;

        public StatusMessage(string? url, string? token)
        {
            Url = url;
            Token = token;
        }
    }
}
