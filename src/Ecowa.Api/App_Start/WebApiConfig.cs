using Autofuzz.Dependency;
using Ecowa.Business;
using Microsoft.WindowsAzure.Mobile.Service;
using Microsoft.WindowsAzure.Mobile.Service.Config;
using System.Reflection;
using System.Web.Http;
using Autofac;

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
