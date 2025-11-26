using BicingGP.Application.Domain.MiBiciTuBici;
using BicingGP.Application.MediatR.MiBiciTuBici.Station;
using BicingGP.Application.MediatR.MiBiciTuBici.Status;
using BicingGP.DataProvider.Providers;


namespace BicingGP.Application.Providers.MiBiciTuBici
{
    public class ProviderMiBiciTuBici : Provider, IProviderGeneric<StationOutputDtoMiBiciTuBici, StatusOutputDtoMiBiciTuBici>
    {
        
        public IEnumerable<StationOutputDtoMiBiciTuBici> ConvertToStationOutDtos(string response)
        {
            var stations = GenericConvert<DataProvider.MiBiciTuBici.Station.MiBiciTuBiciRootStation>(response);
            return stations!.ToStationOutDtos();
        }

        public IEnumerable<StatusOutputDtoMiBiciTuBici> ConvertToStatusOutDtos(string response)
        {
            var status = GenericConvert<DataProvider.MiBiciTuBici.Status.MiBiciTuBiciRootStatus>(response);
            return status!.ToStatusOutDtos();            
        }       
    }
}