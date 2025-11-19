using BicingGP.Application.Domain.OpenData;
using BicingGP.Application.MediatR.OpenData.Station;
using BicingGP.Application.MediatR.OpenData.Status;

namespace BicingGP.Application.Providers.OpenData
{
    public class ProviderOpenData : Provider 
    {
        public Func<string, IList<OpenDataStationOutDto>> ConvertToStationDto { get => ConvertToStationOutDto; }

        public List<OpenDataStationOutDto> ConvertToStationOutDto(string result)
        {
            var opendataStation =GenericConvert<BicingGP.DataDomain.OpenData.Station.OpenDataRootStation>(result);
            

            return opendataStation!.data!.ToStationOutDtos();
        }

        public List<OpenDataStatusOutDto> ConvertToStatusOutDto(string result)
        {
            var openDataStatus = GenericConvert<BicingGP.DataDomain.OpenData.Status.OpenDataRootStatus>(result);
            return openDataStatus!.ToStatusOutDtos();            
        }
    }
}