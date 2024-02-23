using Microsoft.Extensions.Configuration;

namespace WebApiBicingGP.Manager
{
    public class AppSettings
    {
        private readonly IConfiguration _configuration;

        public string? StatusInformation
        {
            get
            {
                return _configuration?["Url:StatusInformation"];
            }
        }

        public string? StationInformation
        {
            get
            {
                return _configuration?["Url:StationInformation"];
            }
        }

        public string? Token
        {
            get
            {
                return _configuration?["Url:Token"];
            }
        }
        

        public AppSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }

    }
}
