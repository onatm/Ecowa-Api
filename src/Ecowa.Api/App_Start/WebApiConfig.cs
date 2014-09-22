using Autofac;
using Autofuzz.Dependency;
using Ecowa.Business;
using Microsoft.WindowsAzure.Mobile.Service;
using System.Web.Http;

namespace Ecowa.Api
{
    public static class WebApiConfig
    {
        public static void Register()
        {
            ConfigOptions options = new ConfigOptions();

            HttpConfiguration config = ServiceConfig.Initialize(new ConfigBuilder(options, (configuration, builder) =>
            {
                BusinessControlStartUp.Run();
                IContainer container = ServiceControl.Container;
                IEcowaBusiness business = container.Resolve<IEcowaBusiness>();

                builder.RegisterInstance(business).As<IEcowaBusiness>();
            }));

            config.Formatters.Remove(config.Formatters.XmlFormatter);

            config.SetIsHosted(true);
        }
    }
}
