using Map4D.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Map4D.Controllers
{

    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        SmtpClient client = new SmtpClient();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GetInTouch()
        {
            return View();
        }
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult GetInTouch(GuestModels data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    data.DateUp = DateTime.Now;
                    db.GuestModels.Add(data);
                    db.SaveChanges();
                    SendMail(data.GuestEmail);
                    return RedirectToAction("Index");
                }
            }catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
            }
            return View("Index");
        }


        public void SendMail(string guestMail)
        {
            StringBuilder Body = new StringBuilder();
            Body.Append("<p>Cảm ơn quý khách đã sử dụng sản phẩm của chúng tôi, chúng tôi sẽ liên lạc lại cho quý khách trong thời gian sớm nhất:</p>");
            Body.Append("<table>");
            Body.Append("<tr><td> from IOT Company </td>");
            Body.Append("</table>");
            MailMessage mail = new MailMessage();
            mail.To.Add(guestMail);
            mail.From = new MailAddress("nguyendn112@gmail.com");
            mail.Subject = "Thư cảm ơn";
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


    }
}