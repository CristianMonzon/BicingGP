using BicingGPApplication.MediatR.CityBik.Station;
using BicingGPApplication.MediatR.CityBik.Status;

namespace BicingGPApplication.Entities
{
    public interface IProvider {

        List<StationOutDTO> ConvertToStationOutDTO(string response);
                      
        List<StatusOutDTO> ConvertToStatusOutDTO(string response);

        string Token { get; set; }
        string UrlGetStation { get; set; }
        string UrlGetStatus { get; set; }

        bool HasToken { get; }
    }
    
}
