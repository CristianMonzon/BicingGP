using BicingGPApplication.MediatR.CityBik.Station.Barcelona;
using BicingGPApplication.MediatR.CityBik.Status;

namespace BicingGPApplication.Entities
{
    
    public interface IProviderGeneric<T>
    {
        List<T> ConvertToStationOutDTOGeneric(string response);

        List<StatusOutDTO> ConvertToStatusOutDTO(string response);

        string? Token { get; set; }
        string UrlGetStation { get; set; }
        string UrlGetStatus { get; set; }

        bool HasToken { get; }
    }

}
