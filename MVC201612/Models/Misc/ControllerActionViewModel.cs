using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC201612.Models.Misc
{
    public class ControllerActionViewModel
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string ReturnType { get; set; }

        public string Attributes { get; set; }
    }
}