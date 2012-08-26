using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Ninject;
using WhereDoesThisLinkGo.Services;

namespace WhereDoesThisLinkGo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            using (IKernel kernel = new StandardKernel())
            {
                kernel.Bind<IUrlService>()
                      .To<UrlService>();
            }

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
