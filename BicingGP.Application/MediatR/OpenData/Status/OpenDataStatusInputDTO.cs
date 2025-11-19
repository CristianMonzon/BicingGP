using BicingGP.Application.Providers.OpenData;
using MediatR;

namespace BicingGP.Application.MediatR.OpenData.Status
{
    public class OpenDataStatusInputDto : IRequest<IEnumerable<OpenDataStatusOutDto>>
    {
        public ProviderOpenData Provider { get; private set; }

        public OpenDataStatusInputDto(ProviderOpenData provider)
        {
            Provider = provider;
        }
    }
}
