using BicingGPApplication.Domain.StatusJson;
using MediatR;

namespace BicingGPApplication.MediatR
{
    public class StatusMessage : IRequest<StatusRoot>
    {
        public readonly string? Url;

        public StatusMessage(string? url)
        {
            Url = url;
        }
    }
}
