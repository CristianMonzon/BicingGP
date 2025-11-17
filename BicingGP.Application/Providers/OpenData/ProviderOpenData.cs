using BicingGP.Application.Domain.Json.OpenData;
using BicingGP.Application.MediatR.OpenData.Station;
using BicingGP.Application.MediatR.OpenData.Status;

namespace BicingGP.Application.Providers.OpenData
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