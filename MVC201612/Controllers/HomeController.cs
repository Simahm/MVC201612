using MVC201612.Models.Misc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace MVC201612.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            var controlleractionlist = asm.GetTypes()
                    .Where(type => typeof(System.Web.Mvc.Controller).IsAssignableFrom(type))
                    .SelectMany(type => type.GetMethods(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public))
                    .Where(m => !m.GetCustomAttributes(typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute), true).Any())
                    .Select(x => new ControllerActionViewModel { ControllerName = x.DeclaringType.Name.Replace("Controller",""), ActionName = x.Name, ReturnType = x.ReturnType.Name, Attributes = String.Join(",", x.GetCustomAttributes().Select(a => a.GetType().Name.Replace("Attribute", ""))) })
                    .OrderBy(x => x.ControllerName).ThenBy(x => x.ActionName).ToList();
            var grp = controlleractionlist.GroupBy(i => i.ControllerName).ToDictionary(i => i.Key, i=>i.ToList());
            return View(grp);
        }
    }
}