using BicingGPApplication.Providers.OpenData;
using BicingGPApplication.MediatR.OpenData.Status;
using System.Net.Http.Headers;

namespace BicingGPApplication.Services.Status
{

    public class OpenDataStatusServices 
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ProviderOpenData ProviderOpenData;

        public OpenDataStatusServices(IHttpClientFactory httpClientFactory, ProviderOpenData provider)
        {
            _httpClientFactory = httpClientFactory;
            ProviderOpenData = provider;
        }

        public async Task<List<OpenDataStatusOutDTO>> GetStatus()
        {
            var httpcient = _httpClientFactory.CreateClient();
            
            if(ProviderOpenData.Token!=null) httpcient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(ProviderOpenData.Token);
            
            var response = await httpcient.GetStringAsync(ProviderOpenData.UrlGetStatus);

            return ProviderOpenData.ConvertToStatusOutDTO(response);
        }

    }


}