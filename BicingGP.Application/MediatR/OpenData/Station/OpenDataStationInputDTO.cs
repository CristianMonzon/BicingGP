using BicingGP.Application.Providers.OpenData;
using BicingGP.Application.Providers.OpenData;
using MediatR;

namespace BicingGP.Application.MediatR.OpenData.Station
{
    public class OpenDataStationInputDTO : IRequest<List<OpenDataStationOutDTO>>
    {

        public ProviderOpenData Provider { get; private set; }

        public OpenDataStationInputDTO(ProviderOpenData provider)
        {
            Provider = provider;
        }
    }
}