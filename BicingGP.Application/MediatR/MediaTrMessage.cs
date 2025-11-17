using MediatR;

namespace BicingGPApplication.MediatR
{
    public class MediaTrMessage<T> : IRequest<T>
    {
        public readonly string? Url;

        public MediaTrMessage(string? url)
        {
            Url = url;
        }
    }
}
