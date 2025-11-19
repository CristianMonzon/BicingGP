using BicingGP.Application.Providers.OpenData;
using MediatR;

namespace BicingGP.Application.MediatR.OpenData.Station
{
    public class OpenDataStationInputDto : IRequest<IEnumerable<OpenDataStationOutDto>>
    {

        public ProviderOpenData Provider { get; private set; }

        public OpenDataStationInputDto(ProviderOpenData provider)
        {
            Provider = provider;
        }
    }
}