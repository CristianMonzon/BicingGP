using BicingGP.DataProvider.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.MiBiciTuBici.Station
{
    public class StationInputDtoMiBiciTuBici : IRequest<IEnumerable<StationOutputDtoMiBiciTuBici>>
    {
        public IProviderGeneric<StationOutputDtoMiBiciTuBici, Status.StatusOutputDtoMiBiciTuBici> ProviderGeneric { get; set; }

        public StationInputDtoMiBiciTuBici(IProviderGeneric<StationOutputDtoMiBiciTuBici, Status.StatusOutputDtoMiBiciTuBici> provider)
        {
            ProviderGeneric = provider;
        }
    }
}