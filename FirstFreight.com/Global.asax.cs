using System; 
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Routing;  

namespace FirstFreight
{
    public class Global : System.Web.HttpApplication
    { 
        protected void Application_Start(object sender, EventArgs e)
        { 
            RouteTable.Routes.MapHttpRoute("DefaultApiWithId", "api/{controller}/{id}", new { id = RouteParameter.Optional }, new { id = @"\d+" });
            RouteTable.Routes.MapHttpRoute("ControllerAndAction", "api/{controller}/{action}");
            GlobalConfiguration.Configuration.Formatters.Clear();
            var jsonMediatypeFormatter = new JsonMediaTypeFormatter();
            jsonMediatypeFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            GlobalConfiguration.Configuration.Formatters.Add(jsonMediatypeFormatter);
        }

        //  Code that runs on application shutdown
        void Application_End(object sender, EventArgs e)
        { 
        }

        protected void Application_PostAuthorizeRequest()
        {
            System.Web.HttpContext.Current.SetSessionStateBehavior(System.Web.SessionState.SessionStateBehavior.Required);
             
        }

        // Global error catcher
        void Application_Error(object sender, EventArgs e)
        { 
        }

        void Session_Start(object sender, EventArgs e)
        {
 
        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends.
            // Note: The Session_End event is raised only when the session state mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer
            // or SQLServer, the event is not raised.
        }

    }
}
