using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Map4D.Models;

namespace Map4D
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);
            AutoMapper.Mapper.Initialize(conf =>
            {
                conf.CreateMap<CustomerEditViewModels, Customer>();
                conf.CreateMap<CustomerRegisterViewModels, Customer>();
            });
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_AcquireRequestState(Object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            //start code of TranDat
            //disable the cache for the entire application
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1));
            Response.Cache.SetNoStore();
            //end code of TranDat

            HttpCookie cookie = HttpContext.Current.Request.Cookies["Language1"];
            if (cookie != null && cookie.Value != null)
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cookie.Value);
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(cookie.Value);
            }
            else
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vn");
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vn");
            }
        }
        //protected void Application_BeginRequest(object sender, EventArgs e)
        //{
        //    HttpCookie cookie = HttpContext.Current.Request.Cookies["Language"];
        //    if (cookie != null && cookie.Value != null)
        //    {
        //        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vn");
        //        System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vn");
        //    }
        //}
    }
}
