using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Map4D.Controllers
{
    public class LanguageController : Controller
    {
        // GET: Language
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Change(string LanguageAbbervation, string currentController, string currentAction)
        {

            if (LanguageAbbervation != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(LanguageAbbervation);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(LanguageAbbervation);
            }
            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = LanguageAbbervation;
            Response.Cookies.Add(cookie);
            //string url = "~/Views/" + currentController + "/" + currentAction + ".cshtml";
            //return View(url);
            return View("~/Views/Home/Index.cshtml");
        }
    }
}