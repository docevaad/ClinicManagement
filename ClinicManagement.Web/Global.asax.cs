using ClinicManagement.Web.App_Start;
using System.Web;
using System.Web.Http;

namespace ClinicManagement.Web
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutofacWebApiConfiguration.Initialize(GlobalConfiguration.Configuration);
        }
    }
}
