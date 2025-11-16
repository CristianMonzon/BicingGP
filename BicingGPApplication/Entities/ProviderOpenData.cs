using BicingGPApplication.Domain.Json;
using BicingGPApplication.MediatR.CityBik.Status;
using BicingGPApplication.MediatR.OpenData.Station;
using BicingGPApplication.MediatR.OpenData.Status;

namespace BicingGPApplication.Entities
{
    public class ProviderOpenData : Provider 
    {
        
        public Func<string, IList<OpenDataStationOutDTO>> ConvertToStationDTO { get => ConvertToStationOutDTO; }

        public List<OpenDataStationOutDTO> ConvertToStationOutDTO(string result)
        {
            var opendata =GenericConvert<BicingGPApplication.Domain.Json.OpenDataStation.OpenData>(result);
            return opendata!.data!.ToStationOutDTOs();
        }


        public List<OpenDataStatusOutDTO> ConvertToStatusOutDTO(string result)
        {
            var openData = GenericConvert<BicingGPApplication.Domain.Json.OpenDataStatus.OpenData>(result);
            return openData!.data!.ToStatusOutDTOs();
        }

        
    }
}