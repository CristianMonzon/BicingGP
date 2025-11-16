using BicingGPApplication.MediatR.CityBik.Station.Barcelona;
using BicingGPApplication.MediatR.CityBik.Status;

namespace BicingGPApplication.Entities
{
    public interface IProvider
    {                
        List<StatusOutDTO> ConvertToStatusOutDTO(string response);

        string UrlGetStation { get; set; }
        string UrlGetStatus { get; set; }
        string Token { get; set; }

        bool HasToken { get; }
    }
    

}
