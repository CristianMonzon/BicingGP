using BicingGP.Application.Domain.Json.CityBk.CityBikGeneric;
using BicingGP.Application.MediatR.CityBik.Status;
using BicingGP.DataDomain.CityBik.Generic;

namespace BicingGP.Application.Providers
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
