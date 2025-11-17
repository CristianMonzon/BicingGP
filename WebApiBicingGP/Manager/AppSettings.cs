using BicingGPApplication.Providers;

namespace WebApiBicingGP.Manager
{
    public class AppSettings
    {
        private readonly IConfiguration _configuration;

        public AppSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}

