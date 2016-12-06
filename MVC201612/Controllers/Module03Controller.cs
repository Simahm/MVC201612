using MVC201612.Models.Module02;
using MVC201612.Models.Module03;
using System;
using System.Collections.Generic;
using System.Dynamic;
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

        public ActionResult View4()
        {
            var lst = new MVC201612.Models.Module02.PersonHelper().GetAllPeople();
            ViewBag.fakturaer = Guid.NewGuid().ToString();
            return View(lst);

        }

        public ActionResult View5()
        {
            var lst = new MVC201612.Models.Module02.PersonHelper().GetAllPeople();
            ViewBag.fakturaer = Guid.NewGuid().ToString();
            return View(lst);

        }

        public ActionResult View6()
        {
            PersonFakturaViewModel m = new PersonFakturaViewModel();
            m.Personer = new MVC201612.Models.Module02.PersonHelper().GetAllPeople();
            m.Faktura = Guid.NewGuid().ToString();
            return View(m);

        }

        public ActionResult View7()
        {
            //var t = new { name = "Mikkel" };
            dynamic t = new ExpandoObject();
            t.name = "Mikkel";
            return View(t);

        }

        public ActionResult GetUser(string Username, int? age)
        {
            return View();

        }

        public ActionResult GetUser2()
        {

            return View(new User() { Username = "ælkælk" });

        }
        [HttpPost]
        public ActionResult GetUser2(User u)
        {
            return View();

        }

        public ActionResult GetUser3([Bind(Exclude ="IsAdmin")]User u)
        {
            return View();

        }
    }

    // Skal ikke ligge her med mangler kage.. (skal ligge i /models)
    class PersonFakturaViewModel {  // Hedder også DTO'er PersonFakturaDTO
        public List<Person> Personer { get; set; }
        public string Faktura { get; set; }
        // + diverse
    }
}