using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string AdminName, string AdminPassword)
        {
            var dt = SQL.Execute($@"select * from AdminInfo where AdminName = N'{AdminName}'");
            if (dt.Rows.Count != 0)
            {
                return RedirectToAction("../Register/Index");
            }
            else
            {
                SQL.Execute($@"insert into AdminInfo values (N'{AdminName}' , N'{AdminPassword}')");
                return RedirectToAction("../Login/Index");
            }
        }
    }
}