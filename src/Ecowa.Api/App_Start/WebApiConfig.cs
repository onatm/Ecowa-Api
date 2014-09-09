using Microsoft.WindowsAzure.Mobile.Service;
using System.Web.Http;

namespace Ecowa.Api
{
    public static class WebApiConfig
    {
        public static void Register()
        {
            ConfigOptions options = new ConfigOptions();

            HttpConfiguration config = ServiceConfig.Initialize(new ConfigBuilder(options));

            config.Formatters.Remove(config.Formatters.XmlFormatter);

            config.SetIsHosted(true);
        }
    }
}
