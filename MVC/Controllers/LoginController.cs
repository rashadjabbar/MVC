using MVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class LoginController : Controller
    {
        
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string AdminName, string AdminPassword)
        {
            var dt = SQL.Execute($@"select CONVERT(VARCHAR(32), HashBytes('MD5', concat('NaN' , AdminId , 'NaN')), 2) from AdminInfo where AdminName = N'{AdminName}' and AdminPassword = N'{AdminPassword}'");
            if (dt.Rows.Count == 1)
            {
                HttpCookie cookie1 = new HttpCookie("Admins");
                cookie1.Values.Add("UserId", dt.Rows[0][0].ToString());
                Response.Cookies.Add(cookie1);
                return RedirectToAction("../AdminPanel/Index");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Logout(string logout)
        {
            Response.Cookies["Admins"].Expires = DateTime.Now.AddDays(-1);
            return RedirectToAction("../Login/Index");
        }
    }
}