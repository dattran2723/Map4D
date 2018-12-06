using System;
using System.Collections.Generic;
using System.Linq;
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
            //AutoMapper.Mapper.Initialize(conf =>
            //{
            //    conf.CreateMap<CustomerListViewModels, Customers>();
            //    conf.CreateMap<CustomerRegisterViewModels, Customers>();
            //});
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
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
    }
}
