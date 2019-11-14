using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class ErrorHandlerController : Controller
    {
        // GET: ErrorHandler
        public ActionResult ErrorMessage()
        {
            if (!TempData.ContainsKey("ErrorMessageText"))
            {
                return new EmptyResult();
            }

            TempData.Keep();

            return View();
        }
    }
}