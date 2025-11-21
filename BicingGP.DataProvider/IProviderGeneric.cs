namespace BicingGP.DataProvider.Providers
{
    public interface IProviderGeneric<TStation,TStatus> : IProvider, IStationConverter<TStation>, IStatusConverter<TStatus>
    {    
    }

}