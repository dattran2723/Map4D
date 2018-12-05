using Map4D.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Map4D.Areas.Admin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GuestPost(GuestModels data)
        {
            var post = db.GuestModels.ToList();
            return View(post);
        }

    }
}