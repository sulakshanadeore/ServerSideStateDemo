using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ServerSideStateDemo
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["hits"] = 0;
        }
        void Session_Start(object sender, EventArgs e)
        {
            Application["hits"] = Convert.ToInt32(Application["hits"])  +1 ;
        }

        void Session_End(object sender, EventArgs e)
        {
            Session.Clear();
           
            Session.Abandon();
            
        }


        void Application_End(object sender, EventArgs e)
        {

            Application["hits"] = 0;
        }




    }
}