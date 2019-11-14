using MvcBasic_Clone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormContext = MvcBasic_Clone.Models.FormContext;

namespace MvcBasic_Clone.Controllers
{
    public class FormController : Controller
    {
        private FormContext db = new FormContext();
        private FriendContext frienddb = new FriendContext();
        // GET: Form
        public ActionResult Index()
        {
            return View(db.Infoes.ToList());
        }

        public ActionResult Indexfriend()
        {
            return View(frienddb.Employees.ToList());
        }
        // GET: Friends/Create
        public ActionResult UserInfo()
        {
            return View();
        }


        // POST: Friends/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserInfo([Bind(Include = "Id,Name,Phone,Email,Gender")] Info input)
        {
            if (ModelState.IsValid)
            {
                db.Infoes.Add(input);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(input);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserData(string name,string phone,string email,string gender)
        {
            Info info = new Info { Name = name, Phone = phone, Email = email, Gender = gender };

            db.Infoes.Add(info);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}