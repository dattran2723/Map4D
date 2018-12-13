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

            if (HttpContext.Current.Request.RequestContext.RouteData.Values.ContainsKey("language"))
            {
                var language = (string)HttpContext.Current.Request.RequestContext.RouteData.Values["language"];
                if (language != null)
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
                }
            }
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            string culture = "vi";
            var httpCookie = Request.Cookies["language"];
            if (httpCookie != null)
            {
                culture = httpCookie.Value;
            }
            else
            {
                HttpCookie language = new HttpCookie("language");
                language.Value = culture;
                language.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(language);
            }
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture;
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
