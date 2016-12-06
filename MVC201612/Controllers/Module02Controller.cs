using MVC201612.Models.Module02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC201612.Controllers
{
    public class Module02Controller : Controller
    {
        // /Module02/List
        public ActionResult List()
        {
            var lst = new MVC201612.Models.Module02.PersonHelper().GetAllPeople();
            return View(lst);
        }

        public ActionResult ListVM()
        {
            var lst = new MVC201612.Models.Module02.PersonHelper().GetAllPeopleAsViewModel();
            return View(lst);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            // test resource
            var l = MVC201612.Models.Resource.Views.Module02.edit.country;

            var p = new MVC201612.Models.Module02.PersonHelper().GetPerson();
            return View(p);
        }

        [HttpPost]
        public ActionResult Edit(Person p)
        {
            if (ModelState.IsValid)
                return RedirectToAction("EditOk");
            else
                return View();
        }

    }
}