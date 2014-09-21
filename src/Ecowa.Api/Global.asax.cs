using System.Web;
using System.Web.Http;

namespace Ecowa.Api
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            WebApiConfig.Register();  
        }
    }
}
