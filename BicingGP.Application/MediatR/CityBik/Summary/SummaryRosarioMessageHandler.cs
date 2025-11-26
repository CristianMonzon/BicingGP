using BicingGP.Application.Domain.CityBik;
using BicingGP.Application.MediatR.CityBik.Station.Rosario;
using BicingGP.Application.MediatR.CityBik.Status.Rosario;
using BicingGP.Application.Services;
using BicingGP.Application.Services.Station;
using MediatR;

namespace BicingGP.Application.MediatR.CityBik.Summary
{

    public class SummaryRosarioMessageHandler : IRequestHandler<StationRosarioRequest, IEnumerable<StationRosarioResponse>>
    {
        private readonly IHttpService _httpService;

        public SummaryRosarioMessageHandler(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<StationRosarioResponse>> Handle(StationRosarioRequest request, CancellationToken cancellationToken)
        {
            var stationServices = new StationService<StationOutputDtoRosario, StatusOutputDtoRosario>(_httpService, request.ProviderGeneric);
            IEnumerable<StationOutputDtoRosario> list = await stationServices.Get();

            return list.Select(c => c.FromStationDtoRosarioToStationResponse()).ToList();
        }
    }
}