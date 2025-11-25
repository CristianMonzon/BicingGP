using BicingGP.Application.Domain.CityBik;
using BicingGP.Application.MediatR.CityBik.Station.Barcelona;
using BicingGP.Application.MediatR.CityBik.Status.Barcelona;
using BicingGP.Application.MediatR.MiBiciTuBici.Summary;
using BicingGP.Application.Services;
using BicingGP.Application.Services.Station;
using MediatR;

namespace BicingGP.Application.MediatR.MiBiciTuBici.Station.Summary
{

    public class SummaryBarcelonaMessageHandler : IRequestHandler<StationBarcelonaRequest, IEnumerable<StationBarcelonaResponse>>
    {
        private readonly IHttpService _httpService;

        public SummaryBarcelonaMessageHandler(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<StationBarcelonaResponse>> Handle(StationBarcelonaRequest request, CancellationToken cancellationToken)
        {
            var stationServices = new StationService<StationOutputDtoBarcelona, StatusOutputDtoBarcelona>(_httpService, request.ProviderGeneric);
            IEnumerable<StationOutputDtoBarcelona> list = await stationServices.Get();

            return list.Select(c => c.FromStationDtoBarcelonaToStationResponse()).ToList();
        }
    }
}