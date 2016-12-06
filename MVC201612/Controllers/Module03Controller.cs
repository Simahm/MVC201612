using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC201612.Controllers
{
    public class Module03Controller : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ContentResult Content()
        {
            ContentResult c = new ContentResult();
            c.Content = "<h1>Test</h1>";
            return c;
        }

        public ContentResult Content2()
        {
            return Content("<h1>test</h1>");
        }

        public ActionResult Redirect()
        {
            return Redirect("http://www.google.dk");
        }

        public ActionResult Redirect2()
        {
            return RedirectToAction("List", "Module02");
        }

        public ActionResult JSON()
        {
            var lst = new MVC201612.Models.Module02.PersonHelper().GetAllPeople();
            return Json(lst, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Status()
        {
            HttpStatusCodeResult r = new HttpStatusCodeResult(500, "Klokken er nu = frokost");
            return r;
        }

        public ActionResult View2()
        {
            return View();
        }

        public ActionResult View3()
        {
            return View("TestView");
        }
    }
}