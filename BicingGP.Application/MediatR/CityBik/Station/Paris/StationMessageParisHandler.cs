using BicingGP.Application.MediatR.CityBik.Status.Paris;
using BicingGP.Application.Services;
using BicingGP.Application.Services.Station;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Station.Paris
{

    public class StationMessageParisHandler : IRequestHandler<StationInputDtoParis, IEnumerable<StationOutputDtoParis>>
    {
        private readonly IHttpService _httpService;

        public StationMessageParisHandler(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<StationOutputDtoParis>> Handle(StationInputDtoParis request, CancellationToken cancellationToken)
        {            
            var stationServices = new StationService<StationOutputDtoParis, StatusOutputDtoParis>(_httpService, request.ProviderGeneric);
            return await stationServices.Get();
        }
    }
}