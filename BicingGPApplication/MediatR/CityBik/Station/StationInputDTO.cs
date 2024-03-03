using BicingGPApplication.Entities;
using MediatR;

namespace BicingGPApplication.MediatR.CityBik.Station
{
        
    public class StationInputDTO : IRequest<List<StationOutDTO>>
    {       
        public IProvider Provider { get; set; }

        public StationInputDTO(IProvider provider)
        {
            Provider = provider;
        }
    }
}