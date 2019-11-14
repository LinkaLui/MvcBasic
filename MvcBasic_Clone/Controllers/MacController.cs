using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class MacController : Controller
    {
        // GET: Mac
        public ActionResult MacPage()
        {
            return View();
        }
    }
}