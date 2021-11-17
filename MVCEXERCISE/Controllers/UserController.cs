using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEXERCISE.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return Content("Hello");
            
        }
        public ActionResult Book()
        {
            ViewBag.Book1 = "Book1";
            ViewBag.Book2 = "Book2";
          
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Login(string pass)
        {
            if (pass == "admin")
            {
                return RedirectToAction("Book", "Admin");
            }
            else
            {
                string Url = "http://www.facebook.com";
                return Redirect(Url);
            }

        }

    }
}