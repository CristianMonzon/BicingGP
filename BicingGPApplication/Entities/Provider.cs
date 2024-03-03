using Newtonsoft.Json;

namespace BicingGPApplication.Entities
{

    public abstract class Provider
    {
        public string Token { get; set; }
        public string UrlGetStation { get; set; }
        public string UrlGetStatus { get; set; }

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
