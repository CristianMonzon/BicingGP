using Newtonsoft.Json;

namespace BicingGP.DataProvider.Providers
{

    public abstract class Provider :IProvider
    {
        public string UrlGetStation { get; set; }
        public string UrlGetStatus { get; set; }
        public string? Token { get; set; }

        public string? City { get; set; }
        public string? Country { get; set; }

        public bool HasToken
        {
            get
            {
                return !String.IsNullOrEmpty(Token);
            }
        }
               
        public T? GenericConvert<T>(string json) where T : class
        {
            if (string.IsNullOrEmpty(json))
                return null;
            else
                return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
