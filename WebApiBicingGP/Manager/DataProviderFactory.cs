namespace WebApiBicingGP.Manager
{
    public interface IDataProviderFactory
    {
        T CreateProvider<T>(DataProviderConfig config) where T : class, new();
    }

    public class DataProviderFactory : IDataProviderFactory
    {
        public T CreateProvider<T>(DataProviderConfig config) where T : class, new()
        {
            var provider = new T();
            var providerType = typeof(T);

            var statusProperty = providerType.GetProperty("UrlGetStatus");
            var stationProperty = providerType.GetProperty("UrlGetStation");
            var tokenProperty = providerType.GetProperty("Token");
            var cityProperty = providerType.GetProperty("City");
            var countryProperty = providerType.GetProperty("Country");

            statusProperty?.SetValue(provider, config.StatusInformation);
            stationProperty?.SetValue(provider, config.StationInformation);
            tokenProperty?.SetValue(provider, config.Token);
            cityProperty?.SetValue(provider, config.City);
            countryProperty?.SetValue(provider, config.Country);

            return provider;
        }
    }

    
}
