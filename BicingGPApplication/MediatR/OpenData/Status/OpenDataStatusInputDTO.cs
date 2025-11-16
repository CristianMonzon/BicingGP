using BicingGPApplication.Entities;
using MediatR;

namespace BicingGPApplication.MediatR.OpenData.Status
{
    public class OpenDataStatusInputDTO : IRequest<List<OpenDataStatusOutDTO>>
    {
        public ProviderOpenData Provider { get; private set; }

        public OpenDataStatusInputDTO(ProviderOpenData provider)
        {
            Provider = provider;
        }
    }
}
