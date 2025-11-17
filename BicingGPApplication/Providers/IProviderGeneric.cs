using BicingGPApplication.MediatR.CityBik.Status;

namespace BicingGPApplication.Providers
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
