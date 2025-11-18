using BicingGP.Application.Domain.OpenData;
using BicingGP.Application.MediatR.OpenData.Station;
using BicingGP.Application.MediatR.OpenData.Status;

namespace BicingGP.Application.Providers.OpenData
{
    public class ProviderOpenData : Provider 
    {
        public Func<string, IList<OpenDataStationOutDTO>> ConvertToStationDTO { get => ConvertToStationOutDTO; }

        public List<OpenDataStationOutDTO> ConvertToStationOutDTO(string result)
        {
            var opendataStation =GenericConvert<BicingGP.DataDomain.OpenData.Station.OpenDataRootStation>(result);
            

            return opendataStation!.data!.ToStationOutDTOs();
        }

        public List<OpenDataStatusOutDTO> ConvertToStatusOutDTO(string result)
        {
            var openDataStatus = GenericConvert<BicingGP.DataDomain.OpenData.Status.OpenDataRootStatus>(result);
            return openDataStatus!.ToStatusOutDTOs();            
        }
    }
}