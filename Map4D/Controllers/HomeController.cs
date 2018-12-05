using Map4D.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Map4D.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
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
            if (ModelState.IsValid)
            {
                data.DateUp = DateTime.Now;
                db.GuestModels.Add(data);
                db.SaveChanges();
                ViewBag.Message = "Thank you for giving us advice";
                return RedirectToAction("Index");
            }
            return View("Index");
        }


    }
}