using BicingGPApplication.Domain.Json.OpenData;
using BicingGPApplication.MediatR.OpenData.Station;
using BicingGPApplication.MediatR.OpenData.Status;

namespace BicingGPApplication.Providers.OpenData
{
    public class ProviderOpenData : Provider 
    {
        public Func<string, IList<OpenDataStationOutDTO>> ConvertToStationDTO { get => ConvertToStationOutDTO; }

        public List<OpenDataStationOutDTO> ConvertToStationOutDTO(string result)
        {
            var opendataStation =GenericConvert<Domain.Json.OpenData.Station.OpenDataStation>(result);
            return opendataStation!.data!.ToStationOutDTOs();
        }

        public List<OpenDataStatusOutDTO> ConvertToStatusOutDTO(string result)
        {
            var openDataStatus = GenericConvert<Domain.Json.OpenData.Status.OpenDataStatus>(result);
            return openDataStatus!.ToStatusOutDTOs();            
        }
    }
}