using BicingGPApplication.Domain.Json.CityBikGeneric;
using BicingGPApplication.MediatR.CityBik.Status;

namespace BicingGPApplication.Entities
{

    public abstract class GenericProvider : Provider
    {      
        public List<StatusOutDTO> ConvertToStatusOutDTO(string result)
        {            
            var root = GenericConvert<CityBikeRootGeneric>(result);
            return root!.network!.stations!.Select(c => c.ToStatusOutDTO()).ToList();
        }
    }

}
