using BicingGPApplication.Entities;
using MediatR;

namespace BicingGPApplication.MediatR.CityBik.Status
{
    public class StatusInputDTO : IRequest<List<StatusOutDTO>>
    {
        public IProvider Provider { get; private set; }


        public StatusInputDTO(IProvider provider)
        {
            Provider = provider;
        }
    }
}
