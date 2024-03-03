using BicingGPApplication.Domain.Json.CityBik;
using BicingGPApplication.MediatR.CityBik.Station;
using BicingGPApplication.MediatR.CityBik.Status;

namespace BicingGPApplication.Entities
{

    public abstract class GenericProvider : Provider
    {
        public List<StationOutDTO> ConvertToStationOutDTO(string result)
        {
            var root = GenericConvert<Root>(result);
            return root.network.stations.Select(c => c.ToStationOutDTO()).ToList();
        }

        public List<StatusOutDTO> ConvertToStatusOutDTO(string result)
        {            
            var root = GenericConvert<Root>(result);
            return root.network.stations.Select(c => c.ToStatusOutDTO()).ToList();
        }
    }

}
