namespace BicingGP.DataProvider.Providers
{
    public interface IStationConverter<TStation>
    {
        IEnumerable<TStation> ConvertToStationOutDtos(string response);
    }
}