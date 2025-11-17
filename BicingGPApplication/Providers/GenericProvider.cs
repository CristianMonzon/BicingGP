using BicingGPApplication.Domain.Json.CityBk.CityBikGeneric;
using BicingGPApplication.MediatR.CityBik.Status;
using BicingGPDataDomain.CityBik.Generic;

namespace BicingGPApplication.Providers
{

    public abstract class GenericProvider : Provider
    {      
        public List<StatusOutDTO> ConvertToStatusOutDTO(string result)
        {            
            var root = GenericConvert<CityBikRootGeneric>(result);
            return root!.network!.stations!.Select(c => c.ToStatusOutDTO()).ToList();
        }
    }

}
