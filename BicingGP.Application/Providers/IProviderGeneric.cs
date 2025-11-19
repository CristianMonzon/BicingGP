namespace BicingGP.Application.Providers
{    
    public interface IProviderGeneric<TStation,TStatus> : IProvider
    {
        IEnumerable<TStation> ConvertToStationOutDtos(string response);
        IEnumerable<TStatus> ConvertToStatusOutDtos(string response);
    }
}