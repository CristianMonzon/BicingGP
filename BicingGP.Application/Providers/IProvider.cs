
namespace BicingGP.Application.Providers
{
    public interface IProvider
    {                
        string UrlGetStation { get; set; }
        string UrlGetStatus { get; set; }
        string? Token { get; set; }

        bool HasToken { get; }
    }
    

}
