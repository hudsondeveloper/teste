using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.AspNet.SignalR;

namespace teste1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Application["ContadorAcessos"] = 0;
 
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application["ContadorAcessos"] = (int)(Application["ContadorAcessos"]) + 1;
        }
        protected void Session_End(Object sender, EventArgs e)
        {
            Application["ContadorAcessos"] = (int)(Application["ContadorAcessos"]) - 1;
        }
    }
}
