using Map4D.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Map4D.Controllers
{

    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        SmtpClient client = new SmtpClient();

        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")] /// Xóa cache không cho điền lại form submit 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChangeLanguage(String LanguageAbbreviation, string url)
        {
            if (LanguageAbbreviation != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(LanguageAbbreviation);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(LanguageAbbreviation);
            }
            HttpCookie cookie = new HttpCookie("ChangeLanguage");
            cookie.Value = LanguageAbbreviation;
            Response.Cookies.Add(cookie);
            return Redirect(url);
        }

        public ActionResult ProductValue()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Products()
        {
            ViewBag.Title = Map4D.Resources.My_texts.Product;
            return View("CommingSoon");
        }

        public ActionResult CommingSoon()
        {
            return View();
        }

        public ActionResult Solution()
        {
            ViewBag.Title = Map4D.Resources.My_texts.Solution;
            return View("CommingSoon");
        }

        public ActionResult Document()
        {
            ViewBag.Title = Map4D.Resources.My_texts.Document;
            return View();
            // return View("CommingSoon");
        }

        public ActionResult Pricing()
        {
            ViewBag.Title = Map4D.Resources.My_texts.Pricing;
            return View();
        }
        //public ActionResult GetInTouch()
        //{
        //    return View();
        //}

        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult GetInTouch(Contact data)
        {
            if (ModelState.IsValid)
            {
                data.CreatedDate = DateTime.Now;
                db.Contacts.Add(data);
                db.SaveChanges();
                SendMail(data.Email);
                ViewBag.Message = "success";
                return View("Index");
            }
            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, message);
            }
            return View("Index");

        }

        public void SendMail(string guestMail)
        {
            StringBuilder Body = new StringBuilder();
            Body.Append("<p>" + Map4D.Resources.My_texts.ThuCamOn + "</p>");
            Body.Append("<table>");
            Body.Append("<tr><td> from IOT Company </td>");
            Body.Append("</table>");
            MailMessage mail = new MailMessage();
            mail.To.Add(guestMail);
            mail.From = new MailAddress("iotocteam123@gmail.com", "IOT team");
            mail.Subject = Map4D.Resources.My_texts.TieuDeMail;
            mail.Body = Body.ToString();// phần thân của mail ở trên
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new System.Net.NetworkCredential("iotocteam123@gmail.com", "Klapaucius123");// tài khoản Gmail của bạn
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }

        public ActionResult Product()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}