using BicingGP.Application.MediatR.CityBik.Status;

namespace BicingGP.Application.Providers
{
    public interface IProvider
    {                
        List<StatusOutDTO> ConvertToStatusOutDTO(string response);

        string UrlGetStation { get; set; }
        string UrlGetStatus { get; set; }
        string? Token { get; set; }

        bool HasToken { get; }
    }
    

}
