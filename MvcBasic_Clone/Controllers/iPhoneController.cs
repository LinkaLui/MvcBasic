using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class iPhoneController : Controller
    {
        // GET: iPhone
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult iPhonePage()
        {
            return View();
        }
    }
}