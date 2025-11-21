namespace BicingGP.DataProvider.Providers
{
    public interface IStatusConverter<TStatus>
    {
        IEnumerable<TStatus> ConvertToStatusOutDtos(string response);
    }

}