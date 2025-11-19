using BicingGP.Application.Domain.OpenData;
using BicingGP.Application.MediatR.OpenData.Station;
using BicingGP.Application.MediatR.OpenData.Status;
using BicingGP.DataDomain.OpenData.Station;
using BicingGP.DataDomain.OpenData.Status;

namespace BicingGP.Application.Providers.OpenData
{
    public class ProviderOpenData : Provider 
    {
        
        public IEnumerable<OpenDataStationOutDto> ConvertToStationOutDto(string result)
        {
            var opendataStation = GenericConvert<OpenDataRootStation>(result);
            return opendataStation!.data!.ToStationOutDtos();
        }

        public IEnumerable<OpenDataStatusOutDto> ConvertToStatusOutDto(string result)
        {
            var openDataStatus = GenericConvert<OpenDataRootStatus>(result);
            return openDataStatus!.ToStatusOutDtos();            
        }
    }
}