using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using System.Web.Routing;
using System.Net.Http.Headers;
using System.Web.Mvc;
//using Microsoft.Owin.Security.OAuth;

[assembly: OwinStartup(typeof(TechProject.Startup))]

namespace TechProject
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            HttpConfiguration httpconfig = new HttpConfiguration();
            WebApiConfig.Register(httpconfig);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
            //app.UseCors()
            app.UseWebApi(httpconfig);
            httpconfig.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }
    }
}
