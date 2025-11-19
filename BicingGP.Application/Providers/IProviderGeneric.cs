namespace BicingGP.Application.Providers
{
    
    public interface IProviderGeneric<TStation,TStatus> : IProvider
    {
        List<TStation> ConvertToStationOutDtos(string response);

        List<TStatus> ConvertToStatusOutDtos(string response);
    }
}