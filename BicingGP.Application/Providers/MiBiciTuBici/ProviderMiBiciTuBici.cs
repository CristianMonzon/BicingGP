using BicingGP.Application.Domain.MiBiciTuBici;
using BicingGP.Application.MediatR.MiBiciTuBici.Station;
using BicingGP.Application.MediatR.MiBiciTuBici.Status;
using BicingGP.DataProvider.Providers;


namespace BicingGP.Application.Providers.MiBiciTuBici
{
    public class ProviderMiBiciTuBici : Provider, IProviderGeneric<StationOutputDto, StatusOutputDto>
    {
        
        public IEnumerable<StationOutputDto> ConvertToStationOutDtos(string response)
        {
            var stations = GenericConvert<BicingGP.DataDomain.MiBiciTuBici.Station.MiBiciTuBiciRootStation>(response);
            return stations!.ToStationOutDtos();
        }

        public IEnumerable<StatusOutputDto> ConvertToStatusOutDtos(string response)
        {
            var status = GenericConvert<BicingGP.DataDomain.MiBiciTuBici.Status.MiBiciTuBiciRootStatus>(response);
            return status!.ToStatusOutDtos();            
        }       
    }
}