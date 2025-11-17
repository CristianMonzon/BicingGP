using BicingGPApplication.Entities.OpenData;
using MediatR;

namespace BicingGPApplication.MediatR.OpenData.Station
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