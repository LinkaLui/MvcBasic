using MvcBasic_Clone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class FamiliesController : Controller
    {
        // GET: Families
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FamilyList()
        {
            List<Family> employees = new List<Family>
            {
                new Family {Id = 10001,IdNumber = "H123456789",Name = "David",Phone = "0933-154228",Age = 30,City = "Taipei"},
                new Family {Id = 10002,IdNumber = "H223456789",Name = "Mary",Phone = "0933-123456",Age = 20,City = "Taipei"}
            };
            return View(employees);
        }
    }
}