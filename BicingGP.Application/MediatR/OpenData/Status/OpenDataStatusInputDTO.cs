using BicingGP.Application.Providers.OpenData;
using MediatR;

namespace BicingGP.Application.MediatR.OpenData.Status
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
