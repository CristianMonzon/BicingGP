using BicingGP.Application.Domain.Velib;
using BicingGP.Application.MediatR.Velib.Station;
using BicingGP.Application.MediatR.Velib.Status;
using BicingGP.DataProvider.Providers;

namespace BicingGP.Application.Providers.Velib
{
    public class ProviderVelib : Provider, IProviderGeneric<StationOutputDtoVelib, StatusOutputDtoVelib>
    {       
        public IEnumerable<StationOutputDtoVelib> ConvertToStationOutDtos(string response)
        {
            var stations = GenericConvert<DataProvider.Velib.Station.VelibRootStation>(response);
            return stations!.ToStationOutDtos();
        }

        public IEnumerable<StatusOutputDtoVelib> ConvertToStatusOutDtos(string response)
        {
            var status = GenericConvert<DataProvider.Velib.Status.VelibRootStatus>(response);
            return status!.ToStatusOutDtos();            
        }       
    }
}