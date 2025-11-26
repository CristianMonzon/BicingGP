using BicingGP.Application.Domain.CityBik;
using BicingGP.Application.MediatR.CityBik.Station.Paris;
using BicingGP.Application.MediatR.CityBik.Status.Paris;
using BicingGP.Application.Services;
using BicingGP.Application.Services.Station;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Summary
{

    public class SummaryParisMessageHandler : IRequestHandler<StationParisRequest, IEnumerable<StationParisResponse>>
    {
        private readonly IHttpService _httpService;

        public SummaryParisMessageHandler(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<StationParisResponse>> Handle(StationParisRequest request, CancellationToken cancellationToken)
        {
            var stationServices = new StationService<StationOutputDtoParis, StatusOutputDtoParis>(_httpService, request.ProviderGeneric);
            IEnumerable<StationOutputDtoParis> list = await stationServices.Get();

            return list.Select(c => c.FromStationDtoParisToStationResponse()).ToList();
        }
    }
}