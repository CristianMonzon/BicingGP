namespace BicingGP.Application.Services
{
    public interface IHttpService
    {
        Task<string> GetStringAsync(string url, string? token = null);
    }
}
