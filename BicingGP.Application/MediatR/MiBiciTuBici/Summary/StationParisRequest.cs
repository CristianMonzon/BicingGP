using BicingGP.Application.MediatR.CityBik.Station.Paris;
using BicingGP.Application.MediatR.CityBik.Status.Paris;
using BicingGP.DataProvider.Providers;
using MediatR;

namespace BicingGP.Application.MediatR.MiBiciTuBici.Summary
{
    public class StationParisRequest : IRequest<IEnumerable<StationParisResponse>>
    {
        public IProviderGeneric<StationOutputDtoParis, StatusOutputDtoParis> ProviderGeneric { get; set; }

        public StationParisRequest(IProviderGeneric<StationOutputDtoParis, StatusOutputDtoParis> provider)
        {
            ProviderGeneric = provider;
        }
    }
}